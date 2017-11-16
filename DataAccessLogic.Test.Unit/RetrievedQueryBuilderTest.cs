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
        private IQueryBuilder<MedarbejderDTO> _queryBuilderMedarbejderOP;
        private IQueryBuilder<MedarbejderDTO> _queryBuilderMedarbejderTek;
        private OPSygeplejerskeDTO _opSygeplejerske;
        private TeknikerDTO _tekniker;
        private string _expectedQueryOP;
        private string _expectedQueryTek;


        [SetUp]
        public void SetUp()
        {
            _expectedQueryOP = "select * from OPsygeplejerske where Brugernavn = @brugernavn";
            _expectedQueryTek = "select * from Tekniker where Brugernavn = @brugernavn";
            _queryBuilderMedarbejderOP = new RetrivedLoginQueryBuilder("OPsygeplejerske");
            _queryBuilderMedarbejderTek = new RetrivedLoginQueryBuilder("Tekniker");

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
            string query = _queryBuilderMedarbejderOP.BuildQuery(_opSygeplejerske); 
            Assert.That(_expectedQueryOP.SequenceEqual(query), string.Format("Error message: Generated query does not match the expected. Generated was {0}, expected was: {1}", query, _expectedQueryOP));
        }

        public void BuildQueryTek_CreateCorrectQueryTek_CorrectQueryTek()
        {
            string query = _queryBuilderMedarbejderTek.BuildQuery(_tekniker);
            Assert.That(_expectedQueryTek.SequenceEqual(query), string.Format("Error message: Generated query does not match the expected. Generated was {0}, expected was: {1}", query, _expectedQueryTek));
        }

    }
}
