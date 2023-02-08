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
            this.SuspendLayout();
            // 
            // addresTextField
            // 
            this.addresTextField.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addresTextField.Location = new System.Drawing.Point(12, 12);
            this.addresTextField.Name = "addresTextField";
            this.addresTextField.Size = new System.Drawing.Size(776, 27);
            this.addresTextField.TabIndex = 0;
            this.addresTextField.Enter += new System.EventHandler(this.addresTextField_Enter);
            this.addresTextField.Leave += new System.EventHandler(this.addresTextField_Leave);
            // 
            // wordTextField
            // 
            this.wordTextField.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordTextField.Location = new System.Drawing.Point(12, 45);
            this.wordTextField.Name = "wordTextField";
            this.wordTextField.Size = new System.Drawing.Size(249, 30);
            this.wordTextField.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(267, 45);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(80, 30);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Sand";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // DeleteFile_by_WordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 82);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.wordTextField);
            this.Controls.Add(this.addresTextField);
            this.MaximumSize = new System.Drawing.Size(2500, 130);
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
    }
}

