using MT.Core.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT.Core.GUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


            Application.Run(new frmGUI());
        }


        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (null != ex)
            {
                CoreGUIManager.Instance.Fatal(string.Format("(Core.GUI) CurrentDomain_UnhandledException:{0}", ex.StackTrace));
            }
            else
            {
                CoreGUIManager.Instance.Fatal(string.Format("(Core.GUI) CurrentDomain_UnhandledException:{0}", e.ExceptionObject));
            }
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            CoreGUIManager.Instance.Fatal(string.Format("(Core.GUI) Application_ThreadException:{0}", e.Exception.StackTrace));
        }
    }
}
