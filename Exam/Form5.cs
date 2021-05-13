using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Exam
{
    public partial class editList : Form
    {
        dataBase db = new dataBase();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        private int checkMark(string mark)
        { 

            if (mark == "")
                return 0;
            try { 
           
                return 
                    Convert.ToInt32(mark);
            }
            catch
            {
                return 0;
            }
        }

       

        private void cleareGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.ReadOnly = true;
            table.Rows.Clear();
            table.Columns.Clear();
            table.Dispose();
        }

        private void executionRequest(string request)
        {
            cleareGrid();
            MySqlCommand command = new MySqlCommand(request, db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count != 0)
                dataGridView1.DataSource = table;
        }

        public editList()
        {
            InitializeComponent();
            MessageBox.Show("Усі некоректно введені дані (Текстові символи в поле з оцінками) будуть замінені на 0!", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void findStudent_Click(object sender, EventArgs e)
        {
            executionRequest("SELECT * FROM `students` WHERE `last_name` = '"+lastNameField.Text+"' AND `first_name` = '"+firstNameField.Text+"' AND `patronymic` ='"+ptronymicField.Text+"';");
        }

        private void updateData_Click(object sender, EventArgs e)
        {

            if (checkMark(ptField.Text) >= 0 & checkMark(ptField.Text) <= 40 & ptField.Text != "")
                executionRequest("UPDATE `students` SET `Programming_technologies`=" + checkMark(ptField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(cgField.Text) >= 0 & checkMark(cgField.Text) <= 40 & cgField.Text != "")
                executionRequest("UPDATE `students` SET `Computer_graphics`=" + checkMark(cgField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(tcField.Text) >= 0 & checkMark(tcField.Text) <= 40 & tcField.Text != "")
                executionRequest("UPDATE `students` SET `Technology_of_software_products_development`=" + checkMark(tcField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(phField.Text) >= 0 & checkMark(phField.Text) <= 40 & phField.Text != "")
                executionRequest("UPDATE `students` SET `Philosophy`=" + checkMark(phField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(teField.Text) >= 0 & checkMark(teField.Text) <= 40 & teField.Text != "")
                executionRequest("UPDATE `students` SET `The_theory_of_imovirnosti_and_mathematical_statistics`=" + checkMark(teField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(saField.Text) >= 0 & checkMark(saField.Text) <= 40 & saField.Text != "")
                executionRequest("UPDATE `students` SET `System_analysis_Computer_circuitry`=" + checkMark(saField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");

            if (checkMark(csField.Text) >= 0 & checkMark(csField.Text) <= 40 & csField.Text != "")
            {
                executionRequest("UPDATE `students` SET `Subject_of_choice`=" + checkMark(csField.Text) + " where `last_name` ='" + lastNameField.Text + "' AND `first_name` ='" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");
            }
            executionRequest("SELECT * FROM `students` WHERE `last_name` = '" + lastNameField.Text + "' AND `first_name` = '" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");


        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            if (checkMark(ptField.Text) >= 0 & checkMark(ptField.Text) <= 40 &
                checkMark(cgField.Text) >= 0 & checkMark(cgField.Text) <= 40 &
                checkMark(tcField.Text) >= 0 & checkMark(tcField.Text) <= 40 &
                checkMark(phField.Text) >= 0 & checkMark(phField.Text) <= 40 &
                checkMark(teField.Text) >= 0 & checkMark(teField.Text) <= 40 &
                checkMark(saField.Text) >= 0 & checkMark(saField.Text) <= 40 &
                checkMark(csField.Text) >= 0 & checkMark(csField.Text) <= 40 )
            {
                executionRequest("Insert into `students` (last_name, first_name, patronymic, Subject_of_choice, System_analysis_Computer_circuitry,The_theory_of_imovirnosti_and_mathematical_statistics, Philosophy, Technology_of_software_products_development, Programming_technologies, Computer_graphics) values ('" + lastNameField.Text + "','" + firstNameField.Text + "','" + ptronymicField.Text + "','" + checkMark(csField.Text) + "','" + checkMark(saField.Text) + "','" + checkMark(teField.Text) + "','" + checkMark(phField.Text) + "','" + checkMark(tcField.Text) + "', '" + checkMark(ptField.Text) + "','" + checkMark(cgField.Text) + "');");

                executionRequest("SELECT * FROM `students` WHERE `last_name` = '" + lastNameField.Text + "' AND `first_name` = '" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");
            }
            else MessageBox.Show("Перевірте діапазон значень(Від 0 до 40)!", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void removeStuden_Click(object sender, EventArgs e)
        {
            executionRequest("DELETE FROM `students` WHERE `last_name` = '" + lastNameField.Text + "' AND `first_name` = '" + firstNameField.Text + "' AND `patronymic` ='" + ptronymicField.Text + "';");
            executionRequest("ALTER TABLE `students` AUTO_INCREMENT = 1");
        }

    }
}
