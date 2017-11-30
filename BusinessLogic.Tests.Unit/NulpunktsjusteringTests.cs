using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class NulpunktsjusteringTests
    {
        private VoltageToPressureConversion _conversion;
        private Nulpunktsjustering _nulpunktsjustering;

        [SetUp]
        public void Setup()
        {
            _conversion = new VoltageToPressureConversion();
            _nulpunktsjustering = new Nulpunktsjustering();
        }

        //[Test]
        //public void VoltageToPressureConversion_Returns220mmHg()
        //{
        //    var pressure = Convert.ToInt32(_conversion.ConvertToPressure(5));
        //    Assert.That(pressure == 220);
        //}

        [Test]
        public void PerformAdjustment_Returns220mmHg()
        {
            var nulpunkt = _nulpunktsjustering.PerformAdjustment(5);
            Assert.That(Convert.ToInt32(nulpunkt.Nulpunktsjustering) == 220, "Error message: Expected value: 5, actual value: {0}", Convert.ToInt32(nulpunkt.Nulpunktsjustering));
        }
    }
}
