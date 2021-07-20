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
    public partial class CadastroMercado : Form
    {
        public CadastroMercado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textCMer.Clear();
            textPMer.Clear();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Mercado where MercadoID=@MercadoID", sql);
            command.Parameters.Add("@MercadoID", SqlDbType.Int).Value = textCMer.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("MercadoID não encontrado!!!");
                }
                drms.Read();
                textCMer.Text = Convert.ToString(drms["MercadoID"]);
                textPMer.Text = Convert.ToString(drms["Pais"]);
                ComboxTM.Text = Convert.ToString(drms["TipoMercado"]);

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

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("insert into Mercado(MercadoID, Pais, TipoMercado)values(@MercadoID,@Pais, @TipoMercado)", sql);
            command.Parameters.Add("@MercadoID", SqlDbType.NVarChar).Value = textCMer.Text;
            command.Parameters.Add("@Pais", SqlDbType.NVarChar).Value = textPMer.Text;
            command.Parameters.Add("@TipoMercado", SqlDbType.NVarChar).Value = ComboxTM.Text;


            if (textCMer.Text != "" & textPMer.Text != "" & ComboxTM.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ComboxTM.Text = "";
                    textPMer.Text = "";
                    textCMer.Text = "";


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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("delete from Mercado where MercadoID=@MercadoID", sql);
            command.Parameters.Add("@MercadoID", SqlDbType.Int).Value = textCMer.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELPTECH - EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPMer.Text = "";
                ComboxTM.Text = "";

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
            SqlCommand command = new SqlCommand("update Mercado set Pais=@pais, TipoMercado=@TipoMercado where MercadoID=@MercadoID", sql);
            command.Parameters.Add("@MercadoID", SqlDbType.Int).Value = textCMer.Text;
            command.Parameters.Add("@Pais", SqlDbType.NVarChar).Value = textPMer.Text;
            command.Parameters.Add("@TipoMercado", SqlDbType.NVarChar).Value = ComboxTM.Text;

            if (textCMer.Text != "" & textPMer.Text != "" & ComboxTM.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCMer.Text = "";
                    ComboxTM.Text = "";
                    textPMer.Text = "";
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
    }
}
