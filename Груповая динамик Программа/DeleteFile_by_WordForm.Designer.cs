namespace Груповая_динамика_Программа
{
    partial class DeleteFile_by_WordForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteFile_by_WordForm));
            this.addresTextField = new System.Windows.Forms.TextBox();
            this.wordTextField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.createRndExampleButton = new System.Windows.Forms.Button();
            this.LogsTextField = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.установитьДиректориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addresTextField
            // 
            this.addresTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresTextField.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addresTextField.Location = new System.Drawing.Point(12, 30);
            this.addresTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addresTextField.Name = "addresTextField";
            this.addresTextField.Size = new System.Drawing.Size(1010, 27);
            this.addresTextField.TabIndex = 0;
            this.addresTextField.Enter += new System.EventHandler(this.addresTextField_Enter);
            this.addresTextField.Leave += new System.EventHandler(this.addresTextField_Leave);
            // 
            // wordTextField
            // 
            this.wordTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordTextField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordTextField.Location = new System.Drawing.Point(12, 64);
            this.wordTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordTextField.Name = "wordTextField";
            this.wordTextField.Size = new System.Drawing.Size(483, 30);
            this.wordTextField.TabIndex = 1;
            this.wordTextField.Enter += new System.EventHandler(this.wordTextField_Enter);
            this.wordTextField.Leave += new System.EventHandler(this.wordTextField_Leave);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(501, 64);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(170, 30);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Найти и удалить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // createRndExampleButton
            // 
            this.createRndExampleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createRndExampleButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRndExampleButton.Location = new System.Drawing.Point(801, 63);
            this.createRndExampleButton.Margin = new System.Windows.Forms.Padding(4);
            this.createRndExampleButton.Name = "createRndExampleButton";
            this.createRndExampleButton.Size = new System.Drawing.Size(221, 30);
            this.createRndExampleButton.TabIndex = 3;
            this.createRndExampleButton.Text = "Сгенерировать пример";
            this.createRndExampleButton.UseVisualStyleBackColor = true;
            this.createRndExampleButton.Click += new System.EventHandler(this.createRndExampleButton_Click);
            // 
            // LogsTextField
            // 
            this.LogsTextField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogsTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogsTextField.Location = new System.Drawing.Point(12, 99);
            this.LogsTextField.Multiline = true;
            this.LogsTextField.Name = "LogsTextField";
            this.LogsTextField.ReadOnly = true;
            this.LogsTextField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogsTextField.Size = new System.Drawing.Size(1010, 281);
            this.LogsTextField.TabIndex = 4;
            this.LogsTextField.WordWrap = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.установитьДиректориюToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // установитьДиректориюToolStripMenuItem
            // 
            this.установитьДиректориюToolStripMenuItem.Name = "установитьДиректориюToolStripMenuItem";
            this.установитьДиректориюToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.установитьДиректориюToolStripMenuItem.Text = "Установить директорию";
            this.установитьДиректориюToolStripMenuItem.Click += new System.EventHandler(this.установитьДиректориюToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // DeleteFile_by_WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 388);
            this.Controls.Add(this.LogsTextField);
            this.Controls.Add(this.createRndExampleButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.wordTextField);
            this.Controls.Add(this.addresTextField);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2500, 2500);
            this.MinimumSize = new System.Drawing.Size(670, 211);
            this.Name = "DeleteFile_by_WordForm";
            this.Text = "Поиск и удаление файлов по ключевым словам";
            this.Load += new System.EventHandler(this.DeleteFile_by_WordForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addresTextField;
        private System.Windows.Forms.TextBox wordTextField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button createRndExampleButton;
        private System.Windows.Forms.TextBox LogsTextField;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem установитьДиректориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

