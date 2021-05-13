using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Exam
{
    public partial class findStudent : Form
    {
        public findStudent()
        {
            InitializeComponent();
        }
            dataBase db = new dataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
        private void find_Click(object sender, EventArgs e)
        {
            string nameUser = firstNameField.Text;
            string surnameUser = lastNameField.Text;
            string patronymicUser = ptronymicField.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `students` WHERE `last_name` = @lN AND `first_name` = @fN AND `patronymic` = @pN", db.getConnection());
            command.Parameters.Add("@lN", MySqlDbType.VarChar).Value = surnameUser;
            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = nameUser;
            command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = patronymicUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 0)
            {
                MessageBox.Show("Перевірте введені дані!");
            }
            else
            {
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
            }
            

        }
    }
}
