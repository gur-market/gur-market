
namespace gür_market
{
    partial class parasal_durum
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.borç = new System.Windows.Forms.Label();
            this.alacak = new System.Windows.Forms.Label();
            this.kasa_miktari = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gurMarketDBDataSet3 = new gür_market.gurMarketDBDataSet3();
            this.kasasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kasasTableAdapter = new gür_market.gurMarketDBDataSet3TableAdapters.KasasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(666, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 51);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(136, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "PARASAL DURUM";
            // 
            // borç
            // 
            this.borç.AutoSize = true;
            this.borç.BackColor = System.Drawing.Color.Transparent;
            this.borç.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.borç.Location = new System.Drawing.Point(79, 120);
            this.borç.Name = "borç";
            this.borç.Size = new System.Drawing.Size(134, 25);
            this.borç.TabIndex = 19;
            this.borç.Text = "Toplam Borç :";
            // 
            // alacak
            // 
            this.alacak.AutoSize = true;
            this.alacak.BackColor = System.Drawing.Color.Transparent;
            this.alacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alacak.Location = new System.Drawing.Point(79, 176);
            this.alacak.Name = "alacak";
            this.alacak.Size = new System.Drawing.Size(216, 25);
            this.alacak.TabIndex = 20;
            this.alacak.Text = "Toplam Alacak Miktarı :";
            // 
            // kasa_miktari
            // 
            this.kasa_miktari.AutoSize = true;
            this.kasa_miktari.BackColor = System.Drawing.Color.Transparent;
            this.kasa_miktari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasa_miktari.Location = new System.Drawing.Point(80, 286);
            this.kasa_miktari.Name = "kasa_miktari";
            this.kasa_miktari.Size = new System.Drawing.Size(200, 25);
            this.kasa_miktari.TabIndex = 21;
            this.kasa_miktari.Text = "Mevcut Kasa Miktarı :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.kasasBindingSource, "ToplamBorc", true));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasasBindingSource, "ToplamBorc", true));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(357, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 30);
            this.textBox1.TabIndex = 22;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasasBindingSource, "ToplamAlacakMiktari", true));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(357, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 30);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasasBindingSource, "MevcutKasaMiktari", true));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(357, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 30);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kasasBindingSource, "PotansiyelKarZarar", true));
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(357, 226);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(146, 30);
            this.textBox5.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(79, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Potansiyel Kar/Zarar :";
            // 
            // gurMarketDBDataSet3
            // 
            this.gurMarketDBDataSet3.DataSetName = "gurMarketDBDataSet3";
            this.gurMarketDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kasasBindingSource
            // 
            this.kasasBindingSource.DataMember = "Kasas";
            this.kasasBindingSource.DataSource = this.gurMarketDBDataSet3;
            // 
            // kasasTableAdapter
            // 
            this.kasasTableAdapter.ClearBeforeFill = true;
            // 
            // parasal_durum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(725, 390);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.kasa_miktari);
            this.Controls.Add(this.alacak);
            this.Controls.Add(this.borç);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parasal_durum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "parasal_durum";
            this.Load += new System.EventHandler(this.parasal_durum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label borç;
        private System.Windows.Forms.Label alacak;
        private System.Windows.Forms.Label kasa_miktari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private gurMarketDBDataSet3 gurMarketDBDataSet3;
        private System.Windows.Forms.BindingSource kasasBindingSource;
        private gurMarketDBDataSet3TableAdapters.KasasTableAdapter kasasTableAdapter;
    }
}