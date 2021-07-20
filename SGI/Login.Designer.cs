namespace SGI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btologin = new System.Windows.Forms.Button();
            this.btofecharlogin = new System.Windows.Forms.PictureBox();
            this.btominlogin = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btofecharlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btominlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 330);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 87);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(280, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 317;
            this.lineShape2.X2 = 671;
            this.lineShape2.Y1 = 164;
            this.lineShape2.Y2 = 164;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 317;
            this.lineShape1.X2 = 670;
            this.lineShape1.Y1 = 116;
            this.lineShape1.Y2 = 116;
            // 
            // txtuser
            // 
            this.txtuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(289, 79);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(409, 25);
            this.txtuser.TabIndex = 1;
            this.txtuser.Text = "USUÁRIO";
            this.txtuser.Enter += new System.EventHandler(this.txtuser_Enter);
            this.txtuser.Leave += new System.EventHandler(this.txtuser_Leave);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(289, 136);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(409, 25);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "SENHA";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btologin
            // 
            this.btologin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btologin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btologin.FlatAppearance.BorderSize = 0;
            this.btologin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btologin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btologin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btologin.ForeColor = System.Drawing.Color.White;
            this.btologin.Location = new System.Drawing.Point(317, 253);
            this.btologin.Name = "btologin";
            this.btologin.Size = new System.Drawing.Size(409, 40);
            this.btologin.TabIndex = 0;
            this.btologin.Text = "ENTRAR";
            this.btologin.UseVisualStyleBackColor = false;
            this.btologin.Click += new System.EventHandler(this.btologin_Click);
            // 
            // btofecharlogin
            // 
            this.btofecharlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btofecharlogin.Image = ((System.Drawing.Image)(resources.GetObject("btofecharlogin.Image")));
            this.btofecharlogin.Location = new System.Drawing.Point(752, 3);
            this.btofecharlogin.Name = "btofecharlogin";
            this.btofecharlogin.Size = new System.Drawing.Size(23, 20);
            this.btofecharlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btofecharlogin.TabIndex = 6;
            this.btofecharlogin.TabStop = false;
            this.btofecharlogin.Click += new System.EventHandler(this.btofecharlogin_Click);
            // 
            // btominlogin
            // 
            this.btominlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btominlogin.Image = ((System.Drawing.Image)(resources.GetObject("btominlogin.Image")));
            this.btominlogin.Location = new System.Drawing.Point(723, 3);
            this.btominlogin.Name = "btominlogin";
            this.btominlogin.Size = new System.Drawing.Size(23, 20);
            this.btominlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btominlogin.TabIndex = 7;
            this.btominlogin.TabStop = false;
            this.btominlogin.Click += new System.EventHandler(this.btominlogin_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Orange;
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblErrorMessage.Location = new System.Drawing.Point(313, 187);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(179, 23);
            this.lblErrorMessage.TabIndex = 9;
            this.lblErrorMessage.Text = "Mensagem de Erro";
            this.lblErrorMessage.Visible = false;
            this.lblErrorMessage.Click += new System.EventHandler(this.lblErrorMessage_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btominlogin);
            this.Controls.Add(this.btofecharlogin);
            this.Controls.Add(this.btologin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btofecharlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btominlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btologin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btofecharlogin;
        private System.Windows.Forms.PictureBox btominlogin;
        private System.Windows.Forms.Label lblErrorMessage;
    }
}