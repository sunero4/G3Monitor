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
        private MedarbejderDTO _medarbejder3;
        private MedarbejderDTO _medarbejder4;
        private MedarbejderDTO _medarbejder5;
        private MedarbejderDTO _medarbejder6;
        private MedarbejderDTO _medarbejder7;
        private MedarbejderDTO _medarbejder8;
        private MedarbejderDTO _medarbejder9;
        private MedarbejderDTO _medarbejder10;
        private Login _uut;
       

        [SetUp]
        public void Setup()
        {         
            _uut = new Login();
            _medarbejder = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplejer",
                HashedPassword = new byte[] {22, 33, 44, 44}
            };
            _medarbejder2 = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplejer",
                HashedPassword = new byte[] {22, 33, 44, 44}
            };
            // OPsygeplejerske med andre hashedpassword end de andre to 
            _medarbejder3 = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplejer",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
            _uut = new Login();
            _medarbejder4 = new TeknikerDTO()
            {
                Brugernavn = "Tekniker",
                HashedPassword = new byte[] { 22, 33, 44, 44 }
            };
            _medarbejder5 = new TeknikerDTO()
            {
                Brugernavn = "Tekniker",
                HashedPassword = new byte[] { 22, 33, 44, 44 }
            };
            // Teknikker med andre hashedpassword end de andre to 
            _medarbejder6 = new TeknikerDTO()
            {
                Brugernavn = "Tekniker",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
            // Til test af brugernavn med forkert længde 
            _medarbejder7 = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplej",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
            _medarbejder8 = new OPSygeplejerskeDTO()
            {
                Brugernavn = "Sygeplej",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
            _medarbejder9 = new TeknikerDTO()
            {
                Brugernavn = "Teknikerer",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
            _medarbejder10 = new TeknikerDTO()
            {
                Brugernavn = "Teknikerer",
                HashedPassword = new byte[] { 23, 34, 40, 44 }
            };
          

        }

        // Test af sygeplejerske, to ens login, og to forskellige 
        [Test]
        public void CheckLogin_TwoOPUserNamesIsEqaul_OPUserNamesIsEqaul()
        {
            var uut = _uut.CheckLogin(_medarbejder, _medarbejder2);
            Assert.That(uut);
        }
        [Test]
        public void CheckLogin_TwoOPUserDifferentUserName_OPUserNamesFalse()
        {
            var uut = _uut.CheckLogin(_medarbejder, _medarbejder3);
            Assert.That(uut == false);
        }

        // Test af tekniker, to ens login, og to forskellige 
        [Test]
        public void CheckLogin_TwoTekUserNamesIsEqaul_TekUserNamesIsEqaul()
        {
            var uut = _uut.CheckLogin(_medarbejder4, _medarbejder5);
            Assert.That(uut);
        }
        [Test]
        public void CheckLogin_TwoTekUserDifferentUserName_TekUserNamesFalse()
        {
            var uut = _uut.CheckLogin(_medarbejder4, _medarbejder6);
            Assert.That(uut == false);
        }

        // Test af login, en tekniker og en sygeplejeske 
        [Test]
        public void CheckLogin_OneTekUserOneOPUser_CheckLoginFalse()
        {
            var uut = _uut.CheckLogin(_medarbejder, _medarbejder6);
            Assert.That(uut == false);
        }

        // Test af login med forkorte brugernanve(8) hos OPsygeplejeske 
        public void CheckLogin_TwoOPToShortUserName_CheckLoginFalse()
        {
            var uut = _uut.CheckLogin(_medarbejder7, _medarbejder8);
            Assert.That(uut == false);
        }
        // Test af login med forlange brugernanve(10) hos teknikker 
        public void CheckLogin_TwoTekToLongUserName_CheckLoginFalse()
        {
            var uut = _uut.CheckLogin(_medarbejder9, _medarbejder10);
            Assert.That(uut == false);
        }

    }
}
