using DTO;

namespace DataAccessLogic
{
    class CalibrationRetrievalXml : ICalibrationDataRetrieval
    {
        private readonly IXmlQueryBuilder<KalibreringsDTO> _queryBuilder;

        public CalibrationRetrievalXml()
        {
            _queryBuilder = new CalibrationQueryBuilderXml();
        }
        /// <summary>
        /// Retrieves calibration data
        /// </summary>
        /// <returns>DTO holding the retrieved calibration data</returns>
        public KalibreringsDTO GetCalibrationData()
        {
            var result = _queryBuilder.BuildQuery();
            return result;
        }
    }
}
