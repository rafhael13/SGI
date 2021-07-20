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
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textCUsu.Clear();
            textNUsu.Clear();
            textSUsu.Clear();
            textLUsu.Clear();
            textPassUsu.Clear();
            textSbUsu.Clear();
            

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("insert into Usuario(UserID,LoginName, Password, FirstName, LastName,Permission,Setor)values(@UserID, @LoginName, @Password, @FirstName, @LastName, @Permission,@Setor)", sql);
            command.Parameters.Add("@LoginName", SqlDbType.NVarChar).Value = textLUsu.Text;
            command.Parameters.Add("@UserID", SqlDbType.NVarChar).Value = textCUsu.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textPassUsu.Text;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textNUsu.Text;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textSbUsu.Text;
            command.Parameters.Add("@Permission", SqlDbType.NVarChar).Value = ComboxUsu.Text;
            command.Parameters.Add("@Setor", SqlDbType.NVarChar).Value = textSUsu.Text;

            if(textCUsu.Text != "" & textLUsu.Text !="" & textPassUsu.Text != "" & textNUsu.Text != "" & textSbUsu.Text != "" & ComboxUsu.Text != "" & textSUsu.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CADASTRO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    textLUsu.Text = "";
                    textCUsu.Text = "";
                    textPassUsu.Text = "";
                    textNUsu.Text = "";
                    textSbUsu.Text = "";
                    ComboxUsu.Text = "";
                    textSUsu.Text = "";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("update Usuario set LoginName=@LoginName, Password=@Password, FirstName=@FirstName, LastName=@LastName,Permission=@Permission,Setor=@Setor where UserID=@UserID", sql);
            command.Parameters.Add("@LoginName", SqlDbType.NVarChar).Value = textLUsu.Text;
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = textCUsu.Text;
            command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = textPassUsu.Text;
            command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = textNUsu.Text;
            command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = textSbUsu.Text;
            command.Parameters.Add("@Permission", SqlDbType.NVarChar).Value = ComboxUsu.Text;
            command.Parameters.Add("@Setor", SqlDbType.NVarChar).Value = textSUsu.Text;

            if (textLUsu.Text != "" & textCUsu.Text != "" & textPassUsu.Text != "" & textNUsu.Text != "" & textSbUsu.Text != "" & ComboxUsu.Text != "" & textSUsu.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textLUsu.Text = "";
                    textCUsu.Text = "";
                    textPassUsu.Text = "";
                    textNUsu.Text = "";
                    textSbUsu.Text = "";
                    ComboxUsu.Text = "";
                    textSUsu.Text = "";
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

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Usuario where UserID=@UserID", sql);
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = textCUsu.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("UserID não encontrado!!!");              
                }
                drms.Read();
                textCUsu.Text = Convert.ToString(drms["UserID"]);
                textLUsu.Text = Convert.ToString(drms["LoginName"]);
                textNUsu.Text = Convert.ToString(drms["FirstName"]);
                textPassUsu.Text = Convert.ToString(drms["Password"]);
                textSbUsu.Text = Convert.ToString(drms["LastName"]);
                textSUsu.Text = Convert.ToString(drms["UserID"]);
                ComboxUsu.Text = Convert.ToString(drms["Permission"]);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("delete from Usuario where UserID=@UserID", sql);
            command.Parameters.Add("@UserID", SqlDbType.Int).Value = textCUsu.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELPTECH - EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textLUsu.Text = "";
                textCUsu.Text = "";
                textPassUsu.Text = "";
                textNUsu.Text = "";
                textSbUsu.Text = "";
                ComboxUsu.Text = "";
                textSUsu.Text = "";
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
