using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.JSON
{
    public class UserInfoReader
    {
        public static bool Exists()
        {
            if (!File.Exists(Files.JSONFiles[0]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
#region UserName
        private static String userName;
        public static String getUserName()
        {
            try
            {
                String nullCheck = userName;
            }
            catch (NullReferenceException ex)
            {
                //Read from file - userName hasn't been assigned yet
            }
            finally
            {
                //Looks like userName has been assigned, need to check if it is up-to-date
            }
            return null;
        }
        public static void setUserName(String user)
        {
            userName = user;
        }
#endregion
    }
}
