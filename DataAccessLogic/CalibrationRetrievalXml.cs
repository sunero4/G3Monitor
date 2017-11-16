using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
        public KalibreringsDTO GetCalibrationData()
        {
            var result = _queryBuilder.BuildQuery();
            return result;
        }
    }
}
