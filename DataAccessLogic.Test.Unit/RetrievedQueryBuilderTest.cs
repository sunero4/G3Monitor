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
    class RetrievedQueryBuilderTest
    {
        private IQueryBuilderMedarbejder _queryBuilderMedarbejderOP;
        private IQueryBuilderMedarbejder _queryBuilderMedarbejderTek;
        private OPSygeplejerskeDTO _opSygeplejerske;
        private TeknikerDTO _tekniker;
        private string _expectedQueryOP;
        private string _expectedQueryTek;


        [SetUp]
        public void SetUp()
        {
            _expectedQueryOP = "select * from OPsygeplejerske where Brugernavn = @brugernavn";
            _expectedQueryTek = "select * from Tekniker where Brugernavn = @brugernavn";
            _queryBuilderMedarbejderOP = new RetrivedLoginQueryBuilder();
            _queryBuilderMedarbejderTek = new RetrivedLoginQueryBuilder();

            _opSygeplejerske = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplejer",
                HashedPassword = new byte[] {22, 33, 44, 44}
            };
            _tekniker = new TeknikerDTO()
            {
                Brugernavn = "Tekniker",
                HashedPassword = new byte[] { 22, 33, 44, 44 }
            };
        }

        [Test]
        public void BuildQueryOP_CreateCorrectQueryOP_CorrectQueryOP()
        {
            string query = _queryBuilderMedarbejderOP.BuildQuery(_opSygeplejerske, "OPsygeplejerske"); 
            Assert.That(_expectedQueryOP.SequenceEqual(query), string.Format("Error message: Generated query does not match the expected. Generated was {0}, expected was: {1}", query, _expectedQueryOP));
        }

        public void BuildQueryTek_CreateCorrectQueryTek_CorrectQueryTek()
        {
            string query = _queryBuilderMedarbejderTek.BuildQuery(_tekniker, "Tekniker");
            Assert.That(_expectedQueryTek.SequenceEqual(query), string.Format("Error message: Generated query does not match the expected. Generated was {0}, expected was: {1}", query, _expectedQueryTek));
        }

    }
}
