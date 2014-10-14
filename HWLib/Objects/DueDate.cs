using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects
{
    public class DueDate
    {
        public int month;
        public int day;
        public int year;
        public String formattedString()
        {
            return formattedInt(month) + "/" +
                formattedInt(day) + "/" + year;
        }
        String formattedInt(int integer)
        {
            if (integer < 10)
            {
                return "0" + integer;
            }
            else
            {
                return "" + integer;
            }
        }
        public static DueDate parseDueDate(String fullForm)
        {
            int monthX = int.Parse(fullForm.Substring(0, 2));
            int dayX = int.Parse(fullForm.Substring(3, 5));
            int yearX = int.Parse(fullForm.Substring(6));
            DueDate returnedValue = new DueDate
            {
                day = dayX,
                month = monthX,
                year = yearX
            };
            return returnedValue;
        }
        public TestDate ToTestDate()
        {
            return new TestDate
            {
                month = this.month,
                day = this.day,
                year = this.year
            };
        }
    }
}
