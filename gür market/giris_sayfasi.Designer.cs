
namespace gür_market
{
    partial class giris_sayfasi
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kullanıcıAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sifremi_unuttum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(378, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(120, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "YÖNETİCİ GİRİŞ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // kullanıcıAdi
            // 
            this.kullanıcıAdi.BackColor = System.Drawing.Color.Transparent;
            this.kullanıcıAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdi.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kullanıcıAdi.Location = new System.Drawing.Point(33, 109);
            this.kullanıcıAdi.Name = "kullanıcıAdi";
            this.kullanıcıAdi.Size = new System.Drawing.Size(89, 21);
            this.kullanıcıAdi.TabIndex = 2;
            this.kullanıcıAdi.Text = "kullanıcı adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(33, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "şifre :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(36, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 1);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(36, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 1);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(120, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 15);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(120, 160);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 15);
            this.textBox2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::gür_market.Properties.Resources.ip;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(79, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "giriş";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::gür_market.Properties.Resources.ip;
            this.button3.Location = new System.Drawing.Point(256, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "temizle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(325, 159);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(33, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "şifre :";
            // 
            // txtparola
            // 
            this.txtparola.BackColor = System.Drawing.Color.DarkGray;
            this.txtparola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtparola.Location = new System.Drawing.Point(120, 160);
            this.txtparola.Multiline = true;
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(190, 15);
            this.txtparola.TabIndex = 7;
            this.txtparola.TextChanged += new System.EventHandler(this.txtparola_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::gür_market.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(22, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // sifremi_unuttum
            // 
            this.sifremi_unuttum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sifremi_unuttum.Image = global::gür_market.Properties.Resources.ip;
            this.sifremi_unuttum.Location = new System.Drawing.Point(146, 227);
            this.sifremi_unuttum.Name = "sifremi_unuttum";
            this.sifremi_unuttum.Size = new System.Drawing.Size(126, 35);
            this.sifremi_unuttum.TabIndex = 12;
            this.sifremi_unuttum.Text = "şifremi unuttum";
            this.sifremi_unuttum.UseVisualStyleBackColor = true;
            this.sifremi_unuttum.Click += new System.EventHandler(this.sifremi_unuttum_Click);
            // 
            // giris_sayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(434, 282);
            this.Controls.Add(this.sifremi_unuttum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kullanıcıAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "giris_sayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Load += new System.EventHandler(this.giris_sayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kullanıcıAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button sifremi_unuttum;
    }
}

