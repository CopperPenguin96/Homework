using HWLib.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace HWLib.JSON
{
    public class UserInfoWriter
    {
        public static void write(UserInfo ui)
        {
            String jsonText = JsonConvert.SerializeObject(ui);
            if (File.Exists(Files.JSONFiles[0]))
            {
                File.Delete(Files.JSONFiles[0]);
            }
            StreamWriter sWriter = File.CreateText(Files.JSONFiles[0]);
            sWriter.Write(jsonText);
            sWriter.Close();
        }
    }
}
