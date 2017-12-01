using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class SystolicTestUnit
    {
        // Test af toppunkt 
        [Test]
        public void Systolic_Calculate_SystolicIsTen()
        {
            var _uut = new Systolic();
            var list = new List<double>() { 3, 5, 9, 7, 10 };
            int timesdiff = 2; 
            int resualt = 10;
            _uut.Calculate(list, timesdiff); 

            Assert.That(_uut.Calculate(list,timesdiff), Is.EqualTo(resualt), "Resualt should be 10, but is {0}", resualt);
        }

        [Test]
        public void Systolic_Calculate_SystolicIsNine()
        {
            var _uut = new Systolic();
            var list = new List<double>() { 3, 5, 10, 7, 9 };
            int timesdiff = 2;
            int resualt = 9;
            _uut.Calculate(list, timesdiff);

            Assert.That(_uut.Calculate(list, timesdiff), Is.EqualTo(resualt), "Resualt should be 9, but is {0}", resualt);
        }

        [Test]
        public void Systolic_Calculate_SystolicIsSeven()
        {
            var _uut = new Systolic();
            var list = new List<double>() { 3, 5, 10, 7, 6 };
            int timesdiff = 2;
            int resualt = 7;
            _uut.Calculate(list, timesdiff);

            Assert.That(_uut.Calculate(list, timesdiff), Is.EqualTo(resualt), "Resualt should be 7, but is {0}", resualt);
        }
    }
}
