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
using Common.Cache;

namespace SGI
{
    public partial class Pesquisa : Form
    {
        public Pesquisa()
        {
            InitializeComponent();
        }

        private void btoFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Dispose();
        }

        private void Pesquisa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Corte", sql);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Insumo", sql);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Mercado", sql);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection sql = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            System.Data.DataTable dt = new System.Data.DataTable();
            System.Data.SqlClient.SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter("SELECT * from Usuario", sql);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (UserLoginCache.Permission == Permissions.Basico)
            {

                button4.Enabled = false;
            }
        }

        private void lblPesquisa_Click(object sender, EventArgs e)
        {

        }
    }
}
