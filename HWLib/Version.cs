using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib
{
    public class Version
    {
        private static short[] releaseCode = new short[]
        {
            short.Parse(FileVersionInfo.GetVersionInfo("WWLib.dll").FileMajorPart.ToString()),
            short.Parse(FileVersionInfo.GetVersionInfo("HWLib.dll").FileMinorPart.ToString()),
            short.Parse(FileVersionInfo.GetVersionInfo("HWLib.dll").FileBuildPart.ToString()),
            short.Parse(FileVersionInfo.GetVersionInfo("HWLib.dll").FilePrivatePart.ToString())
        };
        public static String release()
        {
            return releaseCode[0] + "." + releaseCode[1] + "." + releaseCode[2] + "." + releaseCode + ".";
        }
        public static short Major()
        {
            return releaseCode[0];
        }
        public static short Minor()
        {
            return releaseCode[1];
        }
        public static short Build()
        {
            return releaseCode[2];
        }
        public static short Private()
        {
            return releaseCode[3];
        }
    }
}
