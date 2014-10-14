using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Final : Assignment
    {
        #region Extension
        private String extension = ".final";
        public override string getExtension()
        {
            return extension;
        }
        #endregion

        public override int ResponseInt()
        {
            return 5;
        }
    }
}
