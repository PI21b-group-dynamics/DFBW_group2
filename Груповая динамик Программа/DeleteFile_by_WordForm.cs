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
            DeleteFile_by_WordForm_SizeChanged(new object(), EventArgs.Empty);
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            DeleteFilebyWorld df = new DeleteFilebyWorld();

            df.DeleteByWord(addresTextField.Text, wordTextField.Text);
        }

        private void DeleteFile_by_WordForm_SizeChanged(object sender, EventArgs e)
        {
            addresTextField.Width = this.Width - 30;
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
    }
}
