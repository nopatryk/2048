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

namespace _20
{
    public partial class Records : Form
    {
        private int points;
        private SqlConnection sqlConnection1;

        public Records(int points,string sconn)
        {
            InitializeComponent();
            sqlConnection1 = new SqlConnection(sconn);
            this.points = points;
            yoursRecord.Text = points.ToString();
            recordTableAdapter.Fill(this.recordsDataSet.record);
        }

        private void saveYoursRecord_Click(object sender, EventArgs e)
        {
            if (!NickBox.Text.Equals(""))
            {
                SqlCommand cmd = new SqlCommand();
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
