using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic.Gem
{
    class Saving
    {
        private ISaving _iSaving;
        private FileToDatabaseTransfer _transfer;
        private IDataRemoval _remove;
        private int _sekvensNummer;

        public Saving()
        {
            _iSaving = new DatabaseSaving();
            _transfer = new FileToDatabaseTransfer();
            _remove = new ClearXmlFileContent();
            _sekvensNummer = 1;
        }

        public void SaveData(PatientDTO patient)
        {
            patient.ListOperation[0].Maaling[0].Sekvensnr = _sekvensNummer;
            _iSaving.SaveBloodPressureData(patient);

            _sekvensNummer++;
            //try
            //{
            //    if (_transfer.GetData(patient) != null)
            //    {
            //        _transfer.TransferToDatabase(patient);
            //        _remove.ClearData();
            //        _iSaving.SaveBloodPressureData(patient);
            //    }
            //    else
            //    {
            //        _iSaving.SaveBloodPressureData(patient);
            //    }
            //}
            //catch (Exception)
            //{
            //    _iSaving= new FileSaving();
            //}
        }

    }
}
