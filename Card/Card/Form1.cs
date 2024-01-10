using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

            
            SqlConnection conn = new SqlConnection("Server=DESKTOP-K0DUEH1\\SQLEXPRESS;Database=Card;Trusted_Connection=True;");
            conn.Open();
            try
            {



               
                using (SqlCommand cmdm = new SqlCommand())
                {
                 
                    cmdm.Connection = conn;
                    cmdm.CommandText = "SELECT card_number, id FROM[dbo].[card] WHERE card_number = '2421-1243-2023-1123'";

                    SqlDataReader dataToread = cmdm.ExecuteReader();

                    
                    while (dataToread.Read())
                    {
                        string dataParametre = dataToread["card_number"].ToString();
                      
                        MessageBox.Show(dataParametre, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                conn.Close();
               
              
            }
            catch (Exception typeErr)
            {
                MessageBox.Show("An Error in the Process  Fill Tables: Error 138 Type: " + typeErr, "ERROR EXECUTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
