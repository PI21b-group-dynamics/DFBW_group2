using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    public partial class UserHistory : Form
    {
        LoginForm.UserData userData;
        public bool UserHasHistory { get; set; }

        public UserHistory(in LoginForm.UserData _userData)
        {
            if (!File.Exists(@"DataUsers\Users History\" + _userData.NameUser + "_history.txt"))
            {
                UserHasHistory = false;
                this.Close();
                return;
            }

            InitializeComponent();

            userData = _userData;
        }

        private void UserHistory_Load(object sender, EventArgs e)
        {
            AllLogsTextBox.MouseWheel += MouseWheelLogsTextField;

            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

            this.Select();

            this.Text = "История пользователя [" + userData.NameUser + "]";

            using (StreamReader sr = new StreamReader(@"DataUsers\Users History\" + userData.NameUser + "_history.txt", false))
            {
                String LogsUser = "";

                while (!sr.EndOfStream)
                {
                    LogsUser += sr.ReadLine() + "\r\n";
                }

                AllLogsTextBox.Text = LogsUser;
            }
        }

        private void MouseWheelLogsTextField(object obj, MouseEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                if (e.Delta > 0)
                    AllLogsTextBox.Font = new Font(AllLogsTextBox.Font.Name, AllLogsTextBox.Font.Size + 1);
                else
                {
                    if (AllLogsTextBox.Font.Size - 1 < 1) return;

                    AllLogsTextBox.Font = new Font(AllLogsTextBox.Font.Name, AllLogsTextBox.Font.Size - 1);
                }
            }
        }

        private void UserHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false)) 
                {
                    writer.WriteLine(AllLogsTextBox.Text);
                }
                MessageBox.Show("Файл успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                       Справка\r\n" +

                " Разработанная программа-фильтр предназначена для удаления файлов, " +
                "в имени и/или содержимом которых встречается заданное слово/фраза.\r\n" +
                " В первое текстовое поле вписывается путь к директории, а во второе - ключевое слово, по " +
                "которому будет идти поиск для последующего удаления.\r\n" +

                " Роли:\n" +
                "  Пользователь - управляет работой программного продукта с целью удаления файлов при фильтрации слов." +
                 "Может просмотреть список всех файлов, которые он удалил\n" +
                "  Администратор -вместе с возможностями пользователя, способен просматривать список пользователей с их данными и их списки с удаленными файлами.\n" +
                "В создании программы учавствовали: \n" +
                "  Георгий Бубнов - лидер команды.\n  Егор Панков - разработчик основного блока.\n  Влад Зосимов - тестировщик и делопроизводитель.\n" +
                "  Олег Васильченко - разработчик дополнительного блока.\n  Влад Ищенко - дизайнер интерфейса.\n" +
                "Программа для поиска и удаления файлов по ключевым словам.\n" +
                "© Все права защищены. 2023 год.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Question); ///Дописать справку
        }
    }
}
