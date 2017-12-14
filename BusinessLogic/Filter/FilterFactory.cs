using BusinessLogic.Filter;

namespace BusinessLogic
{
    public class FilterFactory
    {
        /// <summary>
        /// Creates a filter object corresponding to the supplied boolean argument
        /// </summary>
        /// <param name="button">The bool value from the button choosing filter type</param>
        /// <returns>The chosen type of filter</returns>
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
