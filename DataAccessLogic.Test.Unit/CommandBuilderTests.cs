using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using NUnit.Framework;

namespace DataAccessLogic.Test.Unit
{
    [TestFixture]
    class CommandBuilderTests
    {
        private ICommandBuilder _commandBuilder;
        private SqlCommand _command;
        private PatientDTO _patient;
        [SetUp]
        public void Setup()
        {
            _commandBuilder = new SaveCommandBuilder();
            _command = new SqlCommand();
            _patient = new PatientDTO()
            {
                Maalinger = new MaalingDTO()
                {
                    Kommentar = "Test",
                    MaaleData = new byte[] {123, 45, 96, 32},
                    MaaleTidspunkt = DateTime.Now
                }
            };
            _command.Parameters.AddWithValue("@maaledata", _patient.Maalinger.MaaleData);
            _command.Parameters.AddWithValue("@kommentar", _patient.Maalinger.Kommentar);
            _command.Parameters.AddWithValue("@maaletidspunkt", _patient.Maalinger.MaaleTidspunkt);
        }

        [Test]
        public void BuildCommand_PatientDTO_AddsCorrectParameters()
        {
            var cmd = _commandBuilder.BuildCommand(_patient, new SqlConnection(), "query");
            string result = "";
            foreach (SqlParameter p in cmd.Parameters)
            {
                result += p.ParameterName + ", ";
            }
            Assert.That(cmd.Parameters == _command.Parameters, "Error message: Parameters not equal, generated parameters were: {0}", result);
        }
    }
}
