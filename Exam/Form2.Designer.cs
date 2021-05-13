
namespace Exam
{
    partial class report
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
            this.avgMarkGrup = new System.Windows.Forms.Button();
            this.avgMarkStudetn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.choisSubject = new System.Windows.Forms.ComboBox();
            this.checkGrupResult = new System.Windows.Forms.CheckBox();
            this.avgMark = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // avgMarkGrup
            // 
            this.avgMarkGrup.Location = new System.Drawing.Point(12, 211);
            this.avgMarkGrup.Name = "avgMarkGrup";
            this.avgMarkGrup.Size = new System.Drawing.Size(543, 35);
            this.avgMarkGrup.TabIndex = 0;
            this.avgMarkGrup.Text = "Середній бал групи / Загальні результати";
            this.avgMarkGrup.UseVisualStyleBackColor = true;
            this.avgMarkGrup.Click += new System.EventHandler(this.avgMarkGrup_Click);
            // 
            // avgMarkStudetn
            // 
            this.avgMarkStudetn.Location = new System.Drawing.Point(12, 278);
            this.avgMarkStudetn.Name = "avgMarkStudetn";
            this.avgMarkStudetn.Size = new System.Drawing.Size(186, 33);
            this.avgMarkStudetn.TabIndex = 1;
            this.avgMarkStudetn.Text = "Отримати";
            this.avgMarkStudetn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.avgMarkStudetn.UseVisualStyleBackColor = true;
            this.avgMarkStudetn.Click += new System.EventHandler(this.avgMarkStudetn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(543, 149);
            this.dataGridView1.TabIndex = 2;
            // 
            // choisSubject
            // 
            this.choisSubject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choisSubject.FormattingEnabled = true;
            this.choisSubject.Items.AddRange(new object[] {
            "Технології створення програмних продуктів",
            "Технології програмування",
            "Системний аналіз/схемотехніка",
            "Компютерна графіка",
            "Теорія ймовірності",
            "Філософія",
            "Предмет за вибором"});
            this.choisSubject.Location = new System.Drawing.Point(228, 281);
            this.choisSubject.Name = "choisSubject";
            this.choisSubject.Size = new System.Drawing.Size(328, 33);
            this.choisSubject.TabIndex = 3;
            // 
            // checkGrupResult
            // 
            this.checkGrupResult.AutoSize = true;
            this.checkGrupResult.Location = new System.Drawing.Point(12, 12);
            this.checkGrupResult.Name = "checkGrupResult";
            this.checkGrupResult.Size = new System.Drawing.Size(136, 19);
            this.checkGrupResult.TabIndex = 4;
            this.checkGrupResult.Text = "Загальні результати";
            this.checkGrupResult.UseVisualStyleBackColor = true;
            this.checkGrupResult.CheckedChanged += new System.EventHandler(this.checkGrupResult_CheckedChanged);
            // 
            // avgMark
            // 
            this.avgMark.AutoSize = true;
            this.avgMark.Location = new System.Drawing.Point(151, 12);
            this.avgMark.Name = "avgMark";
            this.avgMark.Size = new System.Drawing.Size(99, 19);
            this.avgMark.TabIndex = 5;
            this.avgMark.Text = "Середні бали";
            this.avgMark.UseVisualStyleBackColor = true;
            this.avgMark.CheckedChanged += new System.EventHandler(this.avgMark_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Оберіть дисципліну по якій хочете отримати дані середній бал групи/загальні бали " +
    "групи";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgMark);
            this.Controls.Add(this.checkGrupResult);
            this.Controls.Add(this.choisSubject);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.avgMarkStudetn);
            this.Controls.Add(this.avgMarkGrup);
            this.Name = "report";
            this.Text = "Звіт";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button avgMarkGrup;
        private System.Windows.Forms.Button avgMarkStudetn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox choisSubject;
        private System.Windows.Forms.CheckBox checkGrupResult;
        private System.Windows.Forms.CheckBox avgMark;
        private System.Windows.Forms.Label label1;
    }
}