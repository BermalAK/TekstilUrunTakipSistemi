namespace ModelTakipUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblParola = new System.Windows.Forms.Label();
            this.ProgramAdi = new System.Windows.Forms.Label();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.pnlKullanici = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKucult = new System.Windows.Forms.Button();
            this.BeniHatirla = new System.Windows.Forms.CheckBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.pctKullanici = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctKontrol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Black;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(40, 340);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(232, 32);
            this.btnGiris.TabIndex = 25;
            this.btnGiris.Text = "GİRİS";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParola.ForeColor = System.Drawing.Color.White;
            this.lblParola.Location = new System.Drawing.Point(92, 307);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(131, 18);
            this.lblParola.TabIndex = 24;
            this.lblParola.Text = "Parolamı Unuttum ";
            this.lblParola.Click += new System.EventHandler(this.lblParola_Click);
            // 
            // ProgramAdi
            // 
            this.ProgramAdi.AutoSize = true;
            this.ProgramAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProgramAdi.ForeColor = System.Drawing.Color.White;
            this.ProgramAdi.Location = new System.Drawing.Point(8, 11);
            this.ProgramAdi.Name = "ProgramAdi";
            this.ProgramAdi.Size = new System.Drawing.Size(202, 24);
            this.ProgramAdi.TabIndex = 23;
            this.ProgramAdi.Text = "Ürün Takip Giriş Ekranı";
            this.ProgramAdi.Click += new System.EventHandler(this.ProgramAdi_Click);
            this.ProgramAdi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgramAdi_MouseDown);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Location = new System.Drawing.Point(58, 267);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(242, 1);
            this.pnlPassword.TabIndex = 22;
            // 
            // pnlKullanici
            // 
            this.pnlKullanici.BackColor = System.Drawing.Color.White;
            this.pnlKullanici.ForeColor = System.Drawing.Color.Black;
            this.pnlKullanici.Location = new System.Drawing.Point(57, 220);
            this.pnlKullanici.Name = "pnlKullanici";
            this.pnlKullanici.Size = new System.Drawing.Size(243, 1);
            this.pnlKullanici.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(57, 241);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(242, 20);
            this.txtPassword.TabIndex = 20;
            this.txtPassword.Text = "Parola";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.MouseLeave += new System.EventHandler(this.txtPassword_MouseLeave);
            // 
            // txtKullanici
            // 
            this.txtKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtKullanici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.ForeColor = System.Drawing.Color.White;
            this.txtKullanici.Location = new System.Drawing.Point(58, 194);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(243, 20);
            this.txtKullanici.TabIndex = 19;
            this.txtKullanici.Text = "Kullanıcı Adı";
            this.txtKullanici.TextChanged += new System.EventHandler(this.txtKullanici_TextChanged);
            this.txtKullanici.Enter += new System.EventHandler(this.txtKullanici_Enter);
            this.txtKullanici.MouseLeave += new System.EventHandler(this.txtKullanici_MouseLeave);
            // 
            // btnKapat
            // 
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(303, 7);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 30);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKucult
            // 
            this.btnKucult.FlatAppearance.BorderSize = 0;
            this.btnKucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKucult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKucult.ForeColor = System.Drawing.Color.White;
            this.btnKucult.Location = new System.Drawing.Point(268, 8);
            this.btnKucult.Name = "btnKucult";
            this.btnKucult.Size = new System.Drawing.Size(28, 30);
            this.btnKucult.TabIndex = 14;
            this.btnKucult.Text = "-";
            this.btnKucult.UseVisualStyleBackColor = true;
            this.btnKucult.Click += new System.EventHandler(this.btnKucult_Click);
            // 
            // BeniHatirla
            // 
            this.BeniHatirla.AutoSize = true;
            this.BeniHatirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BeniHatirla.ForeColor = System.Drawing.Color.White;
            this.BeniHatirla.Location = new System.Drawing.Point(27, 276);
            this.BeniHatirla.Name = "BeniHatirla";
            this.BeniHatirla.Size = new System.Drawing.Size(105, 22);
            this.BeniHatirla.TabIndex = 26;
            this.BeniHatirla.Text = "Beni Hatırla";
            this.BeniHatirla.UseVisualStyleBackColor = false;
            // 
            // pctPassword
            // 
            this.pctPassword.BackColor = System.Drawing.Color.Transparent;
            this.pctPassword.Image = ((System.Drawing.Image)(resources.GetObject("pctPassword.Image")));
            this.pctPassword.Location = new System.Drawing.Point(27, 242);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(25, 27);
            this.pctPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctPassword.TabIndex = 18;
            this.pctPassword.TabStop = false;
            // 
            // pctKullanici
            // 
            this.pctKullanici.BackColor = System.Drawing.Color.Transparent;
            this.pctKullanici.Image = ((System.Drawing.Image)(resources.GetObject("pctKullanici.Image")));
            this.pctKullanici.Location = new System.Drawing.Point(27, 194);
            this.pctKullanici.Name = "pctKullanici";
            this.pctKullanici.Size = new System.Drawing.Size(25, 27);
            this.pctKullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctKullanici.TabIndex = 17;
            this.pctKullanici.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(120, 68);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(98, 94);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 16;
            this.pctLogo.TabStop = false;
            // 
            // pctKontrol
            // 
            this.pctKontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.pctKontrol.Location = new System.Drawing.Point(0, 0);
            this.pctKontrol.Name = "pctKontrol";
            this.pctKontrol.Size = new System.Drawing.Size(332, 45);
            this.pctKontrol.TabIndex = 13;
            this.pctKontrol.TabStop = false;
            this.pctKontrol.Click += new System.EventHandler(this.pctKontrol_Click);
            this.pctKontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pctKontrol_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(332, 403);
            this.Controls.Add(this.BeniHatirla);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.ProgramAdi);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlKullanici);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.pctPassword);
            this.Controls.Add(this.pctKullanici);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKucult);
            this.Controls.Add(this.pctKontrol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label ProgramAdi;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Panel pnlKullanici;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.PictureBox pctKullanici;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKucult;
        private System.Windows.Forms.PictureBox pctKontrol;
        private System.Windows.Forms.CheckBox BeniHatirla;
    }
}

