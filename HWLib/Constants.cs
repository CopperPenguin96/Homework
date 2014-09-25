using HWLib.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib
{
    public class Constants
    {
        /// <summary>
        /// The default path of the application files
        /// </summary>
        public static String pathName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "/Homework/");
        /// <summary>
        /// The directory where the Courses are installed
        /// </summary>
        public static String coursePath = pathName + "Courses/";
        public static String assignmentPath = pathName + "Assignments/";
        /// <summary>
        /// Course JSON files
        /// </summary>
        /// <returns>An Array for each Course JSON file</returns>
        public static String[] courseFiles()
        {
            UserInfo ui = new UserInfo();
            String[] returnArray = new String[ui.classCount()];
            for (int loopClasses = 1; loopClasses <= returnArray.Length; loopClasses++)
            {
                returnArray[loopClasses] = pathName + ui.userClasses()[loopClasses].name() + ".json";
            }
            return returnArray;
        }
        /// <summary>
        /// The User Info JSON File
        /// </summary>
        public static String infoJSON = pathName + "userInfo.json";
        /// <summary>
        /// Checks for the Existance of a File Or Directory
        /// </summary>
        /// <param name="fileOrDirectory">Input a File Name or a Directory Name. Needs full path</param>
        /// <returns>Either true or false on if it exists or not</returns>
        public static bool exists(String fileOrDirectory)
        {
            String finalCharacter = fileOrDirectory.Substring(fileOrDirectory.Length - 1);
            if (finalCharacter.Equals("/"))
            {
                if (Directory.Exists(fileOrDirectory))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (File.Exists(fileOrDirectory))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
