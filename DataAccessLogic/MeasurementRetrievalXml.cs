using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class MeasurementRetrievalXml : IRetrievedData<List<MaalingDTO>>
    {
        private IXmlQueryBuilder<IEnumerable<string>> _queryBuilder;

        public MeasurementRetrievalXml()
        {
            _queryBuilder = new DataRetrievalQueryBuilderXml();
        }
        public List<MaalingDTO> HentData(PatientDTO patient)
        {
            throw new NotImplementedException();
            //var dataList = _queryBuilder.BuildQuery().ToList();
            //var data = String.Join(String.Empty, dataList);


            //var maaling = new MaalingDTO()
            //{
            //    MaaleData = Convert.FromBase64String(data)
            //};

            //return maaling;
        }

        public byte[] ConvertToByteArray(string base64String)
        {
            return Convert.FromBase64String(base64String);
        }

    }
}
