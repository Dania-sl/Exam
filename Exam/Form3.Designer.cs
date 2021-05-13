
namespace Exam
{
    partial class rating
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scholarship = new System.Windows.Forms.Button();
            this.deductions = new System.Windows.Forms.Button();
            this.arrears = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 149);
            this.dataGridView1.TabIndex = 6;
            // 
            // scholarship
            // 
            this.scholarship.Location = new System.Drawing.Point(12, 181);
            this.scholarship.Name = "scholarship";
            this.scholarship.Size = new System.Drawing.Size(159, 33);
            this.scholarship.TabIndex = 7;
            this.scholarship.Text = "Степендія";
            this.scholarship.UseVisualStyleBackColor = true;
            this.scholarship.Click += new System.EventHandler(this.scholarship_Click);
            // 
            // deductions
            // 
            this.deductions.Location = new System.Drawing.Point(396, 181);
            this.deductions.Name = "deductions";
            this.deductions.Size = new System.Drawing.Size(159, 33);
            this.deductions.TabIndex = 8;
            this.deductions.Text = "Відчилення";
            this.deductions.UseVisualStyleBackColor = true;
            this.deductions.Click += new System.EventHandler(this.deductions_Click);
            // 
            // arrears
            // 
            this.arrears.Location = new System.Drawing.Point(205, 181);
            this.arrears.Name = "arrears";
            this.arrears.Size = new System.Drawing.Size(159, 33);
            this.arrears.TabIndex = 9;
            this.arrears.Text = "Заборгованість";
            this.arrears.UseVisualStyleBackColor = true;
            this.arrears.Click += new System.EventHandler(this.arrears_Click);
            // 
            // rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 239);
            this.Controls.Add(this.arrears);
            this.Controls.Add(this.deductions);
            this.Controls.Add(this.scholarship);
            this.Controls.Add(this.dataGridView1);
            this.Name = "rating";
            this.Text = "Рейтинг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button scholarship;
        private System.Windows.Forms.Button deductions;
        private System.Windows.Forms.Button arrears;
    }
}