namespace ApartmanYönetimSistemi
{
	partial class YakitEkle
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
			this.bt_onayla = new System.Windows.Forms.Button();
			this.cb_daireNo = new System.Windows.Forms.ComboBox();
			this.tb_alinanKontorMiktari = new System.Windows.Forms.TextBox();
			this.tb_tutar = new System.Windows.Forms.TextBox();
			this.tb_yakitNo = new System.Windows.Forms.TextBox();
			this.lb_odenenTutar = new System.Windows.Forms.Label();
			this.lb_tutar = new System.Windows.Forms.Label();
			this.lb_daireNo = new System.Windows.Forms.Label();
			this.lb_yakitNo = new System.Windows.Forms.Label();
			this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
			this.lb_tarih = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// bt_onayla
			// 
			this.bt_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_onayla.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_onayla.Location = new System.Drawing.Point(111, 193);
			this.bt_onayla.Name = "bt_onayla";
			this.bt_onayla.Size = new System.Drawing.Size(101, 41);
			this.bt_onayla.TabIndex = 6;
			this.bt_onayla.Text = "Onayla";
			this.bt_onayla.UseVisualStyleBackColor = false;
			this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
			// 
			// cb_daireNo
			// 
			this.cb_daireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_daireNo.FormattingEnabled = true;
			this.cb_daireNo.Items.AddRange(new object[] {
            "-"});
			this.cb_daireNo.Location = new System.Drawing.Point(144, 82);
			this.cb_daireNo.Name = "cb_daireNo";
			this.cb_daireNo.Size = new System.Drawing.Size(100, 21);
			this.cb_daireNo.TabIndex = 2;
			// 
			// tb_alinanKontorMiktari
			// 
			this.tb_alinanKontorMiktari.Location = new System.Drawing.Point(144, 161);
			this.tb_alinanKontorMiktari.MaxLength = 10;
			this.tb_alinanKontorMiktari.Name = "tb_alinanKontorMiktari";
			this.tb_alinanKontorMiktari.Size = new System.Drawing.Size(100, 20);
			this.tb_alinanKontorMiktari.TabIndex = 5;
			// 
			// tb_tutar
			// 
			this.tb_tutar.Location = new System.Drawing.Point(144, 135);
			this.tb_tutar.MaxLength = 10;
			this.tb_tutar.Name = "tb_tutar";
			this.tb_tutar.Size = new System.Drawing.Size(100, 20);
			this.tb_tutar.TabIndex = 4;
			// 
			// tb_yakitNo
			// 
			this.tb_yakitNo.Location = new System.Drawing.Point(144, 56);
			this.tb_yakitNo.MaxLength = 20;
			this.tb_yakitNo.Name = "tb_yakitNo";
			this.tb_yakitNo.Size = new System.Drawing.Size(100, 20);
			this.tb_yakitNo.TabIndex = 1;
			// 
			// lb_odenenTutar
			// 
			this.lb_odenenTutar.AutoSize = true;
			this.lb_odenenTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_odenenTutar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_odenenTutar.Location = new System.Drawing.Point(9, 164);
			this.lb_odenenTutar.Name = "lb_odenenTutar";
			this.lb_odenenTutar.Size = new System.Drawing.Size(129, 13);
			this.lb_odenenTutar.TabIndex = 13;
			this.lb_odenenTutar.Text = "Alınan Kontör Miktarı:";
			// 
			// lb_tutar
			// 
			this.lb_tutar.AutoSize = true;
			this.lb_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tutar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_tutar.Location = new System.Drawing.Point(97, 138);
			this.lb_tutar.Name = "lb_tutar";
			this.lb_tutar.Size = new System.Drawing.Size(41, 13);
			this.lb_tutar.TabIndex = 12;
			this.lb_tutar.Text = "Tutar:";
			// 
			// lb_daireNo
			// 
			this.lb_daireNo.AutoSize = true;
			this.lb_daireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireNo.Location = new System.Drawing.Point(77, 85);
			this.lb_daireNo.Name = "lb_daireNo";
			this.lb_daireNo.Size = new System.Drawing.Size(61, 13);
			this.lb_daireNo.TabIndex = 11;
			this.lb_daireNo.Text = "Daire No:";
			// 
			// lb_yakitNo
			// 
			this.lb_yakitNo.AutoSize = true;
			this.lb_yakitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_yakitNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_yakitNo.Location = new System.Drawing.Point(78, 59);
			this.lb_yakitNo.Name = "lb_yakitNo";
			this.lb_yakitNo.Size = new System.Drawing.Size(60, 13);
			this.lb_yakitNo.TabIndex = 10;
			this.lb_yakitNo.Text = "Yakıt No:";
			// 
			// dtp_tarih
			// 
			this.dtp_tarih.Location = new System.Drawing.Point(144, 109);
			this.dtp_tarih.Name = "dtp_tarih";
			this.dtp_tarih.Size = new System.Drawing.Size(170, 20);
			this.dtp_tarih.TabIndex = 3;
			// 
			// lb_tarih
			// 
			this.lb_tarih.AutoSize = true;
			this.lb_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_tarih.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_tarih.Location = new System.Drawing.Point(98, 115);
			this.lb_tarih.Name = "lb_tarih";
			this.lb_tarih.Size = new System.Drawing.Size(40, 13);
			this.lb_tarih.TabIndex = 20;
			this.lb_tarih.Text = "Tarih:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.MidnightBlue;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(-8, 9);
			this.label3.MinimumSize = new System.Drawing.Size(338, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(338, 24);
			this.label3.TabIndex = 30;
			this.label3.Text = "Yakit Girdileri";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// YakitEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(322, 246);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lb_tarih);
			this.Controls.Add(this.dtp_tarih);
			this.Controls.Add(this.bt_onayla);
			this.Controls.Add(this.cb_daireNo);
			this.Controls.Add(this.tb_alinanKontorMiktari);
			this.Controls.Add(this.tb_tutar);
			this.Controls.Add(this.tb_yakitNo);
			this.Controls.Add(this.lb_odenenTutar);
			this.Controls.Add(this.lb_tutar);
			this.Controls.Add(this.lb_daireNo);
			this.Controls.Add(this.lb_yakitNo);
			this.MaximumSize = new System.Drawing.Size(338, 285);
			this.MinimumSize = new System.Drawing.Size(338, 285);
			this.Name = "YakitEkle";
			this.Text = "Yakıt Girdisi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_onayla;
		private System.Windows.Forms.ComboBox cb_daireNo;
		private System.Windows.Forms.TextBox tb_alinanKontorMiktari;
		private System.Windows.Forms.TextBox tb_tutar;
		private System.Windows.Forms.TextBox tb_yakitNo;
		private System.Windows.Forms.Label lb_odenenTutar;
		private System.Windows.Forms.Label lb_tutar;
		private System.Windows.Forms.Label lb_daireNo;
		private System.Windows.Forms.Label lb_yakitNo;
		private System.Windows.Forms.DateTimePicker dtp_tarih;
		private System.Windows.Forms.Label lb_tarih;
		private System.Windows.Forms.Label label3;
	}
}