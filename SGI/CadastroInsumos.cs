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
    public partial class CadastroInsumos : Form
    {
        public CadastroInsumos()
        {
            InitializeComponent();
        }


        

        private void CadastroInsumos_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textCIns.Clear();
            textDIns.Clear();
            textFIns.Clear();
            textUIns.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textCIns.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textCIns.Text = Convert.ToString(drms["InsumoID"]);
                textDIns.Text = Convert.ToString(drms["Descricao"]);
                textFIns.Text = Convert.ToString(drms["Familia"]);
                textUIns.Text = Convert.ToString(drms["UM"]);
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
            SqlCommand command = new SqlCommand("insert into Insumo(InsumoID, Descricao, Familia, UM)values(@InsumoID, @Descricao, @Familia, @UM)", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textCIns.Text;
            command.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = textDIns.Text;
            command.Parameters.Add("@Familia", SqlDbType.NVarChar).Value = textFIns.Text;
            command.Parameters.Add("@UM", SqlDbType.NVarChar).Value = textUIns.Text;
            

            if (textCIns.Text != "" & textDIns.Text != "" & textFIns.Text != "" & textUIns.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCIns.Text = "";
                    textDIns.Text = "";
                    textFIns.Text = "";
                    textUIns.Text = "";
                    
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("update Insumo set Descricao=@Descricao, Familia=@Familia, UM=@UM where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textCIns.Text;
            command.Parameters.Add("@Descricao", SqlDbType.NVarChar).Value = textDIns.Text;
            command.Parameters.Add("@Familia", SqlDbType.NVarChar).Value = textFIns.Text;
            command.Parameters.Add("@UM", SqlDbType.NVarChar).Value = textUIns.Text;

            if (textCIns.Text != "" & textDIns.Text != "" & textFIns.Text != "" & textUIns.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textCIns.Text = "";
                    textDIns.Text = "";
                    textFIns.Text = "";
                    textUIns.Text = "";
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("delete from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textCIns.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELPTECH - EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textCIns.Text = "";
                textDIns.Text = "";
                textFIns.Text = "";
                textUIns.Text = "";
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
    }
}
