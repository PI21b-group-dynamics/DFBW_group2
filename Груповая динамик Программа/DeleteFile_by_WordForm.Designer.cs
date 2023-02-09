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
            this.addresTextField = new System.Windows.Forms.TextBox();
            this.wordTextField = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.createRndExampleButton = new System.Windows.Forms.Button();
            this.LogsTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addresTextField
            // 
            this.addresTextField.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addresTextField.Location = new System.Drawing.Point(12, 12);
            this.addresTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addresTextField.Name = "addresTextField";
            this.addresTextField.Size = new System.Drawing.Size(776, 27);
            this.addresTextField.TabIndex = 0;
            this.addresTextField.Enter += new System.EventHandler(this.addresTextField_Enter);
            this.addresTextField.Leave += new System.EventHandler(this.addresTextField_Leave);
            // 
            // wordTextField
            // 
            this.wordTextField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordTextField.Location = new System.Drawing.Point(12, 46);
            this.wordTextField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wordTextField.Name = "wordTextField";
            this.wordTextField.Size = new System.Drawing.Size(249, 30);
            this.wordTextField.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(267, 46);
            this.sendButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 30);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Sand";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // createRndExampleButton
            // 
            this.createRndExampleButton.Location = new System.Drawing.Point(489, 46);
            this.createRndExampleButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createRndExampleButton.Name = "createRndExampleButton";
            this.createRndExampleButton.Size = new System.Drawing.Size(300, 30);
            this.createRndExampleButton.TabIndex = 3;
            this.createRndExampleButton.Text = "Добавить слуйные файлы для примера";
            this.createRndExampleButton.UseVisualStyleBackColor = true;
            this.createRndExampleButton.Click += new System.EventHandler(this.createRndExampleButton_Click);
            // 
            // LogsTextField
            // 
            this.LogsTextField.Location = new System.Drawing.Point(12, 81);
            this.LogsTextField.Multiline = true;
            this.LogsTextField.Name = "LogsTextField";
            this.LogsTextField.ReadOnly = true;
            this.LogsTextField.Size = new System.Drawing.Size(776, 369);
            this.LogsTextField.TabIndex = 4;
            // 
            // DeleteFile_by_WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 462);
            this.Controls.Add(this.LogsTextField);
            this.Controls.Add(this.createRndExampleButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.wordTextField);
            this.Controls.Add(this.addresTextField);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2500, 2500);
            this.Name = "DeleteFile_by_WordForm";
            this.Text = "Удаление фалов";
            this.Load += new System.EventHandler(this.DeleteFile_by_WordForm_Load);
            this.SizeChanged += new System.EventHandler(this.DeleteFile_by_WordForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addresTextField;
        private System.Windows.Forms.TextBox wordTextField;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button createRndExampleButton;
        private System.Windows.Forms.TextBox LogsTextField;
    }
}

