
namespace Exam
{
    partial class findStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.find = new System.Windows.Forms.Button();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.ptronymicField = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(303, 138);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(193, 53);
            this.find.TabIndex = 0;
            this.find.Text = "Знайти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(330, 109);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(153, 23);
            this.firstNameField.TabIndex = 1;
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(12, 109);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(153, 23);
            this.lastNameField.TabIndex = 2;
            // 
            // ptronymicField
            // 
            this.ptronymicField.Location = new System.Drawing.Point(626, 109);
            this.ptronymicField.Name = "ptronymicField";
            this.ptronymicField.Size = new System.Drawing.Size(153, 23);
            this.ptronymicField.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(769, 74);
            this.dataGridView1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Фамілія";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ім\'я";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "По батькові";
            // 
            // findStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 199);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ptronymicField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.find);
            this.Name = "findStudent";
            this.Text = "Знайти студента";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ptronymicField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

