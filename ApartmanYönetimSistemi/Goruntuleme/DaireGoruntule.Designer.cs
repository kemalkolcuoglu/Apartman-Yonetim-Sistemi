namespace ApartmanYönetimSistemi.Goruntuleme
{
	partial class DaireGoruntule
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.gb_filtrele = new System.Windows.Forms.GroupBox();
			this.rb_daireSakini = new System.Windows.Forms.RadioButton();
			this.rb_daireSahibi = new System.Windows.Forms.RadioButton();
			this.rb_daireDurum = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.bt_filtrele = new System.Windows.Forms.Button();
			this.gb_islemler = new System.Windows.Forms.GroupBox();
			this.bt_eskiDaire = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.bt_sil = new System.Windows.Forms.Button();
			this.bt_duzenle = new System.Windows.Forms.Button();
			this.bt_daireEkle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.gb_filtrele.SuspendLayout();
			this.gb_islemler.SuspendLayout();
			this.SuspendLayout();
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
			this.dataGridView1.Size = new System.Drawing.Size(623, 463);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// gb_filtrele
			// 
			this.gb_filtrele.Controls.Add(this.rb_daireSakini);
			this.gb_filtrele.Controls.Add(this.rb_daireSahibi);
			this.gb_filtrele.Controls.Add(this.rb_daireDurum);
			this.gb_filtrele.Controls.Add(this.textBox1);
			this.gb_filtrele.Controls.Add(this.bt_filtrele);
			this.gb_filtrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_filtrele.Location = new System.Drawing.Point(12, 51);
			this.gb_filtrele.Name = "gb_filtrele";
			this.gb_filtrele.Size = new System.Drawing.Size(113, 161);
			this.gb_filtrele.TabIndex = 1;
			this.gb_filtrele.TabStop = false;
			this.gb_filtrele.Text = "Filtrele";
			// 
			// rb_daireSakini
			// 
			this.rb_daireSakini.AutoSize = true;
			this.rb_daireSakini.Location = new System.Drawing.Point(6, 65);
			this.rb_daireSakini.Name = "rb_daireSakini";
			this.rb_daireSakini.Size = new System.Drawing.Size(94, 17);
			this.rb_daireSakini.TabIndex = 3;
			this.rb_daireSakini.Tag = "DaireSakini";
			this.rb_daireSakini.Text = "Daire Sakini";
			this.rb_daireSakini.UseVisualStyleBackColor = true;
			this.rb_daireSakini.CheckedChanged += new System.EventHandler(this.rb_daireDurum_CheckedChanged);
			// 
			// rb_daireSahibi
			// 
			this.rb_daireSahibi.AutoSize = true;
			this.rb_daireSahibi.Location = new System.Drawing.Point(6, 42);
			this.rb_daireSahibi.Name = "rb_daireSahibi";
			this.rb_daireSahibi.Size = new System.Drawing.Size(94, 17);
			this.rb_daireSahibi.TabIndex = 2;
			this.rb_daireSahibi.Tag = "DaireSahibi";
			this.rb_daireSahibi.Text = "Daire Sahibi";
			this.rb_daireSahibi.UseVisualStyleBackColor = true;
			this.rb_daireSahibi.CheckedChanged += new System.EventHandler(this.rb_daireDurum_CheckedChanged);
			// 
			// rb_daireDurum
			// 
			this.rb_daireDurum.AutoSize = true;
			this.rb_daireDurum.Location = new System.Drawing.Point(6, 19);
			this.rb_daireDurum.Name = "rb_daireDurum";
			this.rb_daireDurum.Size = new System.Drawing.Size(102, 17);
			this.rb_daireDurum.TabIndex = 1;
			this.rb_daireDurum.Tag = "DaireDurum";
			this.rb_daireDurum.Text = "Daire Durumu";
			this.rb_daireDurum.UseVisualStyleBackColor = true;
			this.rb_daireDurum.CheckedChanged += new System.EventHandler(this.rb_daireDurum_CheckedChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(6, 88);
			this.textBox1.MaxLength = 10;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(101, 20);
			this.textBox1.TabIndex = 4;
			// 
			// bt_filtrele
			// 
			this.bt_filtrele.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_filtrele.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_filtrele.Location = new System.Drawing.Point(6, 114);
			this.bt_filtrele.Name = "bt_filtrele";
			this.bt_filtrele.Size = new System.Drawing.Size(101, 43);
			this.bt_filtrele.TabIndex = 5;
			this.bt_filtrele.Text = "Filtrele";
			this.bt_filtrele.UseVisualStyleBackColor = false;
			this.bt_filtrele.Click += new System.EventHandler(this.bt_filtrele_Click);
			// 
			// gb_islemler
			// 
			this.gb_islemler.Controls.Add(this.bt_eskiDaire);
			this.gb_islemler.Controls.Add(this.button1);
			this.gb_islemler.Controls.Add(this.bt_sil);
			this.gb_islemler.Controls.Add(this.bt_duzenle);
			this.gb_islemler.Controls.Add(this.bt_daireEkle);
			this.gb_islemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gb_islemler.Location = new System.Drawing.Point(12, 218);
			this.gb_islemler.Name = "gb_islemler";
			this.gb_islemler.Size = new System.Drawing.Size(113, 265);
			this.gb_islemler.TabIndex = 2;
			this.gb_islemler.TabStop = false;
			this.gb_islemler.Text = "İşlemler";
			// 
			// bt_eskiDaire
			// 
			this.bt_eskiDaire.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_eskiDaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_eskiDaire.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_eskiDaire.Location = new System.Drawing.Point(6, 215);
			this.bt_eskiDaire.Name = "bt_eskiDaire";
			this.bt_eskiDaire.Size = new System.Drawing.Size(101, 43);
			this.bt_eskiDaire.TabIndex = 10;
			this.bt_eskiDaire.Text = "Eski Daire Kayıtları";
			this.bt_eskiDaire.UseVisualStyleBackColor = false;
			this.bt_eskiDaire.Click += new System.EventHandler(this.bt_eskiDaire_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.button1.Location = new System.Drawing.Point(6, 166);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 43);
			this.button1.TabIndex = 9;
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
			this.bt_sil.TabIndex = 8;
			this.bt_sil.Text = "Daireyi Sil";
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
			this.bt_duzenle.TabIndex = 7;
			this.bt_duzenle.Text = "Daireyi Düzenle";
			this.bt_duzenle.UseVisualStyleBackColor = false;
			this.bt_duzenle.Click += new System.EventHandler(this.bt_duzenle_Click);
			// 
			// bt_daireEkle
			// 
			this.bt_daireEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_daireEkle.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_daireEkle.Location = new System.Drawing.Point(6, 19);
			this.bt_daireEkle.Name = "bt_daireEkle";
			this.bt_daireEkle.Size = new System.Drawing.Size(101, 43);
			this.bt_daireEkle.TabIndex = 6;
			this.bt_daireEkle.Text = "Daire Ekle";
			this.bt_daireEkle.UseVisualStyleBackColor = false;
			this.bt_daireEkle.Click += new System.EventHandler(this.bt_daireEkle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(0, 12);
			this.label1.MinimumSize = new System.Drawing.Size(145, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 24);
			this.label1.TabIndex = 8;
			this.label1.Text = "Daireler";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DaireGoruntule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(777, 487);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gb_islemler);
			this.Controls.Add(this.gb_filtrele);
			this.MinimumSize = new System.Drawing.Size(770, 495);
			this.Name = "DaireGoruntule";
			this.Text = "Daireleri Görüntüle - KKY Site Yönetim Sistemi";
			this.Resize += new System.EventHandler(this.DaireGoruntule_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.gb_filtrele.ResumeLayout(false);
			this.gb_filtrele.PerformLayout();
			this.gb_islemler.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox gb_filtrele;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button bt_filtrele;
		private System.Windows.Forms.RadioButton rb_daireDurum;
		private System.Windows.Forms.RadioButton rb_daireSakini;
		private System.Windows.Forms.RadioButton rb_daireSahibi;
		private System.Windows.Forms.GroupBox gb_islemler;
		private System.Windows.Forms.Button bt_sil;
		private System.Windows.Forms.Button bt_duzenle;
		private System.Windows.Forms.Button bt_daireEkle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button bt_eskiDaire;
	}
}