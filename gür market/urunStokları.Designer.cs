
namespace gür_market
{
    partial class urunStokları
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.arama = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stoksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gurMarketDBDataSet6 = new gür_market.gurMarketDBDataSet6();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.stoksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stoksTableAdapter = new gür_market.gurMarketDBDataSet6TableAdapters.StoksTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barkodNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::gür_market.Properties.Resources.a__1_;
            this.button1.Location = new System.Drawing.Point(609, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 51);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "ÜRÜN STOKLARI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.arama);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(28, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 450);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stokda Bulunan Malzemeler";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(239, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 30);
            this.textBox1.TabIndex = 19;
            // 
            // arama
            // 
            this.arama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arama.Image = global::gür_market.Properties.Resources.ip;
            this.arama.Location = new System.Drawing.Point(433, 49);
            this.arama.Name = "arama";
            this.arama.Size = new System.Drawing.Size(92, 34);
            this.arama.TabIndex = 18;
            this.arama.Text = "Arama";
            this.arama.UseVisualStyleBackColor = true;
            this.arama.Click += new System.EventHandler(this.arama_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.barkodNoDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.birimAdediDataGridViewTextBoxColumn,
            this.birimFiyatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoksBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 333);
            this.dataGridView1.TabIndex = 1;
            // 
            // stoksBindingSource1
            // 
            this.stoksBindingSource1.DataMember = "Stoks";
            this.stoksBindingSource1.DataSource = this.gurMarketDBDataSet6;
            // 
            // gurMarketDBDataSet6
            // 
            this.gurMarketDBDataSet6.DataSetName = "gurMarketDBDataSet6";
            this.gurMarketDBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BARKOD NO",
            "URUN ADI"});
            this.comboBox1.Location = new System.Drawing.Point(73, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // stoksBindingSource
            // 
            this.stoksBindingSource.DataMember = "Stoks";
            this.stoksBindingSource.DataSource = this.gurMarketDBDataSet6;
            // 
            // stoksTableAdapter
            // 
            this.stoksTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StokID";
            this.Column1.HeaderText = "ID";
            this.Column1.MaxInputLength = 32736;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
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
            // urunStokları
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gür_market.Properties.Resources.form;
            this.ClientSize = new System.Drawing.Size(677, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunStokları";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "urunStokları";
            this.Load += new System.EventHandler(this.urunStokları_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gurMarketDBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoksBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button arama;
        private System.Windows.Forms.TextBox textBox1;
        private gurMarketDBDataSet6 gurMarketDBDataSet6;
        private System.Windows.Forms.BindingSource stoksBindingSource;
        private gurMarketDBDataSet6TableAdapters.StoksTableAdapter stoksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stoksBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimFiyatDataGridViewTextBoxColumn;
    }
}