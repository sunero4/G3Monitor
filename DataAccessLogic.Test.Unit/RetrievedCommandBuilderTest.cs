using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using NUnit.Framework;
using NSubstitute; 


namespace DataAccessLogic.Test.Unit
{

    [TestFixture]
    class RetrievedCommandBuilderTest
    {
        private ICommandBuilder<MedarbejderDTO> _uut;
        private SqlCommand _cmd;
        private MedarbejderDTO _medarbejderDto;
            

        [SetUp]
        public void Setup()
        {
            _medarbejderDto = new OPSygeplejerskeDTO();
           _uut = new RetrivedLoginCommandBuilder();
            _cmd = new SqlCommand();
            _cmd.Parameters.AddWithValue("@brugernavn", _medarbejderDto.Brugernavn);
        }

        [Test]
        public void BuildCommand_MedarbejderDTO_MedarbejderCommandIsTrue()
        {
            var cmd = _uut.BuildCommand(_medarbejderDto,new SqlConnection(),"" ); 
            Assert.That(cmd.Parameters == _cmd.Parameters, Is.EqualTo(true));
        }
    }
}
