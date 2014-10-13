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
    public class CourseWriter
    {
        public static void write(Course[] courses)
        {
            String jsonText = JsonConvert.SerializeObject(courses);
            if (File.Exists(Files.JSONFiles[1]))
            {
                File.Delete(Files.JSONFiles[1]);
            }
            StreamWriter sWriter = File.CreateText(Files.JSONFiles[1]);
            sWriter.Write(jsonText);
            sWriter.Close();
        }
    }
}
