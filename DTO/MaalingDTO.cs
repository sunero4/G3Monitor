using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaalingDTO
    {
        private string _kommentar;

        public int MaaleID { get; set; }

        public byte[] MaaleData { get; set; }

        public string Kommentar
        {
            get => _kommentar;
            set
            {
                if (value.Length <= 500)
                {
                    _kommentar = value;
                }
            }
        }

        public DateTime MaaleTidspunkt { get; set; }

    }
}
