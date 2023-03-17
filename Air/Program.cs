using System;
using System.Windows.Forms;

namespace Air
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result = new FrmLogin().ShowDialog();
            if (result == DialogResult.OK) {
                Application.Run(new FrmMain());
            }
            else {
                Application.Exit();
            }
        }
    }
}
