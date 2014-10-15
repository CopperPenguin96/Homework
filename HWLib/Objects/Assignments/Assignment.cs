using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Assignment
    {
        public Assignment()
        {
            //Nothing - just nothing!
        }
        public Assignment(String IDentify, String nameIt, DueDate duePeriod, int pointsNeeded, bool Balloony)
        {
            this.setID(IDentify);
            this.setName(nameIt);
            this.setDueDate(duePeriod);
            this.setMaxPoints(pointsNeeded);
            this.setShowBalloons(Balloony);
        }
        #region ID
        private String ID;
        public virtual String getID()
        {
            return ID;
        }
        public virtual void setID(String IDE)
        {
            ID = IDE;
        }
        #endregion

        #region FileExtension
        private String extension = ".assi";
        public virtual String getExtension()
        {
            return extension;
        }
        #endregion

        #region name
        private String name;
        public virtual String getName()
        {
            return name;
        }
        public virtual void setName(String n)
        {
            name = n;
        }
        #endregion

        #region DueDate
        private DueDate dueDate;
        public virtual DueDate getDueDate()
        {
            return dueDate;
        }
        public virtual void setDueDate(DueDate dd)
        {
            dueDate = dd;
        }
        #endregion

        #region MaxPoints
        private int maxPoints;
        public virtual int getMaxPoints()
        {
            return maxPoints;
        }
        public virtual void setMaxPoints(int i)
        {
            maxPoints = i;
        }
        #endregion

        #region Balloons
        private bool showBalloons;
        public virtual bool getShowBalloons()
        {
            return showBalloons;
        }
        public virtual void setShowBalloons(bool b)
        {
            showBalloons = b;
        }
        #endregion

        #region file()
        public virtual int ResponseInt()
        {
            return 0;
        }
        public virtual String file()
        {
            return Files.seperatepaths[ResponseInt()] + name + extension;
        }
        public virtual void loadFromFile(String identification)
        {
            foreach (String fileX in Directory.GetFiles(Files.seperatepaths[ResponseInt()]))
            {
                String[] text = File.ReadAllLines(fileX);
                foreach (String textItems in text)
                {
                    if (textItems.Contains("ID: "))
                    {
                        if (textItems.Substring(4).Equals(ID))
                        {
                            //Found a matching assignment
                            continueLoad(text);
                            break; //Stops from further loops... better speed and prevents duplicates
                        }
                    }
                }
            }
        }
        public virtual void continueLoad(String[] text)
        {
            this.ID = text[0].Substring(4);
            this.name = text[1].Substring(6);
            this.dueDate = DueDate.parseDueDate(text[2].Substring(9));
            this.maxPoints = int.Parse(text[3].Substring(11));
            this.showBalloons = bool.Parse(text[4].Substring(14));
        }
        #endregion

        #region Saving
        public virtual String getDateType()
        {
            return "DueDate";
        }
        public virtual void Save()
        {
            String fileDork = file();
            if (File.Exists(fileDork))
            {
                File.Delete(fileDork);
            }
            String[] textArray = new String[]
            {
                "ID: " + getID(),
                "Name: " + getName(),
                getDateType() + ": " + getDueDate().ToString(),
                "MaxPoints: " + getMaxPoints(),
                "Balloon: " + getShowBalloons()
            };
            StreamWriter sWriter = File.CreateText(fileDork);
            foreach (String lines in textArray)
            {
                sWriter.WriteLine(lines);
            }
            sWriter.Close();
        }
        #endregion
    }
}
