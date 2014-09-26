using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.User
{
    public class UserInfo
    {
        public String getUserName()
        {
            //Read from JSON
            return null;
        }

        public short getAge()
        {
            //Read from JSON
            return 0;
        }

        public short getClassCount()
        {
            //Read from JSON
            return 0;
        }

        public Class[] getUserClasses()
        {
            Class[] returnValue = new Class[getClassCount()];
            //Read from JSON
            return returnValue;
        }
    }
}
