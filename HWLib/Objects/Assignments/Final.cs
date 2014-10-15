using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Final : Assignment
    {
        public override string getDateType()
        {
            return "TestDate";
        }
        public Final(String IDentify, String nameIt, DueDate duePeriod, int pointsNeeded, bool Balloony)
        {
            this.setID(IDentify);
            this.setName(nameIt);
            this.setDueDate(duePeriod);
            this.setMaxPoints(pointsNeeded);
            this.setShowBalloons(Balloony);
        }
        #region Extension
        private String extension = ".final";
        public override string getExtension()
        {
            return this.extension;
        }
        #endregion

        public override int ResponseInt()
        {
            return 5;
        }

        public override string file()
        {
            return Files.seperatepaths[ResponseInt()] + this.getName() + extension;
        }
    }
}
