using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    class SCDataAcess: IDataAccess

    {
        private LoginData _loginData;
        private Salt _salt;
        private IDaqMeasurement _daqMeasurement;

        public SCDataAcess()
        {
            retrivedData = new RetrivedData();
            salt = new Salt();
            _loginData = new LoginData();
            _salt = new Salt();
        }

        public MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder)
        {
            return retrivedData.CheckLogin(medarbejder);
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return _salt.GetSalt(medarbejder); 
        }

        public double GetVoltage()
        {
            var daq = new DAQ();
            _daqMeasurement = new DaqMeasurementNulpunkt(daq.GetDaq());
            return _daqMeasurement.GetVoltage();
        }
    }

}

