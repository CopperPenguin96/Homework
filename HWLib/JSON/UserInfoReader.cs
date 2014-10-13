using HWLib.Objects;
using Newtonsoft.Json;
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
        public static UserInfo uInfo()
        {
            String fileText = File.ReadAllText(Files.JSONFiles[0]);
            return JsonConvert.DeserializeObject<UserInfo>(fileText);
        }
    }
}
