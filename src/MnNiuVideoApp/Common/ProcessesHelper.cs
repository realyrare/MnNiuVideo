using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MnNiuVideoApp.Common
{
    public class ProcessesHelper
    {
        /// <summary>检测进程是否存在</summary>
        /// <param name="processesName">进程名</param>
        /// <returns>返回bool类型结果</returns>
        public static bool IsCheckProcesses(int processesId)
        {
            bool flag = false;
            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id == processesId)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        /// <summary>根据进程ID返回进程信息</summary>
        /// <param name="processesId"></param>
        /// <returns></returns>
        public static Process GetProcessesInfo(int processesId)
        {
            Process process1 = null;
            foreach (Process process2 in Process.GetProcesses())
            {
                if (process2.Id == processesId)
                {
                    process1 = process2;
                    break;
                }
            }
            return process1;
        }

        /// <summary>检测进程是否存在</summary>
        /// <param name="processesName">进程名</param>
        /// <returns>返回bool类型结果</returns>
        public static bool IsCheckProcesses(string processesName)
        {
            bool flag = false;
            foreach (Process process in Process.GetProcesses())
            {
                if (string.Equals(process.ProcessName, Path.GetFileNameWithoutExtension(processesName), StringComparison.CurrentCultureIgnoreCase))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        /// <summary>结束进程</summary>
        /// <param name="processesId">进程ID</param>
        /// <returns>返回bool类型结果</returns>
        public static void KillProcesses(int processesId)
        {          
            foreach (Process process in Process.GetProcesses())
            {
                if (process.Id == processesId)
                {
                    process.Kill();                  
                    break;
                }
            }         
        }

        /// <summary>结束进程</summary>
        /// <param name="processesName">进程名</param>
        /// <returns>返回bool类型结果</returns>
        public static void KillProcesses(string processesName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToUpper() == Path.GetFileNameWithoutExtension(processesName).ToUpper())
                    process.Kill();
            }
        }
    }
}
