using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;


namespace Interfaces
{
    public interface IBusinessLogic
    {
        bool CheckLogin(MedarbejderDTO medarbejder);


        byte[] GetSalt(MedarbejderDTO medarbejder);


        byte[] HashAndSaltPassword(string password, byte[] salt);

        NulpunktsjusteringDTO PerformAdjustment();

        PatientDTO HentData(PatientDTO patient);

        List<double> ConvertArrayToDoubles(byte[] maaledata); 

        PatientDTO GetPatientInfo(PatientDTO patient);
        void CreateFilter(bool button);

        void RunConsumer();

        void StartShowData();

        KalibreringsDTO GetCalibration();

        void StartProducer();

        void StopMeasurement();

        void GetPatientInfoForSaving(PatientDTO patient);

        double GetCalibrationPoint();

        void PerformCalibration(KalibreringsDTO calibration);
        void SaveCalibration(KalibreringsDTO calibration);
        bool CPRchecker(string cprnr);
        void GetNulpunkt(NulpunktsjusteringDTO nulpunkt);
        Monitoreringsindstillinger GetMonitoring();
        void SetMonitoring(Monitoreringsindstillinger monitoring);
        void ToggleAlarmOn(PresentationDataContainer container, Monitoreringsindstillinger monitoring);
        void ToggleAlarmOff(PresentationDataContainer container);
        PresentationDataContainer CalculateValues(List<double> bpValues);
        List<double> FilterBPValues(List<double> values, bool filterType);
    }
}
