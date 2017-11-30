using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    class DiastolicTestUnit
    {
        // Test af Diastole  
        [Test]
        public void Diastolic_Calculate_DiastolicIsTwo()
        {
            var _uut = new Diastolic();
            var list = new List<double>() { 3, 5, 1, 7, 2 };
            int timesdiff = 2;
            int resualt = 2;
            _uut.Calculate(list, timesdiff);

            Assert.That(_uut.Calculate(list, timesdiff), Is.EqualTo(resualt), "List count should be 2, but is {0}", resualt);
        }

        [Test]
        public void Diastolic_Calculate_DiastolicIsOne()
        {
            var _uut = new Diastolic();
            var list = new List<double>() { 3, 5, 10, 1, 2 };
            int timesdiff = 2;
            int resualt = 1;
            _uut.Calculate(list, timesdiff);

            Assert.That(_uut.Calculate(list, timesdiff), Is.EqualTo(resualt), "List count should be 2, but is {0}", resualt);
        }
    }
}
