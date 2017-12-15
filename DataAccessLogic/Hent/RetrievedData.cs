using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DataAccessLogic.Hent;
using DTO;

namespace DataAccessLogic
{
    public class RetrievedData :IRetrievedData<PatientDTO>
    {
        private ICommandBuilder<PatientDTO> _operationCommandBuilder;
        private ICommandBuilder<OperationsDTO> _measurementCommandBuilder;
        private IQueryBuilder<List<OperationsDTO>> _operationQueryBuilder;
        private IQueryBuilder<PatientDTO> _measurementQueryBuilder;

        public RetrievedData()
        {
            _operationCommandBuilder = new OperationCommandBuilder();
            _measurementCommandBuilder = new MeasurementCommandBuilder();
            _operationQueryBuilder = new OperationQueryBuilder();
            _measurementQueryBuilder = new MeasurementQueryBuilder();
        }

        /// <summary>
        /// Gets all operations associated with the patients CPR
        /// </summary>
        /// <param name="patient">The patient whose operations we want to retrieve</param>
        /// <returns>PatientDTO holding the retrieved operation data</returns>
        public PatientDTO GetOperations (PatientDTO patient)
        {
            var patientOut = new PatientDTO() {ListOperation = new List<OperationsDTO>()};
            var idList = new List<int>();

            var operationQuery = _operationQueryBuilder.BuildQuery(new List<OperationsDTO>());
            
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _operationCommandBuilder.BuildCommand(patient, conn, operationQuery))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                var tempOperation = new OperationsDTO();
                                tempOperation.OperationsID = rdr.GetInt32(rdr.GetOrdinal("OperationsID"));
                                tempOperation.Kalibrering = rdr.GetInt32(rdr.GetOrdinal("Kalibrering"));
                                tempOperation.Kommentar = SafeGetString(rdr, "Kommentar");
                                tempOperation.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt"));
                                tempOperation.Nulpunktjustering = rdr.GetInt32(rdr.GetOrdinal("Nulpunktsjustering"));

                                patientOut.ListOperation.Add(tempOperation);
                            }
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return patientOut;
        }

        /// <summary>
        /// Gets all measurement for each operation associated with the patients CPR
        /// </summary>
        /// <param name="patient">The patient whose measurements we want to retrieve</param>
        /// <returns>PatientDTO holding the retrieved measurement data corresponding to the correct 
        /// operations</returns>
        public PatientDTO HentData(PatientDTO patient)
        {
            var patientOut = GetOperations(patient);

            var query = _measurementQueryBuilder.BuildQuery(patient);


            foreach (var operation in patientOut.ListOperation)
            {
                operation.Maaling = new List<MaalingDTO>();
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _measurementCommandBuilder.BuildCommand(operation, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                var measurement = new MaalingDTO();
                                measurement.MaaleData = (byte[]) rdr["Maaledata"];
                                measurement.Sekvensnr = rdr.GetInt32(rdr.GetOrdinal("SekvensNummer"));
                                measurement.MaaleID = rdr.GetInt32(rdr.GetOrdinal("MaaleID"));

                                operation.Maaling.Add(measurement);
                            }
                        }
                    }
                }
            }
            return patientOut;
        }

        /// <summary>
        /// Performs null checking when reading strings from database, as string in C# cannot be null
        /// </summary>
        /// <param name="reader">SqlDataReader to read the data</param>
        /// <param name="columnName">Name of the column to read from</param>
        /// <returns></returns>
        private string SafeGetString(SqlDataReader reader, string columnName)
        {
            if (!reader.IsDBNull(reader.GetOrdinal(columnName)))
            {
                return reader.GetString(reader.GetOrdinal(columnName));
            }
            return String.Empty;
        }

      

    }
}
