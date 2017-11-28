using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic.Hent;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class RetrievedData :IRetrievedData<PatientDTO>
    {


        private ICommandBuilder<PatientDTO> _operationCommandBuilder;
        private ICommandBuilder<OperationsDTO> _measurementCommandBuilder;
        private IQueryBuilder<List<OperationsDTO>> _operationQueryBuilder;
        private IQueryBuilder<List<MaalingDTO>> _measurementQueryBuilder;

        public RetrievedData()
        {
            _operationCommandBuilder = new OperationCommandBuilder();
            _measurementCommandBuilder = new MeasurementCommandBuilder();
            _operationQueryBuilder = new OperationQueryBuilder();
            _measurementQueryBuilder = new MeasurementQueryBuilder();
        }

        public PatientDTO (PatientDTO patient)
        {
            var patientOut = new PatientDTO() {ListOperation = new List<OperationsDTO>()};
            var idList = new List<int>();

            var operationQuery = _operationQueryBuilder.BuildQuery(new List<OperationsDTO>());

            var tempOperation = new OperationsDTO();
            try
            {
                using (SqlConnection conn = new SqlConnection(operationQuery))
                {
                    conn.Open();
                    using (SqlCommand cmd = _operationCommandBuilder.BuildCommand(patient, conn, operationQuery))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                tempOperation.OperationsID = rdr.GetInt32(rdr.GetOrdinal("OperationsID"));
                                tempOperation.Kalibrering = rdr.GetInt32(rdr.GetOrdinal("Kalibrering"));
                                tempOperation.Kommentar = SafeGetString(rdr, "Kommentar");
                                tempOperation.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt"));
                                tempOperation.Nulpunktjustering = rdr.GetInt32(rdr.GetOrdinal("Nulpunktsjustering"));
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
        }

        public PatientDTO HentData(PatientDTO patient)
        {
            PatientDTO patientOut = new PatientDTO() {ListOperation = new List<OperationsDTO>()};
            
            var query = _queryBuilder.BuildQuery(patient);
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(patient, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            OperationsDTO operation = new OperationsDTO(); 
                            while (rdr.Read())
                            {
                                patientOut.CPR = rdr.GetString(rdr.GetOrdinal("CPR"));
                                patientOut.Fornavn = rdr.GetString(rdr.GetOrdinal("Fornavn"));
                                patientOut.Efternavn = rdr.GetString(rdr.GetOrdinal("Efternavn"));
                                
                                //SS 
                                operation.Maaling[0].MaaleData = (byte[]) rdr["Måledata"];
                                operation.Kommentar = rdr.GetString(rdr.GetOrdinal("Kommentar"));
                                operation.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt")); 

                                patientOut.ListOperation.Add(operation); 
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            return patientOut; 

        }

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
