
namespace gür_market
{
    partial class alacak_verecek
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.veresiye = new System.Windows.Forms.Button();
            this.pesin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::gür_market.Properties.Resources.depositphotos_6489061_stock_photo_sad_symbol_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(234, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gür_market.Properties.Resources.png_transparent_smiley_emoticon_smiley_miscellaneous_desktop_wallpaper_world_smile_day_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(51, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // veresiye
            // 
            this.veresiye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veresiye.Image = global::gür_market.Properties.Resources.ip;
            this.veresiye.Location = new System.Drawing.Point(42, 50);
            this.veresiye.Name = "veresiye";
            this.veresiye.Size = new System.Drawing.Size(101, 23);
            this.veresiye.TabIndex = 3;
            this.veresiye.Text = "MÜŞTERİ";
            this.veresiye.UseVisualStyleBackColor = true;
            this.veresiye.Click += new System.EventHandler(this.veresiye_Click);
            // 
            // pesin
            // 
            this.pesin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesin.Image = global::gür_market.Properties.Resources.ip;
            this.pesin.Location = new System.Drawing.Point(220, 50);
            this.pesin.Name = "pesin";
            this.pesin.Size = new System.Drawing.Size(106, 23);
            this.pesin.TabIndex = 2;
            this.pesin.Text = "TEDARİKÇİ";
            this.pesin.UseVisualStyleBackColor = true;
            this.pesin.Click += new System.EventHandler(this.pesin_Click);
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(362, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alacak_verecek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 101);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.veresiye);
            this.Controls.Add(this.pesin);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "alacak_verecek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pesin;
        private System.Windows.Forms.Button veresiye;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}