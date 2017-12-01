using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class AvarrangePBTestUnit
    {
            // Test af middelblodtryk 
            [Test]
            public void AverangeBP_Calculate_AverangeBPIsTwo()
            {
                var _uut = new AverageBloodPressure();
                var list = new List<double>() {50, 100, 50, 100};
                int resualt = 75;
                _uut.Calculate(list);

                Assert.That(_uut.Calculate(list), Is.EqualTo(resualt), "Resualt should be 75, but is {0}",
                    resualt);
            }
        
    }
}
