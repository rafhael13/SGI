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
using Domain;

namespace SGI
{
    public partial class CadastroCortes : Form
    {
        public CadastroCortes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void CadastroCortes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'myCompanyDataSet.Mercado'. Você pode movê-la ou removê-la conforme necessário.
            this.mercadoTableAdapter.Fill(this.myCompanyDataSet.Mercado);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Corte where CorteID=@CorteID", sql);
            command.Parameters.Add("@CorteID", SqlDbType.Int).Value = textCIns.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("CorteID não encontrado!!!");
                }
                drms.Read();
                textCIns.Text = Convert.ToString(drms["CorteID"]);
                textDIns.Text = Convert.ToString(drms["DescricaoC"]);
                comboBox1.Text = Convert.ToString(drms["MercadoC"]);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("insert into Corte(CorteID,DescricaoC, MercadoC)values(@CorteID, @DescricaoC, @MercadoC)", sql);
            command.Parameters.Add("@CorteID", SqlDbType.Int).Value = textCIns.Text;
            command.Parameters.Add("@DescricaoC", SqlDbType.NVarChar).Value = textDIns.Text;
            command.Parameters.Add("@MercadoC", SqlDbType.NVarChar).Value = comboBox1.Text;


            if (textCIns.Text != "" & textDIns.Text != "" & comboBox1.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCIns.Text = "";
                    textDIns.Text = "";
                    comboBox1.Text = "";

                }
                catch
                {
                    MessageBox.Show("Por favor preencher todos os campos!!!");
                }
                finally
                {
                    sql.Close();
                }
            }

            else
            {
                MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("delete from Corte where CorteID=@CorteID", sql);
            command.Parameters.Add("@CorteID", SqlDbType.Int).Value = textCIns.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELPTECH - EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCIns.Text = "";
                textDIns.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("update Corte set DescricaoC=@DescricaoC, MercadoC=@MercadoC where CorteID=@CorteID", sql);
            command.Parameters.Add("@CorteID", SqlDbType.Int).Value = textCIns.Text;
            command.Parameters.Add("@DescricaoC", SqlDbType.NVarChar).Value = textDIns.Text;
            command.Parameters.Add("@MercadoC", SqlDbType.NVarChar).Value = comboBox1.Text;

            if (textCIns.Text != "" & textDIns.Text != "" & comboBox1.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCIns.Text = "";
                    textDIns.Text = "";
                    comboBox1.Text = "";
                }
                catch
                {
                    MessageBox.Show("Por favor preencher todos os campos!!!");
                }
                finally
                {
                    sql.Close();
                }
            }

            else
            {
                MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - CAMPOS OBRIGATÓRIOS", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            textCIns.Clear();
            textDIns.Clear();
            
        }
    }
}