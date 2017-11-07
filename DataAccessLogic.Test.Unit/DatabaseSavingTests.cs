using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DataAccessLogic.Test.Unit
{
    class DatabaseSavingTests
    {
        private IQueryBuilder _queryBuilder;
        private ICommandBuilder _commandBuilder;

        [SetUp]
        public void Setup()
        {
            _queryBuilder = new SaveQueryBuilder() {ColumnNames = new List<string>() {"Column1", "Column2", "Column3"}};
            _commandBuilder = new SaveCommandBuilder();
        }


        public void SaveBloodPressureData_QueryAndCommandBuilt_CommandIsCorrect()
        {
            
        }


    }
}
