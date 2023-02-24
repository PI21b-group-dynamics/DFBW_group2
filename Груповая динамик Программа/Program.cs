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

            LoginForm LF = new LoginForm();
            if (LF.ShowDialog() == DialogResult.Cancel) return;

            DeleteFile_by_WordForm dtForm = new DeleteFile_by_WordForm();
            dtForm.userData = LF.userData;

            LF.Dispose();

            Application.Run(dtForm);

            //Application.Run(new LoginForm());
        }
    }
}
