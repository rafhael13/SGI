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
using ClosedXML.Excel;
using Common.Cache;

namespace SGI
{
    public partial class TCalculo : Form
    {
        public TCalculo()
        {
            InitializeComponent();
        }


        int operacao = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Corte where CorteID=@CorteID", sql);
            command.Parameters.Add("@CorteID", SqlDbType.Int).Value = textIDCC.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("CorteID não encontrado!!!");
                }
                drms.Read();
                textIDCC.Text = Convert.ToString(drms["CorteID"]);
                textDC.Text = Convert.ToString(drms["DescricaoC"]);
                textM.Text = Convert.ToString(drms["MercadoC"]);

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

        private void btoTamp_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textIDTP.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textIDTP.Text = Convert.ToString(drms["InsumoID"]);
                textDTP.Text = Convert.ToString(drms["Descricao"]);
                textUMTP.Text = Convert.ToString(drms["UM"]);
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

        private void btoFund_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textIDFD.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textIDFD.Text = Convert.ToString(drms["InsumoID"]);
                textDFD.Text = Convert.ToString(drms["Descricao"]);
                textUMFD.Text = Convert.ToString(drms["UM"]);
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

        private void btoES_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textIDES.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textIDES.Text = Convert.ToString(drms["InsumoID"]);
                textDES.Text = Convert.ToString(drms["Descricao"]);
                textUMES.Text = Convert.ToString(drms["UM"]);
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

        private void btoRot_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textIDR.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textIDR.Text = Convert.ToString(drms["InsumoID"]);
                textDR.Text = Convert.ToString(drms["Descricao"]);
                textUMR.Text = Convert.ToString(drms["UM"]);
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

        private void btoTS_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Insumo where InsumoID=@InsumoID", sql);
            command.Parameters.Add("@InsumoID", SqlDbType.Int).Value = textIDTS.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("InsumoID não encontrado!!!");
                }
                drms.Read();
                textIDTS.Text = Convert.ToString(drms["InsumoID"]);
                textDTS.Text = Convert.ToString(drms["Descricao"]);
                textUMTS.Text = Convert.ToString(drms["UM"]);
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

        private void Calculo_Load(object sender, EventArgs e)
        {
            if (UserLoginCache.Permission == Permissions.Basico)
            {

                button5.Enabled = false;
            }

            if (UserLoginCache.Permission == Permissions.Basico)
            {

                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("insert into Calculo(IDCalculo, IDCCorte, DescricaoCC, MercadoCC, IDInsumoTP, IDInsumoFD, IDInsumoES, IDInsumoR, IDInsumoTS, UMTP, UMFD, UMES, UMR, UMTS, DesTP, DesFD, DesES, DesR, DesTS, QtdTP, QtdFD, QtdES, QtdR, QtdTS, ResTP, ResFD, ResES, ResR, ResTS, ValorC)values(@IDCalculo, @IDCCorte, @DescricaoCC, @MercadoCC, @IDInsumoTP, @IDInsumoFD, @IDInsumoES, @IDInsumoR, @IDInsumoTS, @UMTP, @UMFD, @UMES, @UMR, @UMTS, @DesTP, @DesFD, @DesES, @DesR, @DesTS, @QtdTP, @QtdFD, @QtdES, @QtdR, @QtdTS, @ResTP, @ResFD, @ResES, @ResR, @ResTS, @ValorC)", sql);
            command.Parameters.Add("@IDCalculo", SqlDbType.Int).Value = textIDCalculo.Text;
            command.Parameters.Add("@IDCCorte", SqlDbType.Int).Value = textIDCC.Text;
            command.Parameters.Add("@IDInsumoTP", SqlDbType.Int).Value = textIDTP.Text;
            command.Parameters.Add("@IDInsumoFD", SqlDbType.Int).Value = textIDFD.Text;
            command.Parameters.Add("@IDInsumoES", SqlDbType.Int).Value = textIDES.Text;
            command.Parameters.Add("@IDInsumoR", SqlDbType.Int).Value = textIDR.Text;
            command.Parameters.Add("@IDInsumoTs", SqlDbType.Int).Value = textIDTS.Text;
            command.Parameters.Add("@DescricaoCC", SqlDbType.NVarChar).Value = textDC.Text;
            command.Parameters.Add("@DesTP", SqlDbType.NVarChar).Value = textDTP.Text;
            command.Parameters.Add("@DesFD", SqlDbType.NVarChar).Value = textDFD.Text;
            command.Parameters.Add("@DesES", SqlDbType.NVarChar).Value = textDES.Text;
            command.Parameters.Add("@DesR", SqlDbType.NVarChar).Value = textDR.Text;
            command.Parameters.Add("@DesTS", SqlDbType.NVarChar).Value = textDTS.Text;
            command.Parameters.Add("@MercadoCC", SqlDbType.NVarChar).Value = textM.Text;
            command.Parameters.Add("@UMTP", SqlDbType.NVarChar).Value = textUMTP.Text;
            command.Parameters.Add("@UMFD", SqlDbType.NVarChar).Value = textUMFD.Text;
            command.Parameters.Add("@UMES", SqlDbType.NVarChar).Value = textUMES.Text;
            command.Parameters.Add("@UMR", SqlDbType.NVarChar).Value = textUMR.Text;
            command.Parameters.Add("@UMTS", SqlDbType.NVarChar).Value = textUMTS.Text;
            command.Parameters.Add("@QtdTP", SqlDbType.Float).Value = textQdTP.Text;
            command.Parameters.Add("@QtdFD", SqlDbType.Float).Value = textQdFD.Text;
            command.Parameters.Add("@QtdES", SqlDbType.Float).Value = textQdES.Text;
            command.Parameters.Add("@QtdR", SqlDbType.Float).Value = textQdR.Text;
            command.Parameters.Add("@QtdTS", SqlDbType.Float).Value = textQdTS.Text;
            command.Parameters.Add("@ResTP", SqlDbType.Float).Value = textResTP.Text;
            command.Parameters.Add("@ResFD", SqlDbType.Float).Value = textResFD.Text;
            command.Parameters.Add("@ResES", SqlDbType.Float).Value = textResES.Text;
            command.Parameters.Add("@ResR", SqlDbType.Float).Value = textResR.Text;
            command.Parameters.Add("@ResTS", SqlDbType.Float).Value = textResTS.Text;
            command.Parameters.Add("@ValorC", SqlDbType.Float).Value = textVlCal.Text;



            if (textIDCalculo.Text != "" & textIDTP.Text != "" & textIDFD.Text != "" & textIDES.Text != "" & textIDR.Text != "" & textIDTS.Text != "" & textVlCal.Text != "" & textQdTP.Text != "" & textQdFD.Text != "" & textQdES.Text != "" & textQdR.Text != "" & textQdTS.Text != "" & textIDCC.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetudado com sucesso!!!", "SISTEMA HELPTECH - CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textIDCalculo.Text = "";
                    textIDCC.Text = "";
                    textVlCal.Text = "";
                    textQdTP.Text = "";
                    textQdFD.Text = "";
                    textQdES.Text = "";
                    textQdR.Text = "";
                    textQdTS.Text = "";
                    textIDTP.Text = "";
                    textIDFD.Text = "";
                    textIDES.Text = "";
                    textIDR.Text = "";
                    textIDTS.Text = "";

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

        private void btoCalcular_Click(object sender, EventArgs e)
        {
            float numero1;
            float numero2;
            float numero3;
            float numero4;
            float numero5;
            float numero6;

            float resultado;


            numero1 = float.Parse(textVlCal.Text);
            numero2 = float.Parse(textQdTP.Text);
            numero3 = float.Parse(textQdFD.Text);
            numero4 = float.Parse(textQdES.Text);
            numero5 = float.Parse(textQdR.Text);
            numero6 = float.Parse(textQdTS.Text);


            if (operacao == 1)
            {
                resultado = numero1 * numero2;
                textResTP.Text = resultado.ToString();

                resultado = numero1 * numero3;
                textResFD.Text = resultado.ToString();

                resultado = numero1 * numero4;
                textResES.Text = resultado.ToString();

                resultado = numero1 * numero5;
                textResR.Text = resultado.ToString();

                resultado = numero1 * numero6;
                textResTS.Text = resultado.ToString();
            }

            

        }

        private void textResTP_TextChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void textResFD_TextChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void textResES_TextChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void textResR_TextChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void textResTS_TextChanged(object sender, EventArgs e)
        {
            operacao = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textIDCalculo.Clear();
            textIDCC.Clear();
            textIDTS.Clear();
            textIDR.Clear();
            textIDFD.Clear();
            textIDES.Clear();
            textUMES.Clear();
            textUMFD.Clear();
            textUMR.Clear();
            textUMTP.Clear();
            textUMTS.Clear();
            textIDTP.Clear();
            textQdES.Clear();
            textQdFD.Clear();
            textQdR.Clear();
            textQdTP.Clear();
            textQdTS.Clear();
            textDTP.Clear();
            textDC.Clear();
            textDES.Clear();
            textDFD.Clear();
            textDR.Clear();
            textDTS.Clear();
            textResES.Clear();
            textResFD.Clear();
            textResR.Clear();
            textResTP.Clear();
            textResTS.Clear();
            textM.Clear();
            textVlCal.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("update Calculo set IDCCorte=@IDCCorte, DescricaoCC=@DescricaoCC, MercadoCC=@MercadoCC, IDInsumoTP=@IDInsumoTP, IDInsumoFD=@IDInsumoFD, IDInsumoES=@IDInsumoES, IDInsumoR=@IDInsumoR, IDInsumoTS=@IDInsumoTS, UMTP=@UMTP, UMFD=@UMFD, UMES=@UMES, UMR=@UMR, UMTS=@UMTS, DesTP=@DesTP, DesFD=@DesFD, DesES=@DesES, DesR=@DesR, DesTS=@DesTS, QtdTP=@QtdTP, QtdFD=@QtdTP, QtdES=@QtdES, QtdR=@QtdR, QtdTS=@QtdTS, ResTP=@ResTP, ResFD=@ResFD, ResES=@ResES, ResR=@ResR, ResTS=@ResTS, ValorC=@ValorC where IDCalculo = @IDCalculo", sql);
            command.Parameters.Add("@IDCalculo", SqlDbType.Int).Value = textIDCalculo.Text;
            command.Parameters.Add("@IDCCorte", SqlDbType.Int).Value = textIDCC.Text;
            command.Parameters.Add("@IDInsumoTP", SqlDbType.Int).Value = textIDTP.Text;
            command.Parameters.Add("@IDInsumoFD", SqlDbType.Int).Value = textIDFD.Text;
            command.Parameters.Add("@IDInsumoES", SqlDbType.Int).Value = textIDES.Text;
            command.Parameters.Add("@IDInsumoR", SqlDbType.Int).Value = textIDR.Text;
            command.Parameters.Add("@IDInsumoTs", SqlDbType.Int).Value = textIDTS.Text;
            command.Parameters.Add("@DescricaoCC", SqlDbType.NVarChar).Value = textDC.Text;
            command.Parameters.Add("@DesTP", SqlDbType.NVarChar).Value = textDTP.Text;
            command.Parameters.Add("@DesFD", SqlDbType.NVarChar).Value = textDFD.Text;
            command.Parameters.Add("@DesES", SqlDbType.NVarChar).Value = textDES.Text;
            command.Parameters.Add("@DesR", SqlDbType.NVarChar).Value = textDR.Text;
            command.Parameters.Add("@DesTS", SqlDbType.NVarChar).Value = textDTS.Text;
            command.Parameters.Add("@MercadoCC", SqlDbType.NVarChar).Value = textM.Text;
            command.Parameters.Add("@UMTP", SqlDbType.NVarChar).Value = textUMTP.Text;
            command.Parameters.Add("@UMFD", SqlDbType.NVarChar).Value = textUMFD.Text;
            command.Parameters.Add("@UMES", SqlDbType.NVarChar).Value = textUMES.Text;
            command.Parameters.Add("@UMR", SqlDbType.NVarChar).Value = textUMR.Text;
            command.Parameters.Add("@UMTS", SqlDbType.NVarChar).Value = textUMTS.Text;
            command.Parameters.Add("@QtdTP", SqlDbType.Float).Value = textQdTP.Text;
            command.Parameters.Add("@QtdFD", SqlDbType.Float).Value = textQdFD.Text;
            command.Parameters.Add("@QtdES", SqlDbType.Float).Value = textQdES.Text;
            command.Parameters.Add("@QtdR", SqlDbType.Float).Value = textQdR.Text;
            command.Parameters.Add("@QtdTS", SqlDbType.Float).Value = textQdTS.Text;
            command.Parameters.Add("@ResTP", SqlDbType.Float).Value = textResTP.Text;
            command.Parameters.Add("@ResFD", SqlDbType.Float).Value = textResFD.Text;
            command.Parameters.Add("@ResES", SqlDbType.Float).Value = textResES.Text;
            command.Parameters.Add("@ResR", SqlDbType.Float).Value = textResR.Text;
            command.Parameters.Add("@ResTS", SqlDbType.Float).Value = textResTS.Text;
            command.Parameters.Add("@ValorC", SqlDbType.Float).Value = textVlCal.Text;

            if (textIDCalculo.Text != "" & textIDTP.Text != "" & textIDFD.Text != "" & textIDES.Text != "" & textIDR.Text != "" & textIDTS.Text != "" & textVlCal.Text != "" & textQdTP.Text != "" & textQdFD.Text != "" & textQdES.Text != "" & textQdR.Text != "" & textQdTS.Text != "" & textIDCC.Text != "")
            {
                try
                {
                    sql.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Atualizado com sucesso!!!", "SISTEMA HELPTECH - ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textIDCalculo.Text = "";
                    textIDCC.Text = "";
                    textVlCal.Text = "";
                    textQdTP.Text = "";
                    textQdFD.Text = "";
                    textQdES.Text = "";
                    textQdR.Text = "";
                    textQdTS.Text = "";
                    textIDTP.Text = "";
                    textIDFD.Text = "";
                    textIDES.Text = "";
                    textIDR.Text = "";
                    textIDTS.Text = "";
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

        private void btoPesIDcal_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Server=DESKTOP-SB0SVF0\\SQLEXPRESS;DataBase= MyCompany; integrated security= true");
            SqlCommand command = new SqlCommand("select * from Calculo where IDCalculo=@IDCalculo", sql);
            command.Parameters.Add("@IDCalculo", SqlDbType.Int).Value = textIDCalculo.Text;

            try
            {
                sql.Open();
                SqlDataReader drms = command.ExecuteReader();
                if (drms.HasRows == false)
                {
                    throw new Exception("IDCalculo não encontrado!!!");
                }
                drms.Read();
                textIDCalculo.Text = Convert.ToString(drms["IDCalculo"]);
                textIDCC.Text = Convert.ToString(drms["IDCCorte"]);
                textIDTP.Text = Convert.ToString(drms["IDInsumoTP"]);
                textIDFD.Text = Convert.ToString(drms["IDInsumoFD"]);
                textIDES.Text = Convert.ToString(drms["IDInsumoES"]);
                textIDR.Text = Convert.ToString(drms["IDInsumoR"]);
                textIDTS.Text = Convert.ToString(drms["IDInsumoTS"]);
                textDC.Text = Convert.ToString(drms["DescricaoCC"]);
                textDTP.Text = Convert.ToString(drms["DesTP"]);
                textDFD.Text = Convert.ToString(drms["DesFD"]);
                textDES.Text = Convert.ToString(drms["DesES"]);
                textDR.Text = Convert.ToString(drms["DesR"]);
                textDTS.Text = Convert.ToString(drms["DesTS"]);
                textM.Text = Convert.ToString(drms["MercadoCC"]);
                textUMTP.Text = Convert.ToString(drms["UMTP"]);
                textUMFD.Text = Convert.ToString(drms["UMFD"]);
                textUMES.Text = Convert.ToString(drms["UMES"]);
                textUMR.Text = Convert.ToString(drms["UMR"]);
                textUMTS.Text = Convert.ToString(drms["UMTS"]);
                textQdTP.Text = Convert.ToString(drms["QtdTP"]);
                textQdFD.Text = Convert.ToString(drms["QtdFD"]);
                textQdES.Text = Convert.ToString(drms["QtdES"]);
                textQdR.Text = Convert.ToString(drms["QtdR"]);
                textQdTS.Text = Convert.ToString(drms["QtdTS"]);
                textResTP.Text = Convert.ToString(drms["ResTP"]);
                textResFD.Text = Convert.ToString(drms["ResFD"]);
                textResES.Text = Convert.ToString(drms["ResES"]);
                textResR.Text = Convert.ToString(drms["ResR"]);
                textResTS.Text = Convert.ToString(drms["ResTS"]);
                textVlCal.Text = Convert.ToString(drms["ValorC"]);
                


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
            SqlCommand command = new SqlCommand("delete from Calculo where IDCalculo=@IDCalculo", sql);
            command.Parameters.Add("@IDCalculo", SqlDbType.Int).Value = textIDCalculo.Text;

            try
            {
                sql.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!!!", "SISTEMA HELPTECH - EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textIDCalculo.Text = "";
                textIDCC.Text = "";
                textIDTP.Text = "";
                textIDFD.Text = "";
                textIDES.Text = "";
                textIDR.Text = "";
                textIDTS.Text = "";
                textDC.Text = "";
                textDTP.Text = "";
                textDFD.Text = "";
                textDES.Text = "";
                textDR.Text = "";
                textDTS.Text = "";
                textM.Text = "";
                textUMTP.Text = "";
                textUMFD.Text = "";
                textUMES.Text = "";
                textUMR.Text = "";
                textUMTS.Text = "";
                textQdTP.Text = "";
                textQdFD.Text = "";
                textQdES.Text = ""; 
                textQdR.Text = "";
                textQdTS.Text = "";
                textResTP.Text = "";
                textResFD.Text = "";
                textResES.Text = "";
                textResR.Text = "";
                textResTS.Text = "";
                textVlCal.Text = "";
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



        private void button6_Click(object sender, EventArgs e)
        {
            Relatorio form = new Relatorio();
            form.ShowDialog();
        }
    }
}