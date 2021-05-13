using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Exam
{
    public partial class rating : Form
    {
        public rating()
        {
            InitializeComponent();
            
        }


        dataBase db = new dataBase();
        DataTable table = new DataTable();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        private int count()
        {    
            string sql = "SELECT COUNT(*) FROM `students`";
            MySqlCommand cmd = new MySqlCommand(sql, db.getConnection()); 
            int newProdID = (int)cmd.ExecuteScalar();
            return newProdID;
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
            dataGridView1.DataSource = table;

        }
        private int[] idArray()
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;username=root;password=0000;database=exam");
            conn.Open();
            List<double> raitBall = new List<double>();
            
            int id = 0;
            while (id < 12)
            {
                id += 1;
                string request = "select(Technology_of_software_products_development + The_theory_of_imovirnosti_and_mathematical_statistics + System_analysis_Computer_circuitry + Computer_graphics + Philosophy + Subject_of_choice + Programming_technologies) / 7 from exam.students where id =" + id + ";";
                MySqlCommand command = new MySqlCommand(request, conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        raitBall.Add(reader.GetDouble(0));
                    }
                }
                reader.Close();
            }
            double[] array = new double[raitBall.Count];
            int[] idArray = new int[5];
            raitBall.CopyTo(array);
            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < 5; i++)
            {
                idArray[i] = raitBall.IndexOf(array[i]) + 1;
                
            }
            return idArray;
        }

        private void scholarship_Click(object sender, EventArgs e)
        {
            cleareGrid();
            int[] idArr = idArray();
            executionRequest("SELECT `last_name`, `first_name`, `patronymic` FROM `students` where id in (" + idArr[0] + "," + idArr[1] + "," + idArr[2] + "," + idArr[3] + "," + idArr[4] + ");");
            
        }

        private void arrears_Click(object sender, EventArgs e)
        {
            
            executionRequest( "SELECT `last_name`, `first_name`, `patronymic` FROM `students` where Technology_of_software_products_development like '0%' or System_analysis_Computer_circuitry like '0%' or The_theory_of_imovirnosti_and_mathematical_statistics like '0%' or Computer_graphics like '0%' or Philosophy like '0%' or Subject_of_choice like '0%' or Programming_technologies like '0%';");
          
        }

        private void deductions_Click(object sender, EventArgs e)
        {
             
            
            int[] idArr = idArray();
            executionRequest("SELECT `last_name`, `first_name`, `patronymic` FROM `students` where Technology_of_software_products_development != 0 and System_analysis_Computer_circuitry != 0 and The_theory_of_imovirnosti_and_mathematical_statistics !=0 and Computer_graphics != 0 and Philosophy != 0 and Subject_of_choice != 0 and Programming_technologies != 0 and id !=" + idArr[0] +" and id!= " + idArr[1] +" and id!=" + idArr[2] +" and id!= " + idArr[3] +" and id != " + idArr[0] +" and (Technology_of_software_products_development +System_analysis_Computer_circuitry + The_theory_of_imovirnosti_and_mathematical_statistics + Computer_graphics + Philosophy + Subject_of_choice + Programming_technologies)/7 <20;");
            
        }

    }
}
