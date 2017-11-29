﻿using System;
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
        private IQueryBuilder<PatientDTO> _measurementQueryBuilder;

        public RetrievedData()
        {
            _operationCommandBuilder = new OperationSaveCommandBuilder();
            _measurementCommandBuilder = new MeasurementSaveCommandBuilder();
            _operationQueryBuilder = new OperationSaveQueryBuilder();
            _measurementQueryBuilder = new MeasurementSaveQueryBuilder();
        }

        public PatientDTO GetOperations (PatientDTO patient)
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

        public PatientDTO HentData(PatientDTO patient)
        {
            var patientOut = GetOperations(patient);

            var query = _measurementQueryBuilder.BuildQuery(patient);
            var measurement = new MaalingDTO();


            foreach (var operation in patientOut.ListOperation)
            {
                using (SqlConnection conn = new SqlConnection(query))
                {
                    conn.Open();
                    using (SqlCommand cmd = _measurementCommandBuilder.BuildCommand(operation, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                measurement.MaaleData = (byte[]) rdr["Måledata"];
                                measurement.Sekvensnr = rdr.GetInt32(rdr.GetOrdinal("Sekvensnr"));
                                measurement.MaaleID = rdr.GetInt32(rdr.GetOrdinal("Maaleid"));

                                operation.Maaling.Add(measurement);
                            }
                        }
                    }
                }
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
