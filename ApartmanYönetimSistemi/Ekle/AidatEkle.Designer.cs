namespace ApartmanYönetimSistemi
{
	partial class AidatEkle
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
			this.lb_aidatNo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_tutar = new System.Windows.Forms.Label();
			this.lb_odenenTutar = new System.Windows.Forms.Label();
			this.tb_aidatNo = new System.Windows.Forms.TextBox();
			this.tb_tutar = new System.Windows.Forms.TextBox();
			this.tb_ortakTutar = new System.Windows.Forms.TextBox();
			this.cb_daireNo = new System.Windows.Forms.ComboBox();
			this.bt_onayla = new System.Windows.Forms.Button();
			this.lb_tarih = new System.Windows.Forms.Label();
			this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
			this.tb_demirbas = new System.Windows.Forms.TextBox();
			this.lb_demirbas = new System.Windows.Forms.Label();
			this.tb_toplam = new System.Windows.Forms.TextBox();
			this.lb_toplam = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_aidatNo
			// 
			this.lb_aidatNo.AutoSize = true;
			this.lb_aidatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_aidatNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_aidatNo.Location = new System.Drawing.Point(66, 58);
			this.lb_aidatNo.Name = "lb_aidatNo";
			this.lb_aidatNo.Size = new System.Drawing.Size(60, 13);
			this.lb_aidatNo.TabIndex = 0;
			this.lb_aidatNo.Text = "Aidat No:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.Location = new System.Drawing.Point(65, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Daire No:";
			// 
			// lb_tutar
			// 
			this.lb_tutar.AutoSize = true;
			this.lb_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tutar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_tutar.Location = new System.Drawing.Point(48, 137);
			this.lb_tutar.Name = "lb_tutar";
			this.lb_tutar.Size = new System.Drawing.Size(78, 13);
			this.lb_tutar.TabIndex = 2;
			this.lb_tutar.Text = "Aidat Ücreti:";
			// 
			// lb_odenenTutar
			// 
			this.lb_odenenTutar.AutoSize = true;
			this.lb_odenenTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_odenenTutar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_odenenTutar.Location = new System.Drawing.Point(14, 163);
			this.lb_odenenTutar.Name = "lb_odenenTutar";
			this.lb_odenenTutar.Size = new System.Drawing.Size(112, 13);
			this.lb_odenenTutar.TabIndex = 3;
			this.lb_odenenTutar.Text = "Ortak Yakıt Tutarı:";
			// 
			// tb_aidatNo
			// 
			this.tb_aidatNo.Location = new System.Drawing.Point(132, 55);
			this.tb_aidatNo.MaxLength = 20;
			this.tb_aidatNo.Name = "tb_aidatNo";
			this.tb_aidatNo.Size = new System.Drawing.Size(100, 20);
			this.tb_aidatNo.TabIndex = 1;
			this.tb_aidatNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// tb_tutar
			// 
			this.tb_tutar.Location = new System.Drawing.Point(132, 134);
			this.tb_tutar.MaxLength = 10;
			this.tb_tutar.Name = "tb_tutar";
			this.tb_tutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tb_tutar.Size = new System.Drawing.Size(100, 20);
			this.tb_tutar.TabIndex = 4;
			this.tb_tutar.Text = "0";
			this.tb_tutar.TextChanged += new System.EventHandler(this.tb_Tutar_TextChanged);
			this.tb_tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// tb_ortakTutar
			// 
			this.tb_ortakTutar.Location = new System.Drawing.Point(132, 160);
			this.tb_ortakTutar.MaxLength = 10;
			this.tb_ortakTutar.Name = "tb_ortakTutar";
			this.tb_ortakTutar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tb_ortakTutar.Size = new System.Drawing.Size(100, 20);
			this.tb_ortakTutar.TabIndex = 5;
			this.tb_ortakTutar.Text = "0";
			this.tb_ortakTutar.TextChanged += new System.EventHandler(this.tb_Tutar_TextChanged);
			this.tb_ortakTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// cb_daireNo
			// 
			this.cb_daireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_daireNo.FormattingEnabled = true;
			this.cb_daireNo.Location = new System.Drawing.Point(132, 81);
			this.cb_daireNo.MaxLength = 10;
			this.cb_daireNo.Name = "cb_daireNo";
			this.cb_daireNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_daireNo.Size = new System.Drawing.Size(100, 21);
			this.cb_daireNo.TabIndex = 2;
			// 
			// bt_onayla
			// 
			this.bt_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_onayla.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_onayla.Location = new System.Drawing.Point(107, 242);
			this.bt_onayla.Name = "bt_onayla";
			this.bt_onayla.Size = new System.Drawing.Size(101, 41);
			this.bt_onayla.TabIndex = 8;
			this.bt_onayla.Text = "Onayla";
			this.bt_onayla.UseVisualStyleBackColor = false;
			this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
			// 
			// lb_tarih
			// 
			this.lb_tarih.AutoSize = true;
			this.lb_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tarih.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_tarih.Location = new System.Drawing.Point(86, 114);
			this.lb_tarih.Name = "lb_tarih";
			this.lb_tarih.Size = new System.Drawing.Size(40, 13);
			this.lb_tarih.TabIndex = 22;
			this.lb_tarih.Text = "Tarih:";
			// 
			// dtp_tarih
			// 
			this.dtp_tarih.Location = new System.Drawing.Point(132, 108);
			this.dtp_tarih.Name = "dtp_tarih";
			this.dtp_tarih.Size = new System.Drawing.Size(170, 20);
			this.dtp_tarih.TabIndex = 3;
			// 
			// tb_demirbas
			// 
			this.tb_demirbas.Location = new System.Drawing.Point(132, 186);
			this.tb_demirbas.MaxLength = 10;
			this.tb_demirbas.Name = "tb_demirbas";
			this.tb_demirbas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tb_demirbas.Size = new System.Drawing.Size(100, 20);
			this.tb_demirbas.TabIndex = 6;
			this.tb_demirbas.Text = "0";
			this.tb_demirbas.TextChanged += new System.EventHandler(this.tb_Tutar_TextChanged);
			this.tb_demirbas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// lb_demirbas
			// 
			this.lb_demirbas.AutoSize = true;
			this.lb_demirbas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_demirbas.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_demirbas.Location = new System.Drawing.Point(12, 189);
			this.lb_demirbas.Name = "lb_demirbas";
			this.lb_demirbas.Size = new System.Drawing.Size(114, 13);
			this.lb_demirbas.TabIndex = 24;
			this.lb_demirbas.Text = "Demirbaş Giderleri:";
			// 
			// tb_toplam
			// 
			this.tb_toplam.Location = new System.Drawing.Point(132, 212);
			this.tb_toplam.MaxLength = 10;
			this.tb_toplam.Name = "tb_toplam";
			this.tb_toplam.ReadOnly = true;
			this.tb_toplam.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tb_toplam.Size = new System.Drawing.Size(100, 20);
			this.tb_toplam.TabIndex = 7;
			this.tb_toplam.Text = "0";
			// 
			// lb_toplam
			// 
			this.lb_toplam.AutoSize = true;
			this.lb_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_toplam.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_toplam.Location = new System.Drawing.Point(40, 215);
			this.lb_toplam.Name = "lb_toplam";
			this.lb_toplam.Size = new System.Drawing.Size(86, 13);
			this.lb_toplam.TabIndex = 26;
			this.lb_toplam.Text = "Toplam Tutar:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(330, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(330, 24);
			this.label1.TabIndex = 27;
			this.label1.Text = "Aidat Girdisi";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AidatEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(314, 295);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_toplam);
			this.Controls.Add(this.tb_toplam);
			this.Controls.Add(this.lb_demirbas);
			this.Controls.Add(this.tb_demirbas);
			this.Controls.Add(this.lb_tarih);
			this.Controls.Add(this.dtp_tarih);
			this.Controls.Add(this.bt_onayla);
			this.Controls.Add(this.cb_daireNo);
			this.Controls.Add(this.tb_ortakTutar);
			this.Controls.Add(this.tb_tutar);
			this.Controls.Add(this.tb_aidatNo);
			this.Controls.Add(this.lb_odenenTutar);
			this.Controls.Add(this.lb_tutar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lb_aidatNo);
			this.MaximumSize = new System.Drawing.Size(330, 334);
			this.MinimumSize = new System.Drawing.Size(330, 334);
			this.Name = "AidatEkle";
			this.Text = "Aidat Girdisi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_aidatNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lb_tutar;
		private System.Windows.Forms.Label lb_odenenTutar;
		private System.Windows.Forms.TextBox tb_aidatNo;
		private System.Windows.Forms.TextBox tb_tutar;
		private System.Windows.Forms.TextBox tb_ortakTutar;
		private System.Windows.Forms.Button bt_onayla;
		private System.Windows.Forms.Label lb_tarih;
		private System.Windows.Forms.DateTimePicker dtp_tarih;
		private System.Windows.Forms.ComboBox cb_daireNo;
		private System.Windows.Forms.TextBox tb_demirbas;
		private System.Windows.Forms.Label lb_demirbas;
		private System.Windows.Forms.TextBox tb_toplam;
		private System.Windows.Forms.Label lb_toplam;
		private System.Windows.Forms.Label label1;
	}
}