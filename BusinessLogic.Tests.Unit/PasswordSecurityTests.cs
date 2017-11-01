using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class PasswordSecurityTests
    {
        private string _password1;
        private string _password2;
        private byte[] _salt1;
        private byte[] _salt2;

        [SetUp]
        public void Setup()
        {
            _password1 = "1234abcd";
            _password2 = "abcd1234";
            _salt1 = PasswordSecurity.GenerateSalt();
            _salt2 = PasswordSecurity.GenerateSalt();
        }


        [Test]
        public void HashAndSaltPassword_DifferentSalt_HashesDontMatch()
        {
            byte[] hashedPassword1 = PasswordSecurity.HashAndSaltPassword(_password1, _salt1);
            byte[] hashedPassword2 = PasswordSecurity.HashAndSaltPassword(_password1, _salt2);

            Assert.That(!hashedPassword1.SequenceEqual(hashedPassword2), "Error message: hashed passwords are equal even though using different salts");
        }

        [Test]
        public void HashAndSaltPassword_SameSalt_HashesMatch()
        {
            byte[] hashedPassword1 = PasswordSecurity.HashAndSaltPassword(_password1, _salt1);
            byte[] hashedPassword2 = PasswordSecurity.HashAndSaltPassword(_password1, _salt1);

            Assert.That(hashedPassword1.SequenceEqual(hashedPassword2), "Error message: Hashed passwords are not equal even though same salt and password is used");
        }

        [Test]
        public void HashAndSaltPassword_DifferentPasswordSameSalt_HashesDontMatch()
        {
            byte[] hashedPassword1 = PasswordSecurity.HashAndSaltPassword(_password1, _salt1);
            byte[] hashedPassword2 = PasswordSecurity.HashAndSaltPassword(_password2, _salt1);

            Assert.That(!hashedPassword1.SequenceEqual(hashedPassword2), "Error message: Hashed passwords are equal even though different passwords were used");
        }


    }
}
