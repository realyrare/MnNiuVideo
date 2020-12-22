using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MnNiuVideoApp.Common
{
    public class FileHelper
    {

        public static string BaseRead()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LibConfig");
            if (!Directory.Exists(path))
            {
                throw new ArgumentException("LibConfig配置文件目录不存在");
            }
            return path;
        }

        public static string LoadFfmpegPath()
        {
            var path = BaseRead();
            var ffmpegPath = $@"{path}\ffmpeg\bin\ffmpeg.exe";
            if (string.IsNullOrEmpty(ffmpegPath))
            {
                throw new ArgumentException("ffmpegPath路径为空");
            }
            return ffmpegPath;
        }
        public static string LoadNginxPath()
        {
            var path = BaseRead();
            var nginxPath = $@"{path}\nginx";
            if (string.IsNullOrEmpty(nginxPath))
            {
                throw new ArgumentException("nginxPath路径为空");
            }
            return nginxPath;
        }

        public static string VideoRecordPath()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "video");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            var newFileName = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ms") + ".mp4";
            var logFile = Path.Combine(path.ToLower(), newFileName.Trim().Replace(":", "-").Replace(" ", "-"));
            return logFile;
        }

        public static string GetLoadPath()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Icon");
            return Path.Combine(path + "\\", "timg.gif");

        }
    }
}
