using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class RetrivedQueryBuilder: IQueryBuilderMedarbejder 
    {
        private StringBuilder _builder;
        public string Tablename { get; set; }
        public List<string> ColumnNames { get; set; }

        public RetrivedQueryBuilder()
        {
            ColumnNames = new List<string>() { "Brugernavn", "HashedPassword", "Salt" };
        }

            public string BuildQuery(MedarbejderDTO medarbejder)
        {
       
            _builder = new StringBuilder();
            _builder.Append("select * from Tabelname = ' " + Tablename + "'"); 
            return _builder.ToString();
        }

    }
}
