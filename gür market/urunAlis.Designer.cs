
namespace gür_market
{
    partial class urunAlis
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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.temizle = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.ekleme = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunAlsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet2 = new gür_market.gurMarketDBDataSet2();
            this.urunAlsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunAlsTableAdapter = new gür_market.gurMarketDBDataSet2TableAdapters.UrunAlsTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ırsaliyeNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tedarikciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAlsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAlsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.temizle);
            this.groupBox1.Controls.Add(this.güncelle);
            this.groupBox1.Controls.Add(this.ekleme);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(254, 206);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(202, 22);
            this.textBox6.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(103, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 47;
            this.label7.Text = "İrsaliye no :";
            // 
            // temizle
            // 
            this.temizle.Image = global::gür_market.Properties.Resources.ip;
            this.temizle.Location = new System.Drawing.Point(460, 256);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(103, 34);
            this.temizle.TabIndex = 46;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // güncelle
            // 
            this.güncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.güncelle.Image = global::gür_market.Properties.Resources.ip;
            this.güncelle.Location = new System.Drawing.Point(281, 256);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(118, 34);
            this.güncelle.TabIndex = 45;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // ekleme
            // 
            this.ekleme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ekleme.Image = global::gür_market.Properties.Resources.ip;
            this.ekleme.Location = new System.Drawing.Point(116, 253);
            this.ekleme.Name = "ekleme";
            this.ekleme.Size = new System.Drawing.Size(100, 34);
            this.ekleme.TabIndex = 44;
            this.ekleme.Text = "EKLE";
            this.ekleme.UseVisualStyleBackColor = true;
            this.ekleme.Click += new System.EventHandler(this.ekleme_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(254, 169);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(202, 22);
            this.textBox5.TabIndex = 43;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(254, 131);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(202, 22);
            this.textBox4.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(254, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 22);
            this.textBox3.TabIndex = 41;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(254, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 22);
            this.textBox2.TabIndex = 40;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(254, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 22);
            this.textBox1.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(103, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 34);
            this.label6.TabIndex = 38;
            this.label6.Text = "Birim Fiyatı :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Birim Adeti :";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(103, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ürün Adı :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(103, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Barkod No :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tedarikçi Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(220, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "ÜRÜN ALIŞ";
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(739, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 51);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ırsaliyeNoDataGridViewTextBoxColumn,
            this.tedarikciAdiDataGridViewTextBoxColumn,
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.birimAdediDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunAlsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 256);
            this.dataGridView1.TabIndex = 26;
            // 
            // urunAlsBindingSource1
            // 
            this.urunAlsBindingSource1.DataMember = "UrunAls";
            this.urunAlsBindingSource1.DataSource = this.gurMarketDBDataSet2;
            // 
            // gurMarketDBDataSet2
            // 
            this.gurMarketDBDataSet2.DataSetName = "gurMarketDBDataSet2";
            this.gurMarketDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunAlsBindingSource
            // 
            this.urunAlsBindingSource.DataMember = "UrunAls";
            this.urunAlsBindingSource.DataSource = this.gurMarketDBDataSet2;
            // 
            // urunAlsTableAdapter
            // 
            this.urunAlsTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "UrunAlisID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
            // 
            // ırsaliyeNoDataGridViewTextBoxColumn
            // 
            this.ırsaliyeNoDataGridViewTextBoxColumn.DataPropertyName = "IrsaliyeNo";
            this.ırsaliyeNoDataGridViewTextBoxColumn.HeaderText = "IrsaliyeNo";
            this.ırsaliyeNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ırsaliyeNoDataGridViewTextBoxColumn.Name = "ırsaliyeNoDataGridViewTextBoxColumn";
            this.ırsaliyeNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tedarikciAdiDataGridViewTextBoxColumn
            // 
            this.tedarikciAdiDataGridViewTextBoxColumn.DataPropertyName = "TedarikciAdi";
            this.tedarikciAdiDataGridViewTextBoxColumn.HeaderText = "TedarikciAdi";
            this.tedarikciAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tedarikciAdiDataGridViewTextBoxColumn.Name = "tedarikciAdiDataGridViewTextBoxColumn";
            this.tedarikciAdiDataGridViewTextBoxColumn.Width = 125;
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
            // birimAdediDataGridViewTextBoxColumn
            // 
            this.birimAdediDataGridViewTextBoxColumn.DataPropertyName = "BirimAdedi";
            this.birimAdediDataGridViewTextBoxColumn.HeaderText = "BirimAdedi";
            this.birimAdediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimAdediDataGridViewTextBoxColumn.Name = "birimAdediDataGridViewTextBoxColumn";
            this.birimAdediDataGridViewTextBoxColumn.Width = 125;
            // 
            // birimFiyatDataGridViewTextBoxColumn
            // 
            this.birimFiyatDataGridViewTextBoxColumn.DataPropertyName = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.HeaderText = "BirimFiyat";
            this.birimFiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimFiyatDataGridViewTextBoxColumn.Name = "birimFiyatDataGridViewTextBoxColumn";
            this.birimFiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(801, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunAlis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunAlis";
            this.Load += new System.EventHandler(this.urunAlis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAlsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunAlsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ekleme;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private gurMarketDBDataSet2 gurMarketDBDataSet2;
        private System.Windows.Forms.BindingSource urunAlsBindingSource;
        private gurMarketDBDataSet2TableAdapters.UrunAlsTableAdapter urunAlsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource urunAlsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ırsaliyeNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tedarikciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
    }
}