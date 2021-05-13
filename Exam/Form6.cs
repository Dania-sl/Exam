using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exam
{
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
            
        }
        
        private void enterPassword_Click(object sender, EventArgs e)
        {
            if(psswordBox.Text == "0000")
            {
                editList newForm5 = new editList();
                newForm5.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Невірний пароль!");
            }

        }
    }
}
