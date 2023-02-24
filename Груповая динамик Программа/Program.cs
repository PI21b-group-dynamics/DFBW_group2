using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new LoginForm().ShowDialog() == DialogResult.Cancel) return;
            //Application.Run(new LoginForm());
            Application.Run(new DeleteFile_by_WordForm());
        }
    }
}
