using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace HWLib
{
    public class Font
    {
        [DllImport("gdi32.dll", EntryPoint="AddFontResourceW", SetLastError=true)]
        public static extern int AddFontResource([In][MarshalAs(UnmanagedType.LPWStr)]
                                         string lpFileName);
        static String Cap1 = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/capture_it.ttf";
        static String Cap2 = "http://homeworkcalendar.weebly.com/uploads/3/8/7/5/38754049/capture_it_2.ttf";
        public static void downloadFontIfNeeded()
        {
            InstalledFontCollection fontsCollection = new InstalledFontCollection();
            FontFamily[] fontFamilies = fontsCollection.Families;
            List<string> fonts = new List<string>();
            bool[] wasFoundinSystem = {false, false};
            foreach (FontFamily font in fontFamilies)
            {
                if (font.Name.Equals("Capture It")) wasFoundinSystem[0] = true;
                else if (font.Name.Equals("Capture It 2")) wasFoundinSystem[1] = true;
            }
            if (!wasFoundinSystem[0])
            {
                //Install the font.
                int result = AddFontResource(Cap1);
                int error = Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    Console.WriteLine(new Win32Exception(error).Message);
                }
                else
                {
                    Console.WriteLine((result == 0) ? "Font is already installed." :
                                                      "Font installed successfully.");
                }
            }
            if (!wasFoundinSystem[1])
            {
                int result = AddFontResource(Cap2);
                int error = Marshal.GetLastWin32Error();
                if (error != 0)
                {
                    Console.WriteLine(new Win32Exception(error).Message);
                }
                else
                {
                    Console.WriteLine((result == 0) ? "Font is already installed." :
                                                      "Font installed successfully.");
                }
            }
        }
    }
}
