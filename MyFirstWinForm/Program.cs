using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //想想看也建議可以操作看看，跟這樣寫有什麼差別呢 ?^^ a
            //var f = new Form1();
            //f.Show();
            //Application.Run();
        }
    }
}
