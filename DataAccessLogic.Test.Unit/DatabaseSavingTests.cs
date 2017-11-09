using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using NSubstitute;
using NUnit.Framework;

namespace DataAccessLogic.Test.Unit
{
    class DatabaseSavingTests
    {
        private IQueryBuilder _queryBuilder;
        private ICommandBuilder _commandBuilder;
        private ISaving _saving;
        private PatientDTO _patient;

        [SetUp]
        public void Setup()
        {
            _patient = new PatientDTO() {CPR = "1234567890" ,Maalinger = new MaalingDTO() {Kommentar = "", MaaleTidspunkt = DateTime.Now, MaaleData = new byte[] {123, 45, 67}}};
            _saving = new DatabaseSaving();
            _queryBuilder = Substitute.For<IQueryBuilder>();
            _commandBuilder = Substitute.For<ICommandBuilder>();
        }

        //Test won't run because the statement that I am trying to execute references a foreign key not in the
        //database, therefore making it impossible to reach the code calling the commandbuilder.
        [Test]
        public void SaveBloodPressureData_CheckIfMethodCalled_QueryBuilderIsCalled()
        {
            _saving.SaveBloodPressureData(_patient);
            _queryBuilder.Received().BuildQuery(_patient);
        }

        //Test won't run because the statement that I am trying to execute references a foreign key not in the
        //database, therefore making it impossible to reach the code calling the commandbuilder.
        [Test]
        public void SaveBloodPressureData_CheckIfMethodCalled_CommandBuilderIsCalled()
        {
            _saving.SaveBloodPressureData(_patient);
            _commandBuilder.Received().BuildCommand(_patient, new SqlConnection(ConnectionInfo.Connectionstring), _queryBuilder.BuildQuery(_patient));
        }


    }
}
