using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using DTO;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class LoginTest
    {
        private MedarbejderDTO _medarbejder;
        private MedarbejderDTO _medarbejder2;
        private Login _login;

        [SetUp]
        public void Setup()
        {
            _medarbejder = new OPSygeplejerskeDTO();
            _medarbejder2 = new OPSygeplejerskeDTO();

        }

    }
}
