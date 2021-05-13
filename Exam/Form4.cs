using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Exam
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

       
        private void personalData_Click(object sender, EventArgs e)
        {
            findStudent newForm1 = new findStudent();
            newForm1.Name = "mdi";
            if (!Application.OpenForms.Cast<Form>().Any(f => f.Name == "mdi"))
            {
                newForm1.Show();
            }
            else MessageBox.Show("Спочатку закрийте відкриту форму!");
        }

        private void repornOnAvgScores_Click(object sender, EventArgs e)
        {
            report newForm2 = new report();
            newForm2.Name = "mdi";
            if (!Application.OpenForms.Cast<Form>().Any(f => f.Name == "mdi"))
            {
                newForm2.Show();
            }
            else MessageBox.Show("Спочатку закрийте відкриту форму!");
        }

        private void rating_Click(object sender, EventArgs e)
        {
            rating newForm3 = new rating();
            newForm3.Name = "mdi";
            if (!Application.OpenForms.Cast<Form>().Any(f => f.Name == "mdi"))
            {
                newForm3.Show();
            }
            else MessageBox.Show("Спочатку закрийте відкриту форму!");
        }

        private void editList_Click(object sender, EventArgs e)
        {

            password newForm6 = new password();
            newForm6.Name = "mdi";
            if (!Application.OpenForms.Cast<Form>().Any(f => f.Name == "mdi"))
            {
                newForm6.Show();
            }
            else MessageBox.Show("Спочатку закрийте відкриту форму!");
           

            
                
           
        }
    }
}
