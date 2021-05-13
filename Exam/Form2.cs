using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Exam
{
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        dataBase db = new dataBase();

        DataTable table = new DataTable();

        MySqlDataAdapter adapter = new MySqlDataAdapter();

       
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
            dataGridView1.DataSource = table;
            
        }

        private void subjectChois(string sub)
        {

            executionRequest("SELECT `last_name`, `first_name`, `patronymic`," + sub + "FROM `students`;");
        }

        private void subjectAvgMark(string sub)
        {

            executionRequest("select avg(" + sub + ") FROM students;");
        }

        private void avgMarkGrup_Click(object sender, EventArgs e)
        {
           
            
                if (checkGrupResult.Checked == true)
                {

                    executionRequest("SELECT * FROM exam.students;");
                }
                if (avgMark.Checked == true)
                {

                    executionRequest("SELECT `last_name`, `first_name`, `patronymic`, (Technology_of_software_products_development +System_analysis_Computer_circuitry + The_theory_of_imovirnosti_and_mathematical_statistics + Computer_graphics + Philosophy + Subject_of_choice + Programming_technologies)/7 as avgMark FROM exam.students ");
                }
            

        }

        private void avgMarkStudetn_Click(object sender, EventArgs e)
        {
            
            
                if (checkGrupResult.Checked == true)
                {

                    if (choisSubject.Text == "Технології створення програмних продуктів")
                    {
                        subjectChois("`Technology_of_software_products_development`");
                    }
                    if (choisSubject.Text == "Технології програмування")
                    {
                        subjectChois("`Programming_technologies`");
                    }
                    if (choisSubject.Text == "Системний аналіз/схемотехніка")
                    {
                        subjectChois("`System_analysis_Computer_circuitry`");
                    }
                    if (choisSubject.Text == "Компютерна графіка")
                    {
                        subjectChois("`Computer_graphics`");
                    }
                    if (choisSubject.Text == "Теорія ймовірності")
                    {
                        subjectChois("`The_theory_of_imovirnosti_and_mathematical_statistics`");
                    }
                    if (choisSubject.Text == "Філософія")
                    {
                        subjectChois("`Philosophy`");
                    }
                    if (choisSubject.Text == "Предмет за вибором")
                    {
                        subjectChois("`Subject_of_choice`");
                    }
                    if (choisSubject.Text == "")
                    {
                        MessageBox.Show("Оберіть дисципліну!");
                    }

                }

                if (avgMark.Checked == true)
                {
                    if (choisSubject.Text == "Технології створення програмних продуктів")
                    {
                        subjectAvgMark("`Technology_of_software_products_development`");
                    }
                    if (choisSubject.Text == "Технології програмування")
                    {
                        subjectAvgMark("`Programming_technologies`");
                    }
                    if (choisSubject.Text == "Системний аналіз/схемотехніка")
                    {
                        subjectAvgMark("`System_analysis_Computer_circuitry`");
                    }
                    if (choisSubject.Text == "Компютерна графіка")
                    {
                        subjectAvgMark("`Computer_graphics`");
                    }
                    if (choisSubject.Text == "Теорія ймовірності")
                    {
                        subjectAvgMark("`The_theory_of_imovirnosti_and_mathematical_statistics`");
                    }
                    if (choisSubject.Text == "Філософія")
                    {
                        subjectAvgMark("`Philosophy`");
                    }
                    if (choisSubject.Text == "Предмет за вибором")
                    {
                        subjectAvgMark("`Subject_of_choice`");
                    }
                    if (choisSubject.Text == "")
                    {
                        MessageBox.Show("Оберіть дисципліну!");
                    }
                }
            
        }

        private void checkGrupResult_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGrupResult.Checked)
                avgMark.Checked = false;
            else
                checkGrupResult.Checked = false;
        }

        private void avgMark_CheckedChanged(object sender, EventArgs e)
        {
            if (avgMark.Checked)
                checkGrupResult.Checked = false;
            

        }

        private void report_Load(object sender, EventArgs e)
        {
            checkGrupResult.Checked = true;
        }
    }
}

