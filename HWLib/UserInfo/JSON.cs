using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HWLib
{
    public class JSON
    {
        /// <summary>
        /// Writes all the JSON files based on the User's classes
        /// </summary>
        /// <param name="classes">UserInfo.userClasses()</param>
        public static void writeClassesJSON(Class[] classes)
        {
            String[] allJSONStrings = new String[classes.Length];
            int loopCount = 1;
            foreach (Class cc in classes)
            {
                String jsonString = JsonConvert.SerializeObject(cc);
                allJSONStrings[loopCount] = jsonString;
                loopCount++;
            }
            loopCount = 1;
            foreach (String arrayJSON in allJSONStrings)
            {
                File.WriteAllText(Constants.courseFiles()[loopCount], arrayJSON);
                loopCount++;
            }
        }
        /// <summary>
        /// Writes to the User Info JSON File
        /// </summary>
        /// <param name="ui">UserInfo object</param>
        public static void writeUserInfoJson(UserInfo ui)
        {
            String userInfoJSON = JsonConvert.SerializeObject(ui);
            File.WriteAllText(Constants.infoJSON, userInfoJSON);
        }
    }
}
