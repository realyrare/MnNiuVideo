using MnNiuVideoApp.Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace MnNiuVideoApp
{
    public class NginxProcess
    {
        //nginx的进程名
        public string _nginxFileName = "nginx";
        public string _stop = "stop.bat";
        public string _start = "start.bat";
        //nginx的文件路径名
        public string _nginxFilePath = string.Empty;
        //nginx的启动参数
        public string _arguments = string.Empty;
        //nginx的工作目录
        public string _workingDirectory = string.Empty;
        public int _processId = 0;
        public NginxProcess()
        {
            string basePath = FileHelper.LoadNginxPath();
            string nginxPath = $@"{basePath}\nginx.exe";
            _nginxFilePath = Path.GetFullPath(nginxPath);
            _workingDirectory = Path.GetDirectoryName(_nginxFilePath);
            _arguments = @" -c \conf\nginx-win.conf";
        }
        //关掉所有nginx的进程,格式必须这样，有空格存在  taskkill /IM  nginx.exe  /F



        /// <summary>
        /// 启动服务
        /// </summary>
        /// <returns></returns>
        public void StartService()
        {
            try
            {
                if (ProcessesHelper.IsCheckProcesses(_nginxFileName))
                {
                    LogHelper.WriteLog("nginx进程已经启动过了");
                }
                else
                {
                    var sinfo = new ProcessStartInfo
                    {
                        FileName = _nginxFilePath,
                        Verb = "runas",
                        WorkingDirectory = _workingDirectory,
                        Arguments = _arguments
                    };
#if DEBUG
                    sinfo.UseShellExecute = true;
                    sinfo.CreateNoWindow = false;
#else
                sinfo.UseShellExecute = false;
#endif
                    using (var process = Process.Start(sinfo))
                    {
                        //process?.WaitForExit();
                        _processId = process.Id;
                    }
                }
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(e.Message);
                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// 关闭nginx所有进程
        /// </summary>
        /// <returns></returns>
        public void StopService()
        {
            var flag = ProcessesHelper.KillProcesses(_nginxFileName);
            if (!flag)
            {
                LogHelper.WriteLog("nginx关闭失败");
            }
            LogHelper.WriteLog("nginx关闭成功");
        }



        /// <summary>
        /// 需要以管理员身份调用才能起作用
        /// </summary>
        public void KillAll()
        {
            try
            {
                ProcessStartInfo sinfo = new ProcessStartInfo();
#if DEBUG
                sinfo.UseShellExecute = true;
                // sinfo.CreateNoWindow = true;
#else
                sinfo.UseShellExecute = false;
#endif
                sinfo.FileName = _nginxFilePath;
                sinfo.Verb = "runas";
                sinfo.WorkingDirectory = _workingDirectory;
                sinfo.Arguments = $@"{_workingDirectory}\taskkill /IM  nginx.exe  /F ";
                using (Process _process = Process.Start(sinfo))
                {
                    _processId = _process.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
