namespace odev7
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.cinsiyetbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.kaydetbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.soyad = new Guna.UI2.WinForms.Guna2TextBox();
            this.ad = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cinsiyetbox);
            this.panel.Controls.Add(this.kaydetbtn);
            this.panel.Controls.Add(this.soyad);
            this.panel.Controls.Add(this.ad);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.Turquoise;
            this.panel.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(441, 637);
            this.panel.TabIndex = 0;
            // 
            // cinsiyetbox
            // 
            this.cinsiyetbox.BackColor = System.Drawing.Color.Transparent;
            this.cinsiyetbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cinsiyetbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cinsiyetbox.FocusedColor = System.Drawing.Color.Empty;
            this.cinsiyetbox.FocusedState.Parent = this.cinsiyetbox;
            this.cinsiyetbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cinsiyetbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cinsiyetbox.FormattingEnabled = true;
            this.cinsiyetbox.HoverState.Parent = this.cinsiyetbox;
            this.cinsiyetbox.ItemHeight = 30;
            this.cinsiyetbox.Items.AddRange(new object[] {
            "KADIN",
            "ERKEK"});
            this.cinsiyetbox.ItemsAppearance.Parent = this.cinsiyetbox;
            this.cinsiyetbox.Location = new System.Drawing.Point(258, 312);
            this.cinsiyetbox.Name = "cinsiyetbox";
            this.cinsiyetbox.ShadowDecoration.Parent = this.cinsiyetbox;
            this.cinsiyetbox.Size = new System.Drawing.Size(144, 36);
            this.cinsiyetbox.TabIndex = 7;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Animated = true;
            this.kaydetbtn.AutoRoundedCorners = true;
            this.kaydetbtn.BackColor = System.Drawing.Color.Transparent;
            this.kaydetbtn.BorderRadius = 15;
            this.kaydetbtn.CheckedState.Parent = this.kaydetbtn;
            this.kaydetbtn.CustomImages.Parent = this.kaydetbtn;
            this.kaydetbtn.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Bold);
            this.kaydetbtn.ForeColor = System.Drawing.Color.White;
            this.kaydetbtn.HoverState.Parent = this.kaydetbtn;
            this.kaydetbtn.Location = new System.Drawing.Point(264, 354);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.ShadowDecoration.Parent = this.kaydetbtn;
            this.kaydetbtn.Size = new System.Drawing.Size(126, 33);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "KAYDET";
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // soyad
            // 
            this.soyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soyad.DefaultText = "Soyisim Giriniz";
            this.soyad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soyad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soyad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soyad.DisabledState.Parent = this.soyad;
            this.soyad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soyad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soyad.FocusedState.Parent = this.soyad;
            this.soyad.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Bold);
            this.soyad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soyad.HoverState.Parent = this.soyad;
            this.soyad.Location = new System.Drawing.Point(258, 236);
            this.soyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.soyad.Name = "soyad";
            this.soyad.PasswordChar = '\0';
            this.soyad.PlaceholderText = "";
            this.soyad.SelectedText = "";
            this.soyad.SelectionStart = 15;
            this.soyad.ShadowDecoration.Parent = this.soyad;
            this.soyad.Size = new System.Drawing.Size(144, 36);
            this.soyad.TabIndex = 4;
            this.soyad.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // ad
            // 
            this.ad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ad.DefaultText = "İsim Giriniz";
            this.ad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad.DisabledState.Parent = this.ad;
            this.ad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ad.FocusedState.Parent = this.ad;
            this.ad.Font = new System.Drawing.Font("Exo 2", 9.749999F, System.Drawing.FontStyle.Bold);
            this.ad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ad.HoverState.Parent = this.ad;
            this.ad.Location = new System.Drawing.Point(258, 175);
            this.ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ad.Name = "ad";
            this.ad.PasswordChar = '\0';
            this.ad.PlaceholderText = "";
            this.ad.SelectedText = "";
            this.ad.SelectionStart = 12;
            this.ad.ShadowDecoration.Parent = this.ad;
            this.ad.Size = new System.Drawing.Size(144, 36);
            this.ad.TabIndex = 3;
            this.ad.TextOffset = new System.Drawing.Point(0, -2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 637);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2GradientPanel panel;
        public Guna.UI2.WinForms.Guna2GradientButton kaydetbtn;
        public Guna.UI2.WinForms.Guna2TextBox soyad;
        public Guna.UI2.WinForms.Guna2TextBox ad;
        public Guna.UI2.WinForms.Guna2ComboBox cinsiyetbox;
        public Guna.UI.WinForms.GunaElipse gunaElipse1;
    }
}

