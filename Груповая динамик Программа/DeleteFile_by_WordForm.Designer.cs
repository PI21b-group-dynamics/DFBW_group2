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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseFolder = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addresTextField
            // 
            this.addresTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addresTextField.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.addresTextField.Location = new System.Drawing.Point(12, 11);
            this.addresTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addresTextField.Name = "addresTextField";
            this.addresTextField.Size = new System.Drawing.Size(693, 34);
            this.addresTextField.TabIndex = 0;
            this.addresTextField.Enter += new System.EventHandler(this.addresTextField_Enter);
            this.addresTextField.Leave += new System.EventHandler(this.addresTextField_Leave);
            // 
            // wordTextField
            // 
            this.wordTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordTextField.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.wordTextField.Location = new System.Drawing.Point(12, 52);
            this.wordTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordTextField.Name = "wordTextField";
            this.wordTextField.Size = new System.Drawing.Size(483, 34);
            this.wordTextField.TabIndex = 1;
            this.wordTextField.Enter += new System.EventHandler(this.wordTextField_Enter);
            this.wordTextField.Leave += new System.EventHandler(this.wordTextField_Leave);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(501, 52);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(205, 38);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Найти и удалить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // createRndExampleButton
            // 
            this.createRndExampleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createRndExampleButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createRndExampleButton.Location = new System.Drawing.Point(801, 52);
            this.createRndExampleButton.Margin = new System.Windows.Forms.Padding(4);
            this.createRndExampleButton.Name = "createRndExampleButton";
            this.createRndExampleButton.Size = new System.Drawing.Size(221, 38);
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
            this.LogsTextField.Location = new System.Drawing.Point(12, 96);
            this.LogsTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogsTextField.Multiline = true;
            this.LogsTextField.Name = "LogsTextField";
            this.LogsTextField.ReadOnly = true;
            this.LogsTextField.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogsTextField.Size = new System.Drawing.Size(1009, 320);
            this.LogsTextField.TabIndex = 4;
            this.LogsTextField.WordWrap = false;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // chooseFolder
            // 
            this.chooseFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseFolder.Image = global::Груповая_динамика_Программа.Properties.Resources.open_folder;
            this.chooseFolder.Location = new System.Drawing.Point(713, 11);
            this.chooseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.chooseFolder.Name = "chooseFolder";
            this.chooseFolder.Size = new System.Drawing.Size(52, 36);
            this.chooseFolder.TabIndex = 6;
            this.chooseFolder.UseVisualStyleBackColor = true;
            this.chooseFolder.Click += new System.EventHandler(this.chooseFolder_Click);
            // 
            // helpButton
            // 
            this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.helpButton.Location = new System.Drawing.Point(801, 11);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(221, 36);
            this.helpButton.TabIndex = 7;
            this.helpButton.Text = "Справка";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // DeleteFile_by_WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 427);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.chooseFolder);
            this.Controls.Add(this.LogsTextField);
            this.Controls.Add(this.createRndExampleButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.wordTextField);
            this.Controls.Add(this.addresTextField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2499, 2499);
            this.MinimumSize = new System.Drawing.Size(857, 339);
            this.Name = "DeleteFile_by_WordForm";
            this.Text = "Поиск и удаление файлов по ключевым словам";
            this.Load += new System.EventHandler(this.DeleteFile_by_WordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addresTextField;
        private System.Windows.Forms.TextBox wordTextField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button createRndExampleButton;
        private System.Windows.Forms.TextBox LogsTextField;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button chooseFolder;
        private System.Windows.Forms.Button helpButton;
    }
}

