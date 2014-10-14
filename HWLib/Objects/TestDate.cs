using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects
{
    public class TestDate : DueDate
    {
        public static DueDate parseDueDate(string fullForm)
        {
            throw new NullReferenceException();
        }

        public static TestDate parseTestDate(string fullForm)
        {
            int dayX = int.Parse(fullForm.Substring(0, 2));
            int monthX = int.Parse(fullForm.Substring(3, 5));
            int yearX = int.Parse(fullForm.Substring(6));
            DueDate returnedValue = new DueDate
            {
                day = dayX,
                month = monthX,
                year = yearX
            };
            return returnedValue.ToTestDate();
        }

        public DueDate ToDueDate()
        {
            return new DueDate
            {
                month = this.month,
                day = this.day,
                year = this.year
            };
        }
    }
}
