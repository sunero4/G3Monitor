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

        /// <summary>
        /// Builds an Sql SELECT query from a predefined list of columnnames and property names on the medarbejder dto
        /// object
        /// </summary>
        /// <param name="medarbejder">medarbejder dto object with properties to be used for naming parameters</param>
        /// <returns>SQL Select from query</returns>
        public string BuildQuery(MedarbejderDTO medarbejder, string tableName)
        {
            Tablename = tableName;
            _builder = new StringBuilder();
            _builder.Append("select * from " + Tablename + " where Brugernavn = @brugernavn"); 
            return _builder.ToString();
        }

    }
}
