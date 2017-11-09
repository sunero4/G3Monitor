using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public static class ConnectionInfo
    {
        private const string DBLocal = "F17ST2ITS2201608531";
        public static string Connectionstring = "Data Source=i4dab.ase.au.dk;Initial Catalog=" + DBLocal + ";Persist Security Info=True;User ID=" + DBLocal + ";Password=" + DBLocal + "";


    }
}
