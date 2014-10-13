using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JCS;
using System.IO;
using Newtonsoft.Json;
namespace HWLib.JSON
{
    public class SIObj
    {
        public String name;
        public String servicePack;
        public String edition;
        public String versionString;
        public String processorBits;
        public String OSBits;
        public String ProgramBits;
    }
    public class SystemInfo
    {
        public static void write()
        {
            if (File.Exists(Files.JSONFiles[2]))
            {
                File.Delete(Files.JSONFiles[2]);
            }
            SIObj siobj = new SIObj
            {
                name = OS_Information()[0],
                servicePack = OS_Information()[2],
                edition = OS_Information()[1],
                versionString = OS_Information()[3],
                processorBits = OS_Information()[4],
                OSBits = OS_Information()[5],
                ProgramBits = OS_Information()[6]
            };
            string json = JsonConvert.SerializeObject(siobj, Formatting.Indented);
            File.WriteAllText(Files.JSONFiles[2], json);
        }
        public static String[] OS_Information()
        {
            String spItem;
            if (OSVersionInfo.ServicePack != string.Empty)
            {
                spItem = String.Format("Service Pack = {0}", OSVersionInfo.ServicePack);
            }
            else
            {
                spItem = "Service Pack = None";
            }
            return new String[] {
                String.Format("Name = {0}", OSVersionInfo.Name),
                String.Format("Edition = {0}", OSVersionInfo.Edition),
                spItem,
                String.Format("Version = {0}", OSVersionInfo.VersionString),
                String.Format("ProcessorBits = {0}", OSVersionInfo.ProcessorBits),
                String.Format("OSBits = {0}", OSVersionInfo.OSBits),
                String.Format("ProgramBits = {0}", OSVersionInfo.ProgramBits)
            };
        }
    }
}
