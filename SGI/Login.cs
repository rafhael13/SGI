using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using Common.Cache;

namespace SGI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUÁRIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.White;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUÁRIO";
                txtuser.ForeColor = Color.WhiteSmoke;
            }

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "SENHA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "SENHA";
                txtpass.ForeColor = Color.WhiteSmoke;
                txtpass.UseSystemPasswordChar = false;
            }

        }

        private void btofecharlogin_Click(object sender, EventArgs e)
        {
            Application.Exit();        }

        private void btominlogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btologin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text != "USUÁRIO")
            {
                if (txtpass.Text != "SENHA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text,txtpass.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        Bemvindo bemvindo = new Bemvindo();
                        bemvindo.ShowDialog();
                        Interface mainMenu = new Interface();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        
                    }

                    else
                    {
                        msgError("Usuário ou Senha Incorreto!!!\nPor favor, tentar novamente");
                        txtpass.Clear();
                        txtuser.Clear();
                        txtuser.Focus();
                    }
                }

                else msgError("Por favor digite uma senha");
            }

            else msgError("Por favor digite um usuário");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = msg;
            lblErrorMessage.Visible = true;
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "SENHA";
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUÁRIO";
            lblErrorMessage.Visible = false;
            this.Show();

        }

    }


}
