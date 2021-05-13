
namespace Exam
{
    partial class password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.psswordBox = new System.Windows.Forms.TextBox();
            this.enterPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // psswordBox
            // 
            this.psswordBox.Location = new System.Drawing.Point(12, 12);
            this.psswordBox.Name = "psswordBox";
            this.psswordBox.Size = new System.Drawing.Size(207, 23);
            this.psswordBox.TabIndex = 0;
            // 
            // enterPassword
            // 
            this.enterPassword.Location = new System.Drawing.Point(12, 41);
            this.enterPassword.Name = "enterPassword";
            this.enterPassword.Size = new System.Drawing.Size(207, 21);
            this.enterPassword.TabIndex = 3;
            this.enterPassword.Text = "Ввести пароль";
            this.enterPassword.UseVisualStyleBackColor = true;
            this.enterPassword.Click += new System.EventHandler(this.enterPassword_Click);
            // 
            // password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 68);
            this.Controls.Add(this.enterPassword);
            this.Controls.Add(this.psswordBox);
            this.Name = "password";
            this.Text = "Пароль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox psswordBox;
        private System.Windows.Forms.Button enterPassword;
    }
}