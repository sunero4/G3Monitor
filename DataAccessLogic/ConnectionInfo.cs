using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    static class ConnectionInfo
    {
        public static string Connectionstring = "";

        public static string SaveBloodPressureQuery =
                "INSERT INTO Maaling (CPR, Måledata, Kommentar, Maaletidspunkt) VALUES (@cpr, @maaledata, @kommentar, @tidspunkt)"
            ;

    }
}
