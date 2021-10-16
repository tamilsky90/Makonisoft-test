using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Makonisoft.Common
{
    public static class FileHelper
    {
        public static void SaveText(string path, string filename, string content)
        {
            if (!System.IO.Directory.Exists(path))
                System.IO.Directory.CreateDirectory(path);
            string filepath = path + filename;
            System.IO.File.WriteAllText(filepath, content);
        }       

    }
}