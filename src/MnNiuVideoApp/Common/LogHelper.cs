using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MnNiuVideoApp.Common
{
    public class LogHelper
    {
        public static void WriteLog(string msg)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var newFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            var logFile = Path.Combine(path, newFileName);
            using (FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write))
            {
                if (string.IsNullOrEmpty(msg)) return;
                var data = Encoding.Default.GetBytes(msg);
                fs.Write(data, 0, data.Length);
            }
        }
    }
}
