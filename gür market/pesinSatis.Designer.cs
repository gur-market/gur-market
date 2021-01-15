
namespace gür_market
{
    partial class pesinSatis
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pesinSatisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet4 = new gür_market.gurMarketDBDataSet4();
            this.pesinSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veresiyeSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet = new gür_market.gurMarketDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.sepet = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.temizle = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sat = new System.Windows.Forms.Button();
            this.urun_sil = new System.Windows.Forms.Button();
            this.veresiyeSatisTableAdapter = new gür_market.gurMarketDBDataSetTableAdapters.VeresiyeSatisTableAdapter();
            this.pesinSatisTableAdapter = new gür_market.gurMarketDBDataSet4TableAdapters.PesinSatisTableAdapter();
            this.satisIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesinSatisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesinSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satisIdDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.birimAdetDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.toplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pesinSatisBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 466);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pesinSatisBindingSource1
            // 
            this.pesinSatisBindingSource1.DataMember = "PesinSatis";
            this.pesinSatisBindingSource1.DataSource = this.gurMarketDBDataSet4BindingSource;
            // 
            // gurMarketDBDataSet4BindingSource
            // 
            this.gurMarketDBDataSet4BindingSource.DataSource = this.gurMarketDBDataSet4;
            this.gurMarketDBDataSet4BindingSource.Position = 0;
            // 
            // gurMarketDBDataSet4
            // 
            this.gurMarketDBDataSet4.DataSetName = "gurMarketDBDataSet4";
            this.gurMarketDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesinSatisBindingSource
            // 
            this.pesinSatisBindingSource.DataMember = "PesinSatis";
            this.pesinSatisBindingSource.DataSource = this.gurMarketDBDataSet4;
            // 
            // veresiyeSatisBindingSource
            // 
            this.veresiyeSatisBindingSource.DataMember = "VeresiyeSatis";
            this.veresiyeSatisBindingSource.DataSource = this.gurMarketDBDataSet;
            // 
            // gurMarketDBDataSet
            // 
            this.gurMarketDBDataSet.DataSetName = "gurMarketDBDataSet";
            this.gurMarketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(148, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEŞİN SATIŞ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barkod No :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Birim Adet :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Toplam Fiyat :";
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(581, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 51);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button9_Click);
            // 
            // sepet
            // 
            this.sepet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sepet.Image = global::gür_market.Properties.Resources.ip;
            this.sepet.Location = new System.Drawing.Point(33, 282);
            this.sepet.Name = "sepet";
            this.sepet.Size = new System.Drawing.Size(113, 34);
            this.sepet.TabIndex = 16;
            this.sepet.Text = "Sepete Ekle";
            this.sepet.UseVisualStyleBackColor = true;
            this.sepet.Click += new System.EventHandler(this.satis_Click);
            // 
            // güncelle
            // 
            this.güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncelle.Image = global::gür_market.Properties.Resources.ip;
            this.güncelle.Location = new System.Drawing.Point(170, 282);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(106, 34);
            this.güncelle.TabIndex = 17;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            // 
            // temizle
            // 
            this.temizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temizle.Image = global::gür_market.Properties.Resources.ip;
            this.temizle.Location = new System.Drawing.Point(304, 282);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(92, 34);
            this.temizle.TabIndex = 18;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(213, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 27);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(213, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 27);
            this.textBox2.TabIndex = 20;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(213, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 27);
            this.textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(213, 208);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 27);
            this.textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(213, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 27);
            this.textBox5.TabIndex = 23;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sat);
            this.groupBox1.Controls.Add(this.urun_sil);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.güncelle);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.sepet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(35, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 380);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "satış ekranı";
            // 
            // sat
            // 
            this.sat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sat.Image = global::gür_market.Properties.Resources.ip;
            this.sat.Location = new System.Drawing.Point(242, 340);
            this.sat.Name = "sat";
            this.sat.Size = new System.Drawing.Size(92, 34);
            this.sat.TabIndex = 25;
            this.sat.Text = "SAT";
            this.sat.UseVisualStyleBackColor = true;
            this.sat.Click += new System.EventHandler(this.sat_Click);
            // 
            // urun_sil
            // 
            this.urun_sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.urun_sil.Image = global::gür_market.Properties.Resources.ip;
            this.urun_sil.Location = new System.Drawing.Point(426, 282);
            this.urun_sil.Name = "urun_sil";
            this.urun_sil.Size = new System.Drawing.Size(92, 34);
            this.urun_sil.TabIndex = 24;
            this.urun_sil.Text = "Ürün Sil";
            this.urun_sil.UseVisualStyleBackColor = true;
            this.urun_sil.Click += new System.EventHandler(this.urun_sil_Click);
            // 
            // veresiyeSatisTableAdapter
            // 
            this.veresiyeSatisTableAdapter.ClearBeforeFill = true;
            // 
            // pesinSatisTableAdapter
            // 
            this.pesinSatisTableAdapter.ClearBeforeFill = true;
            // 
            // satisIdDataGridViewTextBoxColumn
            // 
            this.satisIdDataGridViewTextBoxColumn.DataPropertyName = "SatisId";
            this.satisIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.satisIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.satisIdDataGridViewTextBoxColumn.Name = "satisIdDataGridViewTextBoxColumn";
            this.satisIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.satisIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // barkodNoDataGridViewTextBoxColumn
            // 
            this.barkodNoDataGridViewTextBoxColumn.DataPropertyName = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.HeaderText = "BarkodNo";
            this.barkodNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barkodNoDataGridViewTextBoxColumn.Name = "barkodNoDataGridViewTextBoxColumn";
            this.barkodNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimAdetDataGridViewTextBoxColumn
            // 
            this.birimAdetDataGridViewTextBoxColumn.DataPropertyName = "BirimAdet";
            this.birimAdetDataGridViewTextBoxColumn.HeaderText = "BirimAdet";
            this.birimAdetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimAdetDataGridViewTextBoxColumn.Name = "birimAdetDataGridViewTextBoxColumn";
            this.birimAdetDataGridViewTextBoxColumn.Width = 125;
            // 
            // fiyatDataGridViewTextBoxColumn
            // 
            this.fiyatDataGridViewTextBoxColumn.DataPropertyName = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.HeaderText = "Fiyat";
            this.fiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fiyatDataGridViewTextBoxColumn.Name = "fiyatDataGridViewTextBoxColumn";
            this.fiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamDataGridViewTextBoxColumn
            // 
            this.toplamDataGridViewTextBoxColumn.DataPropertyName = "Toplam";
            this.toplamDataGridViewTextBoxColumn.HeaderText = "Toplam";
            this.toplamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamDataGridViewTextBoxColumn.Name = "toplamDataGridViewTextBoxColumn";
            this.toplamDataGridViewTextBoxColumn.Width = 125;
            // 
            // pesinSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(642, 682);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pesinSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pesinSatis";
            this.Load += new System.EventHandler(this.pesinSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesinSatisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesinSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sepet;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button urun_sil;
        private System.Windows.Forms.Button sat;
        private gurMarketDBDataSet gurMarketDBDataSet;
        private System.Windows.Forms.BindingSource veresiyeSatisBindingSource;
        private gurMarketDBDataSetTableAdapters.VeresiyeSatisTableAdapter veresiyeSatisTableAdapter;
        private gurMarketDBDataSet4 gurMarketDBDataSet4;
        private System.Windows.Forms.BindingSource pesinSatisBindingSource;
        private gurMarketDBDataSet4TableAdapters.PesinSatisTableAdapter pesinSatisTableAdapter;
        private System.Windows.Forms.BindingSource pesinSatisBindingSource1;
        private System.Windows.Forms.BindingSource gurMarketDBDataSet4BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn satisIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamDataGridViewTextBoxColumn;
    }
}