using System;
using System.Data;
using System.Data.SqlClient;

namespace Eco_Pharmacy
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\querc\source\repos\Eco Pharmacy\Eco Pharmacy\Database1.mdf"";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from cop", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into cop "
                + "values(" + txtNum.Text + " , '" + txtName.Text + "'," + txtPrice.Text + " , " + txtAmount.Text + ")", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE cop SET [Product Name] = '" + txtName.Text + "', " +
                " Price =  " + txtPrice.Text + " WHERE [Product Number] = " + txtNum.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM cop WHERE [Product Number] = " + txtNum.Text, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}