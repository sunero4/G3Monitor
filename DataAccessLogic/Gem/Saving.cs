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
        
        public Saving()
        {
            _iSaving = new DatabaseSaving();
            _transfer = new FileToDatabaseTransfer();
            _remove = new ClearXmlFileContent();
        }

        public void SaveData()
        {
            try
            {
                if (_transfer.GetData(new PatientDTO()) != null)
                {
                    _transfer.TransferToDatabase(new PatientDTO());
                    _remove.ClearData();
                    _iSaving.SaveBloodPressureData(new PatientDTO());
                }
                else
                {
                    _iSaving.SaveBloodPressureData(new PatientDTO());
                }
            }
            catch (Exception)
            {
                _iSaving= new FileSaving();
            }
        }

    }
}
