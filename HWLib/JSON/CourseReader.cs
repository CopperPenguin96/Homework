﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLib.JSON
{
    public class CourseReader
    {
        public static bool Exists()
        {
            if (!File.Exists(Files.JSONFiles[1]))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}