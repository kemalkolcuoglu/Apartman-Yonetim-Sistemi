namespace ApartmanYönetimSistemi
{
	partial class EskiDaireEkle
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
			this.bt_kaydet = new System.Windows.Forms.Button();
			this.cb_DaireSakini = new System.Windows.Forms.ComboBox();
			this.lb_daireSakini = new System.Windows.Forms.Label();
			this.cb_DaireSahibi = new System.Windows.Forms.ComboBox();
			this.lb_daireSahibi = new System.Windows.Forms.Label();
			this.lb_aciklama = new System.Windows.Forms.Label();
			this.lb_daireNo = new System.Windows.Forms.Label();
			this.tb_daireNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtp_satmaCikma = new System.Windows.Forms.DateTimePicker();
			this.lb_satmaCikma = new System.Windows.Forms.Label();
			this.dtp_almaGiris = new System.Windows.Forms.DateTimePicker();
			this.lb_almaGiris = new System.Windows.Forms.Label();
			this.tb_aciklama = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bt_kaydet
			// 
			this.bt_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_kaydet.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_kaydet.Location = new System.Drawing.Point(143, 310);
			this.bt_kaydet.Name = "bt_kaydet";
			this.bt_kaydet.Size = new System.Drawing.Size(101, 41);
			this.bt_kaydet.TabIndex = 7;
			this.bt_kaydet.Text = "Onayla";
			this.bt_kaydet.UseVisualStyleBackColor = false;
			this.bt_kaydet.Click += new System.EventHandler(this.bt_kaydet_Click);
			// 
			// cb_DaireSakini
			// 
			this.cb_DaireSakini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireSakini.FormattingEnabled = true;
			this.cb_DaireSakini.Location = new System.Drawing.Point(186, 105);
			this.cb_DaireSakini.Name = "cb_DaireSakini";
			this.cb_DaireSakini.Size = new System.Drawing.Size(121, 21);
			this.cb_DaireSakini.TabIndex = 3;
			// 
			// lb_daireSakini
			// 
			this.lb_daireSakini.AutoSize = true;
			this.lb_daireSakini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireSakini.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireSakini.Location = new System.Drawing.Point(92, 108);
			this.lb_daireSakini.Name = "lb_daireSakini";
			this.lb_daireSakini.Size = new System.Drawing.Size(85, 13);
			this.lb_daireSakini.TabIndex = 17;
			this.lb_daireSakini.Text = "*Daire Sakini:";
			// 
			// cb_DaireSahibi
			// 
			this.cb_DaireSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireSahibi.FormattingEnabled = true;
			this.cb_DaireSahibi.Location = new System.Drawing.Point(186, 78);
			this.cb_DaireSahibi.Name = "cb_DaireSahibi";
			this.cb_DaireSahibi.Size = new System.Drawing.Size(121, 21);
			this.cb_DaireSahibi.TabIndex = 2;
			// 
			// lb_daireSahibi
			// 
			this.lb_daireSahibi.AutoSize = true;
			this.lb_daireSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireSahibi.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireSahibi.Location = new System.Drawing.Point(92, 81);
			this.lb_daireSahibi.Name = "lb_daireSahibi";
			this.lb_daireSahibi.Size = new System.Drawing.Size(85, 13);
			this.lb_daireSahibi.TabIndex = 15;
			this.lb_daireSahibi.Text = "*Daire Sahibi:";
			// 
			// lb_aciklama
			// 
			this.lb_aciklama.AutoSize = true;
			this.lb_aciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_aciklama.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_aciklama.Location = new System.Drawing.Point(115, 187);
			this.lb_aciklama.Name = "lb_aciklama";
			this.lb_aciklama.Size = new System.Drawing.Size(62, 13);
			this.lb_aciklama.TabIndex = 13;
			this.lb_aciklama.Text = "Açıklama:";
			// 
			// lb_daireNo
			// 
			this.lb_daireNo.AutoSize = true;
			this.lb_daireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireNo.Location = new System.Drawing.Point(75, 55);
			this.lb_daireNo.Name = "lb_daireNo";
			this.lb_daireNo.Size = new System.Drawing.Size(102, 13);
			this.lb_daireNo.TabIndex = 11;
			this.lb_daireNo.Text = "*Daire Numarası:";
			// 
			// tb_daireNo
			// 
			this.tb_daireNo.Location = new System.Drawing.Point(186, 52);
			this.tb_daireNo.MaxLength = 4;
			this.tb_daireNo.Name = "tb_daireNo";
			this.tb_daireNo.Size = new System.Drawing.Size(121, 20);
			this.tb_daireNo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(400, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 24);
			this.label1.TabIndex = 28;
			this.label1.Text = "Eski Daire Kaydı";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp_satmaCikma
			// 
			this.dtp_satmaCikma.Location = new System.Drawing.Point(186, 158);
			this.dtp_satmaCikma.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.dtp_satmaCikma.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtp_satmaCikma.Name = "dtp_satmaCikma";
			this.dtp_satmaCikma.Size = new System.Drawing.Size(183, 20);
			this.dtp_satmaCikma.TabIndex = 5;
			this.dtp_satmaCikma.Value = new System.DateTime(2099, 1, 30, 0, 0, 0, 0);
			// 
			// lb_satmaCikma
			// 
			this.lb_satmaCikma.AutoSize = true;
			this.lb_satmaCikma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_satmaCikma.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_satmaCikma.Location = new System.Drawing.Point(5, 158);
			this.lb_satmaCikma.Name = "lb_satmaCikma";
			this.lb_satmaCikma.Size = new System.Drawing.Size(175, 13);
			this.lb_satmaCikma.TabIndex = 31;
			this.lb_satmaCikma.Text = "*Daireden Çıkış/Satma Tarihi:";
			// 
			// dtp_almaGiris
			// 
			this.dtp_almaGiris.Location = new System.Drawing.Point(186, 132);
			this.dtp_almaGiris.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.dtp_almaGiris.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtp_almaGiris.Name = "dtp_almaGiris";
			this.dtp_almaGiris.Size = new System.Drawing.Size(183, 20);
			this.dtp_almaGiris.TabIndex = 4;
			this.dtp_almaGiris.Value = new System.DateTime(2018, 3, 17, 0, 0, 0, 0);
			// 
			// lb_almaGiris
			// 
			this.lb_almaGiris.AutoSize = true;
			this.lb_almaGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_almaGiris.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_almaGiris.Location = new System.Drawing.Point(23, 132);
			this.lb_almaGiris.Name = "lb_almaGiris";
			this.lb_almaGiris.Size = new System.Drawing.Size(157, 13);
			this.lb_almaGiris.TabIndex = 29;
			this.lb_almaGiris.Text = "*Daireye Giriş/Alma Tarihi:";
			// 
			// tb_aciklama
			// 
			this.tb_aciklama.Location = new System.Drawing.Point(186, 184);
			this.tb_aciklama.MaxLength = 250;
			this.tb_aciklama.Multiline = true;
			this.tb_aciklama.Name = "tb_aciklama";
			this.tb_aciklama.Size = new System.Drawing.Size(183, 114);
			this.tb_aciklama.TabIndex = 6;
			// 
			// EskiDaireEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(384, 363);
			this.Controls.Add(this.tb_aciklama);
			this.Controls.Add(this.dtp_satmaCikma);
			this.Controls.Add(this.lb_satmaCikma);
			this.Controls.Add(this.dtp_almaGiris);
			this.Controls.Add(this.lb_almaGiris);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_daireNo);
			this.Controls.Add(this.bt_kaydet);
			this.Controls.Add(this.cb_DaireSakini);
			this.Controls.Add(this.lb_daireSakini);
			this.Controls.Add(this.cb_DaireSahibi);
			this.Controls.Add(this.lb_daireSahibi);
			this.Controls.Add(this.lb_aciklama);
			this.Controls.Add(this.lb_daireNo);
			this.MaximumSize = new System.Drawing.Size(400, 402);
			this.MinimumSize = new System.Drawing.Size(400, 402);
			this.Name = "EskiDaireEkle";
			this.Text = "Daireler";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_kaydet;
		private System.Windows.Forms.ComboBox cb_DaireSakini;
		private System.Windows.Forms.Label lb_daireSakini;
		private System.Windows.Forms.ComboBox cb_DaireSahibi;
		private System.Windows.Forms.Label lb_daireSahibi;
		private System.Windows.Forms.Label lb_aciklama;
		private System.Windows.Forms.Label lb_daireNo;
		private System.Windows.Forms.TextBox tb_daireNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtp_satmaCikma;
		private System.Windows.Forms.Label lb_satmaCikma;
		private System.Windows.Forms.DateTimePicker dtp_almaGiris;
		private System.Windows.Forms.Label lb_almaGiris;
		private System.Windows.Forms.TextBox tb_aciklama;
	}
}