using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Quiz : Assignment
    {
        #region Extension
        private String extension = ".quiz";
        public override string getExtension()
        {
            return extension;
        }
        #endregion

        public override int ResponseInt()
        {
            return 3;
        }
    }
}
