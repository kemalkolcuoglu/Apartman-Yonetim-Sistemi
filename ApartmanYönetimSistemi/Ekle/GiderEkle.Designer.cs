namespace ApartmanYönetimSistemi.Ekle
{
	partial class GiderEkle
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_giderTuru = new System.Windows.Forms.TextBox();
			this.tb_tutar = new System.Windows.Forms.TextBox();
			this.tb_aciklama = new System.Windows.Forms.TextBox();
			this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label1.Location = new System.Drawing.Point(20, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Gider Türü:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(50, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tutar:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label4.Location = new System.Drawing.Point(51, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tarih:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label5.Location = new System.Drawing.Point(29, 133);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Açıklama:";
			// 
			// tb_giderTuru
			// 
			this.tb_giderTuru.Location = new System.Drawing.Point(97, 52);
			this.tb_giderTuru.MaxLength = 25;
			this.tb_giderTuru.Name = "tb_giderTuru";
			this.tb_giderTuru.Size = new System.Drawing.Size(100, 20);
			this.tb_giderTuru.TabIndex = 1;
			// 
			// tb_tutar
			// 
			this.tb_tutar.Location = new System.Drawing.Point(97, 78);
			this.tb_tutar.MaxLength = 10;
			this.tb_tutar.Name = "tb_tutar";
			this.tb_tutar.Size = new System.Drawing.Size(100, 20);
			this.tb_tutar.TabIndex = 2;
			// 
			// tb_aciklama
			// 
			this.tb_aciklama.Location = new System.Drawing.Point(97, 130);
			this.tb_aciklama.MaxLength = 250;
			this.tb_aciklama.Multiline = true;
			this.tb_aciklama.Name = "tb_aciklama";
			this.tb_aciklama.Size = new System.Drawing.Size(171, 62);
			this.tb_aciklama.TabIndex = 4;
			// 
			// dtp_tarih
			// 
			this.dtp_tarih.Location = new System.Drawing.Point(97, 104);
			this.dtp_tarih.Name = "dtp_tarih";
			this.dtp_tarih.Size = new System.Drawing.Size(171, 20);
			this.dtp_tarih.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
			this.button1.Location = new System.Drawing.Point(94, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(101, 41);
			this.button1.TabIndex = 5;
			this.button1.Text = "Onayla";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(-8, 9);
			this.label3.MinimumSize = new System.Drawing.Size(305, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(305, 24);
			this.label3.TabIndex = 29;
			this.label3.Text = "Giderler";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GiderEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(289, 261);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dtp_tarih);
			this.Controls.Add(this.tb_aciklama);
			this.Controls.Add(this.tb_tutar);
			this.Controls.Add(this.tb_giderTuru);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(305, 300);
			this.MinimumSize = new System.Drawing.Size(305, 300);
			this.Name = "GiderEkle";
			this.Text = "Giderler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_giderTuru;
		private System.Windows.Forms.TextBox tb_tutar;
		private System.Windows.Forms.TextBox tb_aciklama;
		private System.Windows.Forms.DateTimePicker dtp_tarih;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
	}
}