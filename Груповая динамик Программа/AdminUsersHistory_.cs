using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Груповая_динамика_Программа.LoginForm;
using System.Xml.Serialization;

namespace Груповая_динамика_Программа
{
    public partial class AdminUsersHistory_ : Form
    {
        private List<LoginForm.UserData> All_UsersData = new List<LoginForm.UserData>();

        public bool CorrectData { get; set; } = true;

        public AdminUsersHistory_()
        {

            if (File.Exists(@"DataUsers\Users.xml"))
            {
                using (var fs = new FileStream(@"DataUsers\Users.xml", FileMode.Open))
                {
                    try
                    {
                        All_UsersData = new XmlSerializer(typeof(List<UserData>)).Deserialize(fs) as List<UserData>;
                    }
                    catch (System.InvalidOperationException)
                    {
                        CorrectData = false;
                        this.Close();
                        return;
                    }
                }
            }

            if (All_UsersData == null)
            {
                CorrectData = false;
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void AdminUsersHistory_Load(object sender, EventArgs e)
        {
            AllLogsTextBox.MouseWheel += MouseWheelLogsTextField;

            for(int i = 0; i < All_UsersData.Count; ++i)
            {
                dataGridView1.Rows.Add(i + 1, All_UsersData[i].NameUser, All_UsersData[i].PasswordUser);
                dataGridView1.Rows[i].Cells["IDUser"].Style.BackColor = Color.Gray;
            }
        }

        DataGridViewRow PrewRow;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(PrewRow != null)
            {
                for (int i = 1; i < PrewRow.Cells.Count; ++i)
                {
                    PrewRow.Cells[i].Style.BackColor = Color.White;
                }
            }

            try
            {
                for (int i = 1; i < dataGridView1.Rows[e.RowIndex].Cells.Count; ++i)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.LightGreen;
                }
            } catch(System.ArgumentOutOfRangeException)
            {
                return;
            }

            PrewRow = dataGridView1.Rows[e.RowIndex];

            if (!File.Exists(@"DataUsers\Users History\" + dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString() + "_history.txt"))
            {
                AllLogsTextBox.Text = "Файла с историей не существует!";
                return;
            }

            using (StreamReader sr = new StreamReader(@"DataUsers\Users History\" + dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString() + "_history.txt", false))
            {
                String LogsUser = "";

                while (!sr.EndOfStream)
                {
                    LogsUser += sr.ReadLine() + "\r\n";
                }

                AllLogsTextBox.Text = LogsUser;
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            открытьВНовомОкнеToolStripMenuItem_Click(new object(), new EventArgs());
        }

        private void открытьВНовомОкнеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PrewRow == null) 
            {
                MessageBox.Show("Что-бы открыть данные пользователя в новом окне, вам необходимо выбрать пользователя!", "Уведомление", 
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            UserHistory userHistory = new UserHistory(new UserData(PrewRow.Cells["Name"].Value.ToString(), null, false));

            if (userHistory.IsDisposed == true)
            {
                MessageBox.Show("У данного пользователя отсутствует история!", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Question);
                userHistory.Dispose();
                return;
            }
            else
                userHistory.Show();
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    writer.WriteLine(AllLogsTextBox.Text);
                }
                MessageBox.Show("Файл успешно сохранен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void сохранитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false))
                {

                    for(int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {

                        writer.WriteLine("Данные пользователя: " + dataGridView1.Rows[i].Cells["Name"].Value.ToString());

                        if (!File.Exists(@"DataUsers\Users History\" + dataGridView1.Rows[i].Cells["Name"].Value.ToString() + "_history.txt"))
                        {
                            writer.WriteLine("У пользователя " + dataGridView1.Rows[i].Cells["Name"].Value.ToString() + "отсутсвует история!\n");
                            continue;
                        }

                        using (StreamReader sr = new StreamReader(@"DataUsers\Users History\" + dataGridView1.Rows[i].Cells["Name"].Value.ToString() + "_history.txt", false))
                        {
                            while (!sr.EndOfStream)
                            {
                                writer.WriteLine(sr.ReadLine() + "\n");
                            }
                        }

                    }
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
                "© Все права защищены. 2023 год.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information); ///Дописать справку
        }
    }
}
