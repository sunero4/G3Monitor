using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class PulsTestUnit
    {
        [Test]
        public void TwoTops_Times_TimesTrue()
        {
            var _uut = new Pulse();
            var list = new List<double>() {3,2,7,9,7,10,7,6}; // Toppunkterne er 9 og 10, da thredsholdlisten er list.Max*0.8 
            var resualt = new List<int>() {3,5}; // Dette er pladserne 9 og 10 er på 
            _uut.Times(list);
           
            Assert.That(_uut.Times(list), Is.EqualTo(resualt), "List count should be 2, but is {0}", resualt.Count);
        }
        [Test]  
        public void Avarage_TimesDifferent_TimesDifferentTrue()
        {
            var _uut = new Pulse();
            var list = new List<double>() { 3, 5,9, 6, 7, 10 };
            int resualt = 2;

            Assert.That(_uut.TimeDifferences(list), Is.EqualTo(resualt), "List count should be 2, but is {0}", resualt);
        }
    }
}
