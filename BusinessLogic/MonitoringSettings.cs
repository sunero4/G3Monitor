using DTO;

namespace BusinessLogic
{
    public class MonitoringSettings
    {
        private Monitoreringsindstillinger _settings;

        public void SetMonitoring(Monitoreringsindstillinger settings)
        {
            _settings = settings;
        }

        public Monitoreringsindstillinger GetMonitoring()
        {
            return _settings;
        }
    }
}
