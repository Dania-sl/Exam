
namespace Exam
{
    partial class menu
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
            this.personalData = new System.Windows.Forms.Button();
            this.repornOnAvgScores = new System.Windows.Forms.Button();
            this.rating = new System.Windows.Forms.Button();
            this.editList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personalData
            // 
            this.personalData.Location = new System.Drawing.Point(35, 12);
            this.personalData.Name = "personalData";
            this.personalData.Size = new System.Drawing.Size(196, 60);
            this.personalData.TabIndex = 0;
            this.personalData.Text = "Персональні дані";
            this.personalData.UseVisualStyleBackColor = true;
            this.personalData.Click += new System.EventHandler(this.personalData_Click);
            // 
            // repornOnAvgScores
            // 
            this.repornOnAvgScores.Location = new System.Drawing.Point(35, 112);
            this.repornOnAvgScores.Name = "repornOnAvgScores";
            this.repornOnAvgScores.Size = new System.Drawing.Size(196, 60);
            this.repornOnAvgScores.TabIndex = 1;
            this.repornOnAvgScores.Text = "Звіти по середнім балам";
            this.repornOnAvgScores.UseVisualStyleBackColor = true;
            this.repornOnAvgScores.Click += new System.EventHandler(this.repornOnAvgScores_Click);
            // 
            // rating
            // 
            this.rating.Location = new System.Drawing.Point(35, 210);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(196, 60);
            this.rating.TabIndex = 2;
            this.rating.Text = "Рейтинг";
            this.rating.UseVisualStyleBackColor = true;
            this.rating.Click += new System.EventHandler(this.rating_Click);
            // 
            // editList
            // 
            this.editList.Location = new System.Drawing.Point(35, 302);
            this.editList.Name = "editList";
            this.editList.Size = new System.Drawing.Size(196, 60);
            this.editList.TabIndex = 3;
            this.editList.Text = "Редагування списку";
            this.editList.UseVisualStyleBackColor = true;
            this.editList.Click += new System.EventHandler(this.editList_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 398);
            this.Controls.Add(this.editList);
            this.Controls.Add(this.rating);
            this.Controls.Add(this.repornOnAvgScores);
            this.Controls.Add(this.personalData);
            this.Name = "menu";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button personalData;
        private System.Windows.Forms.Button repornOnAvgScores;
        private System.Windows.Forms.Button rating;
        private System.Windows.Forms.Button editList;
    }
}