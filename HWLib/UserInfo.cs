using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib
{
    class UserInfo
    {
        public String userName()
        {
            //Read from JSON
            return null;
        }

        public short age()
        {
            //Read from JSON
            return 0;
        }

        public short classCount()
        {
            //Read from JSON
            return 0;
        }

        public Class[] userClasses()
        {
            Class[] returnValue = new Class[classCount()];
            //Read from JSON
            return returnValue;
        }
    }
}
