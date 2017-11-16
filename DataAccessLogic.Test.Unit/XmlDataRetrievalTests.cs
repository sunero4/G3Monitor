using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DataAccessLogic.Test.Unit
{
    [TestFixture]
    class XmlDataRetrievalTests
    {
        private MeasurementRetrievalXml _measurementRetrieval;
        private string _baseSingleInput;
        private string _baseCombinedInput;
        private byte[] _input1;
        private byte[] _input2;
        [SetUp]
        public void Setup()
        {
            _input1 = new byte[5] {42, 75, 23, 4, 123};
            _input2 = new byte[5] {32, 67, 98, 124, 9};
            _baseSingleInput = Convert.ToBase64String(_input1);
            _baseCombinedInput = String.Concat(Convert.ToBase64String(_input1), Convert.ToBase64String(_input2));
            _measurementRetrieval = new MeasurementRetrievalXml();
        }

        [Test]
        public void MeasurementRetrieval_ConvertFromBase64OneInput_OutputMatchesExpected()
        {
            var output = Convert.FromBase64String(_baseSingleInput);
            Assert.That(output.SequenceEqual(_measurementRetrieval.ConvertToByteArray(_baseSingleInput)));
        }

    }
}
