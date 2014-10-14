using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.Objects.Assignments
{
    public class Files
    {
        public static String AssignmentPath = "/Assignments/";
        public static String[] seperatepaths = new String[]
        {
            AssignmentPath + "Assignments/",
            AssignmentPath + "Homework/",
            AssignmentPath + "Project/",
            AssignmentPath + "Quiz/",
            AssignmentPath + "Test/",
            AssignmentPath + "Final/"
        };
        public static void createDirectoriesIfNeeded()
        {
            foreach (String paths in seperatepaths)
            {
                if (!Directory.Exists(paths))
                {
                    Directory.CreateDirectory(paths);
                }
            }
        }
    }
}
