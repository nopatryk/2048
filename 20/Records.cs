using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Records : Form
    {
        int points;
        public Records(int points)
        {
            InitializeComponent();

            this.points = points;
            yoursRecord.Text = points.ToString();
            this.recordTableAdapter.Fill(this.recordsDataSet.record);
        }

        private void saveYoursRecord_Click(object sender, EventArgs e)
        {
            if (!NickBox.Text.Equals(""))
            {
                // TODO: This line of code loads data into the 'recordsDataSet.record' table. You can move, or remove it, as needed.
                
                string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string path = (System.IO.Path.GetDirectoryName(executable));
                string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "\\records.mdf;Integrated Security=True";

                System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection(s);

                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into dbo.record (points,name) values (" + points + ",'" + NickBox.Text + "')";
                cmd.Connection = sqlConnection1;

                sqlConnection1.Open();
                cmd.ExecuteNonQuery();
                sqlConnection1.Close();

                this.recordTableAdapter.FillBy(this.recordsDataSet.record);
            }else
            {
                MessageBox.Show("Input your nickname :)");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
