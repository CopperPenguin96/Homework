﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.JSON
{
    public class Files
    {
        public static String filePath = "JSON/";
        public static String[] JSONFiles = new String[] 
        {
            filePath + "userInfo.json",
            filePath + "courses.json",
            filePath + "systemInfo.json"
        };
    }
}
