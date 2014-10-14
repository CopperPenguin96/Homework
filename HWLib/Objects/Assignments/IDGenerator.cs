using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class IDGenerator
    {
        public static String getRandomID(byte BaseShort)
        {
            return BaseShort + "x" + BaseShort * new Random().Next(3096);
        }
    }
    public enum Base : byte
    {
        Assignment = 1,
        Homework = 2,
        Project = 3,
        Quiz = 4,
        Test = 5,
        Final = 6
    }
}
