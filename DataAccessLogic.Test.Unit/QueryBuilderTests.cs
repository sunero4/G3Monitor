using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DTO;

namespace DataAccessLogic.Test.Unit
{
    [TestFixture]
    class QueryBuilderTests
    {
        private IQueryBuilder<PatientDTO> _queryBuilder;
        private PatientDTO _patient;
        private MaalingDTO _maaling;
        private string _expectedQuery;

        [SetUp]
        public void Setup()
        {
            _expectedQuery = "INSERT INTO TestTable(Column1, Column2, Column3) VALUES (@maaledata, @kommentar, @maaletidspunkt)";
            _queryBuilder = new SaveQueryBuilder() { ColumnNames = new List<string>() { "Column1", "Column2", "Column3" }, Tablename = "TestTable"};
            //Create Patient and Maaling DTO with arbitrary values - only names of the properties are used in the
            //Querybuilder
            _maaling = new MaalingDTO()
            {
                Kommentar = "Test",
                MaaleID = 1,
                MaaleTidspunkt = DateTime.Now,
                MaaleData = new byte[] {123, 45, 32, 98}
            };
            _patient = new PatientDTO()
            {
                CPR = "1234567890",
                Fornavn = "Anders",
                Efternavn = "Kloborg",
                Maalinger = _maaling
            };
        }

        [Test]
        public void BuildQuery_CreatesCorrectQuery()
        {
            string query = _queryBuilder.BuildQuery(_patient);
            Assert.That(_expectedQuery.SequenceEqual(query), String.Format("Error message: Generated query does not match the expected. Generated was {0}, expected was: {1}", query, _expectedQuery));
        }

    }
}
