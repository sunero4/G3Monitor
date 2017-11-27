using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Filter;
using DTO;
using ObserverPattern;

namespace BusinessLogic
{
    public class FilterFactory
    {
        // hvordan kommer det fra formen, er det også en string eller er det en bool
        public static IFilter CreateFilter(bool button)
        {
            if (button)
            {
                IFilter filter = new FilterBP();
                return filter;
            }       
                IFilter andetFilter = new RawFilter();
                return andetFilter;
        }

    }
    
}
