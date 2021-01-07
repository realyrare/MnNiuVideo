using MnNiuVideoApp.Common;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace MnNiuVideo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //处理未捕获的异常
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += Application_ThreadException;
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new PlayerForm());
            }
            catch (Exception ex)
            {
                var str = "";
                var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                    ex.GetType().Name, ex.Message, ex.StackTrace);
                LogHelper.WriteLog(str);
                MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            string str = "";
            var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString(CultureInfo.InvariantCulture) + "\r\n";
            if (e.Exception is Exception error)
            {
                str = string.Format(strDateInfo + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n",
                    error.GetType().Name, error.Message, error.StackTrace);
            }
            else
            {
                str = $"应用程序线程错误:{e}";
            }
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogHelper.WriteLog(str);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            string str = "";
            var error = e.ExceptionObject as Exception;
            var strDateInfo = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            str = error != null ? string.Format(strDateInfo + "Application UnhandledException:{0};\n\r堆栈信息:{1}", error.Message, error.StackTrace) : $"Application UnhandledError:{e}";

            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LogHelper.WriteLog(str);
        }
    }
}
