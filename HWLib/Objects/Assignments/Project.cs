using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Project : Assignment
    {
        #region Extension
        private String extension = ".project";
        public override string getExtension()
        {
            return extension;
        }
        #endregion

        public override int ResponseInt()
        {
            return 2;
        }
    }
}
