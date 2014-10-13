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
    public class CourseReader
    {
        public static Course[] courses()
        {
            String fileText = File.ReadAllText(Files.JSONFiles[1]);
            return JsonConvert.DeserializeObject<Course[]>(fileText);
        }
    }
}
