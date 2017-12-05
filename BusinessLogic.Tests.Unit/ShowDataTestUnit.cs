﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace BusinessLogic.Tests.Unit
{
    [TestFixture]
    class ShowDataTestUnit
    {
        private IFilter _iFilter;
        private IPulse _pulse;
        private ICalculateSysDia _sysDia;
        private IAverangePB _averange;
        private ShowData _uut;


        [SetUp]
        public void Setup()
        {
            _iFilter = Substitute.For<IFilter>();
            _pulse = Substitute.For<IPulse>();
            _sysDia = Substitute.For<ICalculateSysDia>();
            _averange = Substitute.For<IAverangePB>(); 
           var _uut = new ShowData();
        }


        [Test]
        public void ShowDataCallClasses_HandleOneData_ClassIsCalled()
        {
            _uut.HandleData();
        }

    }
}