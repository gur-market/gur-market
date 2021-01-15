
namespace gür_market
{
    partial class musteri_borc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.temizle = new System.Windows.Forms.Button();
            this.musteri_silme = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.arama = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musterisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet1 = new gür_market.gurMarketDBDataSet1();
            this.musterisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet = new gür_market.gurMarketDBDataSet();
            this.gurMarketDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musterisTableAdapter = new gür_market.gurMarketDBDataSet1TableAdapters.MusterisTableAdapter();
            this.musteriIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihSaatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borcMiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Controls.Add(this.musteri_silme);
            this.groupBox1.Controls.Add(this.güncelle);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.arama);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(52, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgi Paneli";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.Location = new System.Drawing.Point(250, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 49;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // temizle
            // 
            this.temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizle.Image = global::gür_market.Properties.Resources.ip;
            this.temizle.Location = new System.Drawing.Point(447, 304);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(103, 34);
            this.temizle.TabIndex = 48;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // musteri_silme
            // 
            this.musteri_silme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.musteri_silme.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_silme.Image = global::gür_market.Properties.Resources.ip;
            this.musteri_silme.Location = new System.Drawing.Point(257, 304);
            this.musteri_silme.Name = "musteri_silme";
            this.musteri_silme.Size = new System.Drawing.Size(117, 34);
            this.musteri_silme.TabIndex = 47;
            this.musteri_silme.Text = "MÜŞTERİ SİL";
            this.musteri_silme.UseVisualStyleBackColor = true;
            // 
            // güncelle
            // 
            this.güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncelle.Image = global::gür_market.Properties.Resources.ip;
            this.güncelle.Location = new System.Drawing.Point(72, 304);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(118, 34);
            this.güncelle.TabIndex = 46;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(250, 253);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 30);
            this.textBox5.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(68, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 43;
            this.label6.Text = "Borç Miktarı :";
            // 
            // arama
            // 
            this.arama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.Image = global::gür_market.Properties.Resources.ip;
            this.arama.Location = new System.Drawing.Point(405, 35);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(114, 34);
            this.arama.TabIndex = 42;
            this.arama.Text = "Müşteri Arama";
            this.arama.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(250, 172);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 30);
            this.textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(250, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 30);
            this.textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(250, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 30);
            this.textBox1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 36;
            this.label5.Text = "Tarih-Saat :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(72, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tel :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Müşteri Ad Soyad :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 33;
            this.label2.Text = "Müşteri Tc :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(92, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(562, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "MÜŞTERİ BORÇ SAYFASI";
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(687, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 45);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriIdDataGridViewTextBoxColumn,
            this.musteriAdSoyadDataGridViewTextBoxColumn,
            this.musteriTcDataGridViewTextBoxColumn,
            this.musteriTelDataGridViewTextBoxColumn,
            this.tarihSaatDataGridViewTextBoxColumn,
            this.borcMiktariDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musterisBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // musterisBindingSource1
            // 
            this.musterisBindingSource1.DataMember = "Musteris";
            this.musterisBindingSource1.DataSource = this.gurMarketDBDataSet1BindingSource;
            // 
            // gurMarketDBDataSet1BindingSource
            // 
            this.gurMarketDBDataSet1BindingSource.DataSource = this.gurMarketDBDataSet1;
            this.gurMarketDBDataSet1BindingSource.Position = 0;
            // 
            // gurMarketDBDataSet1
            // 
            this.gurMarketDBDataSet1.DataSetName = "gurMarketDBDataSet1";
            this.gurMarketDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musterisBindingSource
            // 
            this.musterisBindingSource.DataMember = "Musteris";
            this.musterisBindingSource.DataSource = this.gurMarketDBDataSet1;
            // 
            // gurMarketDBDataSet
            // 
            this.gurMarketDBDataSet.DataSetName = "gurMarketDBDataSet";
            this.gurMarketDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gurMarketDBDataSetBindingSource
            // 
            this.gurMarketDBDataSetBindingSource.DataSource = this.gurMarketDBDataSet;
            this.gurMarketDBDataSetBindingSource.Position = 0;
            // 
            // musterisTableAdapter
            // 
            this.musterisTableAdapter.ClearBeforeFill = true;
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
            // musteriTcDataGridViewTextBoxColumn
            // 
            this.musteriTcDataGridViewTextBoxColumn.DataPropertyName = "MusteriTc";
            this.musteriTcDataGridViewTextBoxColumn.HeaderText = "MusteriTc";
            this.musteriTcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriTcDataGridViewTextBoxColumn.Name = "musteriTcDataGridViewTextBoxColumn";
            this.musteriTcDataGridViewTextBoxColumn.Width = 125;
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
            // borcMiktariDataGridViewTextBoxColumn
            // 
            this.borcMiktariDataGridViewTextBoxColumn.DataPropertyName = "BorcMiktari";
            this.borcMiktariDataGridViewTextBoxColumn.HeaderText = "BorcMiktari";
            this.borcMiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.borcMiktariDataGridViewTextBoxColumn.Name = "borcMiktariDataGridViewTextBoxColumn";
            this.borcMiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteri_borc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(743, 596);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "musteri_borc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "musteri_borc";
            this.Load += new System.EventHandler(this.musteri_borc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musterisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button musteri_silme;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource gurMarketDBDataSetBindingSource;
        private gurMarketDBDataSet gurMarketDBDataSet;
        private gurMarketDBDataSet1 gurMarketDBDataSet1;
        private System.Windows.Forms.BindingSource musterisBindingSource;
        private gurMarketDBDataSet1TableAdapters.MusterisTableAdapter musterisTableAdapter;
        private System.Windows.Forms.BindingSource musterisBindingSource1;
        private System.Windows.Forms.BindingSource gurMarketDBDataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihSaatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borcMiktariDataGridViewTextBoxColumn;
    }
}