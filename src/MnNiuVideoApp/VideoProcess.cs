using MnNiuVideoApp.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MnNiuVideoApp
{
    public class VideoProcess
    {
        private static string _ffmpegPath = string.Empty;
        static VideoProcess()
        {
            _ffmpegPath = FileHelper.LoadFfmpegPath();
        }
        /// <summary>
        /// 调用ffmpeg.exe 执行命令
        /// </summary>
        /// <param name="Parameters">命令参数</param>
        /// <returns>返回执行结果</returns>
        public static void Run(string parameters)
        {

            // 设置启动参数
            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.Verb = "runas";
            startInfo.FileName = _ffmpegPath;
            startInfo.Arguments = parameters;
#if DEBUG
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = true;
            //将输出信息重定向
            //startInfo.RedirectStandardOutput = true;
#else

            //设置不在新窗口中启动新的进程
            startInfo.CreateNoWindow = true;
            //不使用操作系统使用的shell启动进程
            startInfo.UseShellExecute = false;
#endif
            using (var proc = Process.Start(startInfo))
            {
                proc?.WaitForExit(3000);
            }
            //finally
            //{
            //    if (proc != null && !proc.HasExited)
            //    {
            //        //"即将杀掉视频录制进程,Pid:{0}", proc.Id));
            //        proc.Kill();
            //        proc.Dispose();
            //    }
            //}
        }
    }
}
