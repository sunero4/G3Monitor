using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    class AvarrangePBTestUnit
    {
        [TestFixture]
        class DiastolicTestUnit
        {
            // Test af middelblodtryk 
            [Test]
            public void AverangeBP_Calculate_AverangeBPIsTwo()
            {
                var _uut = new Diastolic();
                var list = new List<double>() { 50, 100, , 7, 2 };
                int timesdiff = 2;
                int resualt = 2;
                _uut.Calculate(list, timesdiff);

                Assert.That(_uut.Calculate(list, timesdiff), Is.EqualTo(resualt), "Resualt should be 2, but is {0}", resualt);
            }

        }
    }
