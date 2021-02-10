using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录3._0
{
    static class Program
    {
        public static joinin j;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(j = new joinin());
        }
    }
}
