
namespace gür_market
{
    partial class veresiyeSatis
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
            this.temizle = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.satis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.unit = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.barkodNo = new System.Windows.Forms.TextBox();
            this.musteriPhoneNumber = new System.Windows.Forms.TextBox();
            this.musteriName = new System.Windows.Forms.TextBox();
            this.musteriTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veresiyeSatisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet = new gür_market.gurMarketDBDataSet();
            this.veresiyeSatisTableAdapter = new gür_market.gurMarketDBDataSetTableAdapters.VeresiyeSatisTableAdapter();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeSatisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(581, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 50);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(99, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "VERESİYE SATIŞ";
            // 
            // temizle
            // 
            this.temizle.Image = global::gür_market.Properties.Resources.ip;
            this.temizle.Location = new System.Drawing.Point(324, 433);
            this.temizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(103, 34);
            this.temizle.TabIndex = 19;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // güncelle
            // 
            this.güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncelle.Image = global::gür_market.Properties.Resources.ip;
            this.güncelle.Location = new System.Drawing.Point(37, 433);
            this.güncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(117, 34);
            this.güncelle.TabIndex = 18;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // satis
            // 
            this.satis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.satis.Image = global::gür_market.Properties.Resources.ip;
            this.satis.Location = new System.Drawing.Point(193, 433);
            this.satis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(92, 34);
            this.satis.TabIndex = 17;
            this.satis.Text = "Satış yap";
            this.satis.UseVisualStyleBackColor = true;
            this.satis.Click += new System.EventHandler(this.satis_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Müşteri Tc :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Müşteri Ad Soyad :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tel :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tarih-Saat :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.totalPrice);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.unit);
            this.groupBox1.Controls.Add(this.productname);
            this.groupBox1.Controls.Add(this.barkodNo);
            this.groupBox1.Controls.Add(this.musteriPhoneNumber);
            this.groupBox1.Controls.Add(this.musteriName);
            this.groupBox1.Controls.Add(this.musteriTC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.satis);
            this.groupBox1.Controls.Add(this.güncelle);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(63, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(523, 498);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veresiye Satış Ekranı";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(213, 158);
            this.tarih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 30);
            this.tarih.TabIndex = 38;
            // 
            // totalPrice
            // 
            this.totalPrice.BackColor = System.Drawing.SystemColors.Info;
            this.totalPrice.Location = new System.Drawing.Point(212, 338);
            this.totalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(201, 30);
            this.totalPrice.TabIndex = 37;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Info;
            this.price.Location = new System.Drawing.Point(212, 303);
            this.price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(201, 30);
            this.price.TabIndex = 36;
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.SystemColors.Info;
            this.unit.Location = new System.Drawing.Point(212, 267);
            this.unit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(201, 30);
            this.unit.TabIndex = 35;
            // 
            // productname
            // 
            this.productname.BackColor = System.Drawing.SystemColors.Info;
            this.productname.Location = new System.Drawing.Point(212, 231);
            this.productname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(201, 30);
            this.productname.TabIndex = 34;
            this.productname.UseWaitCursor = true;
            // 
            // barkodNo
            // 
            this.barkodNo.BackColor = System.Drawing.SystemColors.Info;
            this.barkodNo.Location = new System.Drawing.Point(212, 194);
            this.barkodNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barkodNo.Name = "barkodNo";
            this.barkodNo.Size = new System.Drawing.Size(201, 30);
            this.barkodNo.TabIndex = 33;
            // 
            // musteriPhoneNumber
            // 
            this.musteriPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.musteriPhoneNumber.Location = new System.Drawing.Point(212, 119);
            this.musteriPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musteriPhoneNumber.Name = "musteriPhoneNumber";
            this.musteriPhoneNumber.Size = new System.Drawing.Size(201, 30);
            this.musteriPhoneNumber.TabIndex = 31;
            // 
            // musteriName
            // 
            this.musteriName.BackColor = System.Drawing.SystemColors.Info;
            this.musteriName.Location = new System.Drawing.Point(212, 82);
            this.musteriName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musteriName.Name = "musteriName";
            this.musteriName.Size = new System.Drawing.Size(201, 30);
            this.musteriName.TabIndex = 30;
            // 
            // musteriTC
            // 
            this.musteriTC.BackColor = System.Drawing.SystemColors.Info;
            this.musteriTC.Location = new System.Drawing.Point(212, 47);
            this.musteriTC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musteriTC.Name = "musteriTC";
            this.musteriTC.Size = new System.Drawing.Size(201, 30);
            this.musteriTC.TabIndex = 29;
            this.musteriTC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(35, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Barkod No :";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ürün Adı :";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(35, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 34);
            this.label8.TabIndex = 26;
            this.label8.Text = "Birim Adet :";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(39, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 34);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fiyat :";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(39, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 34);
            this.label10.TabIndex = 28;
            this.label10.Text = "Toplam Fiyat :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.musteriAdSoyadDataGridViewTextBoxColumn,
            this.musteriTelDataGridViewTextBoxColumn,
            this.tarihSaatDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.birimAdetDataGridViewTextBoxColumn,
            this.fiyatDataGridViewTextBoxColumn,
            this.toplamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.veresiyeSatisBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 620);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // veresiyeSatisTableAdapter
            // 
            this.veresiyeSatisTableAdapter.ClearBeforeFill = true;
            // 
            // musteriIdDataGridViewTextBoxColumn
            // 
            this.musteriIdDataGridViewTextBoxColumn.DataPropertyName = "MusteriId";
            this.musteriIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.musteriIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriIdDataGridViewTextBoxColumn.Name = "musteriIdDataGridViewTextBoxColumn";
            this.musteriIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.musteriIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // musteriAdSoyadDataGridViewTextBoxColumn
            // 
            this.musteriAdSoyadDataGridViewTextBoxColumn.DataPropertyName = "MusteriAdSoyad";
            this.musteriAdSoyadDataGridViewTextBoxColumn.HeaderText = "MusteriAdSoyad";
            this.musteriAdSoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriAdSoyadDataGridViewTextBoxColumn.Name = "musteriAdSoyadDataGridViewTextBoxColumn";
            this.musteriAdSoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriTelDataGridViewTextBoxColumn
            // 
            this.musteriTelDataGridViewTextBoxColumn.DataPropertyName = "MusteriTel";
            this.musteriTelDataGridViewTextBoxColumn.HeaderText = "MusteriTel";
            this.musteriTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTelDataGridViewTextBoxColumn.Name = "musteriTelDataGridViewTextBoxColumn";
            this.musteriTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarihSaatDataGridViewTextBoxColumn
            // 
            this.tarihSaatDataGridViewTextBoxColumn.DataPropertyName = "TarihSaat";
            this.tarihSaatDataGridViewTextBoxColumn.HeaderText = "TarihSaat";
            this.tarihSaatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihSaatDataGridViewTextBoxColumn.Name = "tarihSaatDataGridViewTextBoxColumn";
            this.tarihSaatDataGridViewTextBoxColumn.Width = 125;
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
            // veresiyeSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(643, 770);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "veresiyeSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "veresiyeSatis";
            this.Load += new System.EventHandler(this.veresiyeSatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veresiyeSatisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button satis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.TextBox barkodNo;
        private System.Windows.Forms.TextBox musteriPhoneNumber;
        private System.Windows.Forms.TextBox musteriName;
        private System.Windows.Forms.TextBox musteriTC;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.DataGridView dataGridView1;
        private gurMarketDBDataSet gurMarketDBDataSet;
        private System.Windows.Forms.BindingSource veresiyeSatisBindingSource;
        private gurMarketDBDataSetTableAdapters.VeresiyeSatisTableAdapter veresiyeSatisTableAdapter;
        protected System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamDataGridViewTextBoxColumn;
    }
}