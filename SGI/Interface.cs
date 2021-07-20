using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;

namespace SGI
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            hideSubMenu();
        }
    //Ajuste SubMenu
        private void hideSubMenu()
        {
            SubmenuCadastro.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //final código Submenu

        // Ajuste Menu poder se mover

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Final código

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
           
        }


        

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {
           
        }





        //Configuração Menu



        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
           // if (MessageBox.Show("Você tem certeza que deseja abrir esta tela?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCentro.Controls.Add(childForm);
            panelCentro.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            {
                


        }
                        }

        //final código


        private void btoFechar_Click(object sender, EventArgs e)

        {
            if (MessageBox.Show("Você tem certeza que deseja fazer isto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit(); 
        }

        int LX, LY;
        private void btoMax_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btoMax.Visible = false;
            btoRes.Visible = true;
        }

        private void btoRes_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX, LY);
            btoRes.Visible = false;
            btoMax.Visible = true;
        }

        private void btoMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btoCadastro_Click(object sender, EventArgs e)
        {
            showSubMenu(SubmenuCadastro);
            
        }

        private void btoptinsumo_Click(object sender, EventArgs e)
        {
            SubmenuCadastro.Visible = false;

            openChildFormInPanel(new CadastroInsumos());
        }

        private void btoptmercado_Click(object sender, EventArgs e)
        {
            SubmenuCadastro.Visible = false;

            openChildFormInPanel(new CadastroMercado());
        }

        private void btoptcorte_Click(object sender, EventArgs e)
        {
            
            SubmenuCadastro.Visible = false;

            openChildFormInPanel(new CadastroCortes());
        }

        private void btoptusuario_Click(object sender, EventArgs e)
        {
            SubmenuCadastro.Visible = false;
   
         openChildFormInPanel(new CadastroUsuario());
        }

        private void btoSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja deslogar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btoPesquisa_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Pesquisa());
        }

        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelInterface.Region = region;
            this.Invalidate();
        }

       
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        

        private void btoCalculo_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TCalculo());
        }

        private void MenuVertical_Paint_1(object sender, PaintEventArgs e)
        {
            LoadUserData();

            if (UserLoginCache.Permission == Permissions.Basico)
            {
                
                btoCadastro.Enabled = false;
            }
        }

        private void LoadUserData()
        {
            lblName.Text = UserLoginCache.FirstName;
            lblSetor.Text = UserLoginCache.Setor;
            lblPermission.Text = UserLoginCache.Permission;

        }

        private void home_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deja realmente voltar a tela inicial?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                openChildFormInPanel(new Inicio());
        }

        

    }
}
