using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            DeleteFilebyWorld df = new DeleteFilebyWorld();

            sendText_in_LogsField(df.DeleteByWord(addresTextField.Text, wordTextField.Text));
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

        String PlaceholderTextAddrestTextField = "Дирректория для поиска";

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

        private void createRndExampleButton_Click(object sender, EventArgs e)
        {
            Example ex = new Example();
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

    }
}
