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

namespace Груповая_динамика_Программа
{
    public partial class DeleteFile_by_WordForm : Form
    {
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
        }
        /*----PlaceholderText---*/

        String PlaceholderTextAddrestTextField = "Дирректория для поиска";
        String PlaceholderTextWordTextField = "Слово для удаления файла";

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Файлы соответствующие введенному \r\nслову будут удалены. " +
                "\r\nВы хотите продолжить?", "Уведомление", MessageBoxButtons.YesNo) == DialogResult.No) return;

            sendText_in_LogsField(new DeleteFilebyWorld().DeleteByWord(addresTextField.Text, wordTextField.Text));
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

        private void createRndExampleButton_Click(object sender, EventArgs e)
        {
            Example ex = new Example();

            wordTextField_Enter(new object(), new EventArgs());
            wordTextField.Text = ex.createRndExample(addresTextField.Text);

            MessageBox.Show("Было создано успешно создано " + ex.getCountFiles() + " тестовых файлов");
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
            if (addresTextField.Text.Length != 0 && !addresTextField.Text.Equals(PlaceholderTextAddrestTextField)) return;

            addresTextField.Text = "";

            addresTextField.ForeColor = Color.Black;
        }

        private void addresTextField_Leave(object sender, EventArgs e)
        {
            if (addresTextField.Text.Length != 0) return;

            addresTextField.Text = PlaceholderTextAddrestTextField;

            addresTextField.ForeColor = Color.Gray;
        }

        ///Слово
        private void wordTextField_Enter(object sender, EventArgs e)
        {
            if (wordTextField.Text.Length != 0 && !wordTextField.Text.Equals(PlaceholderTextWordTextField)) return;

            wordTextField.Text = "";

            wordTextField.ForeColor = Color.Black;
        }

        private void wordTextField_Leave(object sender, EventArgs e)
        {
            if (wordTextField.Text.Length != 0) return;

            wordTextField.Text = PlaceholderTextWordTextField;

            wordTextField.ForeColor = Color.Gray;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработанная программы-фильтр, предназначена для удаления файлов, в имени и/или содержимом которых встречается заданное слово/фраза\r\nВ первое текстовое поле вписывается адрес а во второе ключевое слово по которому будет идти поиск для последующего удаления.");
        }

        private void chooseFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                addresTextField_Enter(new object(), new EventArgs());
                addresTextField.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработанная программы-фильтр, предназначена для удаления файлов, " +
                "в имени и/или содержимом которых встречается заданное слово/фраза\r\n" +
                "В первое текстовое поле вписывается адрес а во второе ключевое слово по " +
                "которому будет идти поиск для последующего удаления.");
        }
    }
}   
