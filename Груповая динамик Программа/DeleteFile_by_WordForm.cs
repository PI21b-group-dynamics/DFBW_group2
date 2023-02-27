using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Груповая_динамика_Программа
{
    public partial class DeleteFile_by_WordForm : Form
    {

        public LoginForm.UserData userData;

        public DeleteFile_by_WordForm()
        {
            InitializeComponent();
        }

        private void DeleteFile_by_WordForm_Load(object sender, EventArgs e)
        {
            LogsTextField.MouseWheel += new MouseEventHandler(MouseWheelLogsTextField);

            wordTextField_Leave(new object(), new EventArgs());
            addresTextField_Leave(new object(), new EventArgs());

            LogsTextField.Select();

            folderBrowserDialog1.SelectedPath = Directory.GetCurrentDirectory();
        }

        /*----PlaceholderText---*/
        bool YesTextAddres = false, YesTextWord = false;
        String PlaceholderTextAddrestTextField = "Дирректория для поиска";
        String PlaceholderTextWordTextField = "Слово для удаления файла";

        private void sendButton_Click(object sender, EventArgs e)
        {

            if(!YesTextAddres)
            {
                MessageBox.Show("Строка адресса пустая!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            } 
            else if(!YesTextWord)
            {
                MessageBox.Show("Строка слова пустая!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            if (
                MessageBox.Show (
                "Файлы соответствующие введенному слову будут удалены.\r\n" + "Вы хотите продолжить?", 
                "Предупреждение", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning
                ) == DialogResult.No
                ) return;

            try
            {
                List<string> Logs = new DeleteFilebyWorld().DeleteByWord(addresTextField.Text, wordTextField.Text);
                sendText_in_LogsField(Logs);
                SendTextInLogsHistoryFile(Logs);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void sendText_in_LogsField(List<string> list)
        {
            String str = "";

            if (list != null && list.Count > 0)
                foreach (string item in list)
                {
                    str += item + "\r\n";
                }

            LogsTextField.Text = str;
        }

        private void SendTextInLogsHistoryFile(List<string> list)
        {
            String str = "";

            if (list != null && list.Count > 0)
                foreach (string item in list)
                {
                    str += item + "\n";
                }

            if (!Directory.Exists(@"DataUsers\Users History")) 
                Directory.CreateDirectory(@"DataUsers\Users History");

            using (StreamWriter sw = new StreamWriter(@"DataUsers\Users History\" + userData.NameUser + "_history.txt", true))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine("Произведен поиск по слову: " + wordTextField.Text + "\n");
                sw.WriteLine(str);
            }

        }

        private void createRndExampleButton_Click(object sender, EventArgs e)
        {

            if (!YesTextAddres)
            {
                MessageBox.Show("Строка адресса пустая!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }

            Example ex = new Example();


            try
            {
                String word = ex.createRndExample(addresTextField.Text);
                wordTextField_Enter(new object(), new EventArgs());
                wordTextField.Text = word;
            }
            catch (DirectoryNotFoundException exep) 
            { 
                MessageBox.Show(exep.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show
                (
                "Было создано успешно создано\n" + "Файлов: " + ex.CountFiles + "\nДиректорий: " + ex.CountDirectory, 
                "Оповещение", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Question
                );
        }

        private void MouseWheelLogsTextField(object obj, MouseEventArgs e)
        {
            if(Control.ModifierKeys == Keys.Control)
                if (e.Delta > 0)
                    LogsTextField.Font = new Font(LogsTextField.Font.Name, LogsTextField.Font.Size + 1);
                else
                    LogsTextField.Font = new Font(LogsTextField.Font.Name, LogsTextField.Font.Size - 1);
        }

        

        ///Адресс
        private void addresTextField_Enter(object sender, EventArgs e)
        {
            if (YesTextAddres) return;

            YesTextAddres = true;

            addresTextField.Text = "";

            addresTextField.ForeColor = Color.Black;
        }

        private void addresTextField_Leave(object sender, EventArgs e)
        {
            if(addresTextField.Text.Length != 0) return;

            YesTextAddres = false;

            addresTextField.Text = PlaceholderTextAddrestTextField;

            addresTextField.ForeColor = Color.Gray;
        }

        ///Слово
        private void wordTextField_Enter(object sender, EventArgs e)
        {
            if(YesTextWord) return;

            YesTextWord = true;

            wordTextField.Text = "";

            wordTextField.ForeColor = Color.Black;
        }

        private void wordTextField_Leave(object sender, EventArgs e)
        {
            if(wordTextField.Text.Length != 0) return;

            YesTextWord = false;

            wordTextField.Text = PlaceholderTextWordTextField;

            wordTextField.ForeColor = Color.Gray;
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                addresTextField_Enter(new object(), new EventArgs());
                addresTextField.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void addresTextField_DoubleClick(object sender, EventArgs e)
        {
            if (addresTextField.Text.Length == 0) return;

            Process.Start("explorer.exe", addresTextField.Text);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработанная программа-фильтр предназначена для удаления файлов, " +
                "в имени и/или содержимом которых встречается заданное слово/фраза.\r\n" +
                "В первое текстовое поле вписывается путь к директории, а во второе - ключевое слово, по " +
                "которому будет идти поиск для последующего удаления.");
        }
    }
}   
