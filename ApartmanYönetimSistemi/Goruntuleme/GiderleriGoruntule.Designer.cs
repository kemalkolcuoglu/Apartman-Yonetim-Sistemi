namespace ApartmanYönetimSistemi.Goruntuleme
{
	partial class GiderleriGoruntule
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gb_islemler = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.bt_sil = new System.Windows.Forms.Button();
			this.bt_duzenle = new System.Windows.Forms.Button();
			this.bt_giderEkle = new System.Windows.Forms.Button();
			this.gb_filtrele = new System.Windows.Forms.GroupBox();
			this.rb_giderTuru = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.bt_filtrele = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.gb_islemler.SuspendLayout();
			this.gb_filtrele.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// gb_islemler
			// 
			this.gb_islemler.Controls.Add(this.button1);
			this.gb_islemler.Controls.Add(this.bt_sil);
			this.gb_islemler.Controls.Add(this.bt_duzenle);
			this.gb_islemler.Controls.Add(this.bt_giderEkle);
			this.gb_islemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_islemler.Location = new System.Drawing.Point(12, 175);
			this.gb_islemler.Name = "gb_islemler";
			this.gb_islemler.Size = new System.Drawing.Size(113, 221);
			this.gb_islemler.TabIndex = 5;
			this.gb_islemler.TabStop = false;
			this.gb_islemler.Text = "İşlemler";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.button1.Location = new System.Drawing.Point(6, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 43);
			this.button1.TabIndex = 7;
			this.button1.Text = "Raporla";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// bt_sil
			// 
			this.bt_sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_sil.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_sil.Location = new System.Drawing.Point(6, 117);
			this.bt_sil.Name = "bt_sil";
			this.bt_sil.Size = new System.Drawing.Size(101, 43);
			this.bt_sil.TabIndex = 6;
			this.bt_sil.Text = "Gider Sil";
			this.bt_sil.UseVisualStyleBackColor = false;
			this.bt_sil.Click += new System.EventHandler(this.bt_sil_Click);
			// 
			// bt_duzenle
			// 
			this.bt_duzenle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_duzenle.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_duzenle.Location = new System.Drawing.Point(6, 68);
			this.bt_duzenle.Name = "bt_duzenle";
			this.bt_duzenle.Size = new System.Drawing.Size(101, 43);
			this.bt_duzenle.TabIndex = 5;
			this.bt_duzenle.Text = "Giderleri Düzenle";
			this.bt_duzenle.UseVisualStyleBackColor = false;
			this.bt_duzenle.Click += new System.EventHandler(this.bt_duzenle_Click);
			// 
			// bt_giderEkle
			// 
			this.bt_giderEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_giderEkle.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_giderEkle.Location = new System.Drawing.Point(6, 19);
			this.bt_giderEkle.Name = "bt_giderEkle";
			this.bt_giderEkle.Size = new System.Drawing.Size(101, 43);
			this.bt_giderEkle.TabIndex = 4;
			this.bt_giderEkle.Text = "Gider Ekle";
			this.bt_giderEkle.UseVisualStyleBackColor = false;
			this.bt_giderEkle.Click += new System.EventHandler(this.bt_giderEkle_Click);
			// 
			// gb_filtrele
			// 
			this.gb_filtrele.Controls.Add(this.rb_giderTuru);
			this.gb_filtrele.Controls.Add(this.textBox1);
			this.gb_filtrele.Controls.Add(this.bt_filtrele);
			this.gb_filtrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_filtrele.Location = new System.Drawing.Point(12, 50);
			this.gb_filtrele.Name = "gb_filtrele";
			this.gb_filtrele.Size = new System.Drawing.Size(113, 119);
			this.gb_filtrele.TabIndex = 4;
			this.gb_filtrele.TabStop = false;
			this.gb_filtrele.Text = "Filtrele";
			// 
			// rb_giderTuru
			// 
			this.rb_giderTuru.AutoSize = true;
			this.rb_giderTuru.Location = new System.Drawing.Point(6, 19);
			this.rb_giderTuru.Name = "rb_giderTuru";
			this.rb_giderTuru.Size = new System.Drawing.Size(85, 17);
			this.rb_giderTuru.TabIndex = 1;
			this.rb_giderTuru.Tag = "GiderTuru";
			this.rb_giderTuru.Text = "Gider Türü";
			this.rb_giderTuru.UseVisualStyleBackColor = true;
			this.rb_giderTuru.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 42);
			this.textBox1.MaxLength = 10;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 2;
			// 
			// bt_filtrele
			// 
			this.bt_filtrele.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_filtrele.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_filtrele.Location = new System.Drawing.Point(6, 68);
			this.bt_filtrele.Name = "bt_filtrele";
			this.bt_filtrele.Size = new System.Drawing.Size(101, 43);
			this.bt_filtrele.TabIndex = 3;
			this.bt_filtrele.Text = "Filtrele";
			this.bt_filtrele.UseVisualStyleBackColor = false;
			this.bt_filtrele.Click += new System.EventHandler(this.bt_filtrele_Click);
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(142, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(600, 432);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(2, 12);
			this.label1.MinimumSize = new System.Drawing.Size(145, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Giderler";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GiderleriGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(754, 456);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gb_islemler);
			this.Controls.Add(this.gb_filtrele);
			this.MinimumSize = new System.Drawing.Size(770, 495);
			this.Name = "GiderleriGoruntule";
			this.Text = "Giderleri Görüntüle - KKY Site Yönetim Sistemi";
			this.Resize += new System.EventHandler(this.GiderleriGoruntule_Resize);
			this.gb_islemler.ResumeLayout(false);
			this.gb_filtrele.ResumeLayout(false);
			this.gb_filtrele.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gb_islemler;
		private System.Windows.Forms.Button bt_sil;
		private System.Windows.Forms.Button bt_duzenle;
		private System.Windows.Forms.Button bt_giderEkle;
		private System.Windows.Forms.GroupBox gb_filtrele;
		private System.Windows.Forms.RadioButton rb_giderTuru;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button bt_filtrele;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}