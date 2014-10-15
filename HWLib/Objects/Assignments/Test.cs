using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Test : Assignment
    {
        public override string getDateType()
        {
            return "TestDate";
        }
        public Test(String IDentify, String nameIt, DueDate duePeriod, int pointsNeeded, bool Balloony)
        {
            this.setID(IDentify);
            this.setName(nameIt);
            this.setDueDate(duePeriod);
            this.setMaxPoints(pointsNeeded);
            this.setShowBalloons(Balloony);
        }
        #region Extension
        private String extension = ".test";
        public override string getExtension()
        {
            return this.extension;
        }
        #endregion

        public override string file()
        {
            return Files.seperatepaths[ResponseInt()] + this.getName() + extension;
        }
        public override int ResponseInt()
        {
            return 4;
        }
    }
}
