using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDGenerator.Dependencies
{
    public class DateGeneratorProxy : IDateGeneratorProxy
    {
        public string FormatDate(DateTime dateTime)
        {
            
            string formattedDate = dateTime.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz");
            return formattedDate;
        }
    }
}
