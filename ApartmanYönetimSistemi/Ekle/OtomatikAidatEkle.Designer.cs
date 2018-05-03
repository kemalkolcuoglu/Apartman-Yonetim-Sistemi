namespace ApartmanYönetimSistemi.Ekle
{
	partial class OtomatikAidatEkle
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
			this.tb_tutar = new System.Windows.Forms.TextBox();
			this.lb_tutar = new System.Windows.Forms.Label();
			this.dtp_tarih = new System.Windows.Forms.DateTimePicker();
			this.lb_tarih = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// bt_onayla
			// 
			this.bt_onayla.Location = new System.Drawing.Point(98, 94);
			this.bt_onayla.Name = "bt_onayla";
			this.bt_onayla.Size = new System.Drawing.Size(75, 23);
			this.bt_onayla.TabIndex = 0;
			this.bt_onayla.Text = "Onayla";
			this.bt_onayla.UseVisualStyleBackColor = true;
			this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
			// 
			// tb_tutar
			// 
			this.tb_tutar.Location = new System.Drawing.Point(73, 55);
			this.tb_tutar.MaxLength = 10;
			this.tb_tutar.Name = "tb_tutar";
			this.tb_tutar.Size = new System.Drawing.Size(100, 20);
			this.tb_tutar.TabIndex = 1;
			// 
			// lb_tutar
			// 
			this.lb_tutar.AutoSize = true;
			this.lb_tutar.Location = new System.Drawing.Point(19, 58);
			this.lb_tutar.Name = "lb_tutar";
			this.lb_tutar.Size = new System.Drawing.Size(35, 13);
			this.lb_tutar.TabIndex = 2;
			this.lb_tutar.Text = "Tutar:";
			// 
			// dtp_tarih
			// 
			this.dtp_tarih.Location = new System.Drawing.Point(73, 29);
			this.dtp_tarih.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
			this.dtp_tarih.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dtp_tarih.Name = "dtp_tarih";
			this.dtp_tarih.Size = new System.Drawing.Size(171, 20);
			this.dtp_tarih.TabIndex = 3;
			this.dtp_tarih.Value = new System.DateTime(2018, 2, 23, 3, 27, 10, 0);
			// 
			// lb_tarih
			// 
			this.lb_tarih.AutoSize = true;
			this.lb_tarih.Location = new System.Drawing.Point(20, 35);
			this.lb_tarih.Name = "lb_tarih";
			this.lb_tarih.Size = new System.Drawing.Size(34, 13);
			this.lb_tarih.TabIndex = 4;
			this.lb_tarih.Text = "Tarih:";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(60, 138);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(151, 23);
			this.progressBar1.TabIndex = 5;
			// 
			// OtomatikAidatEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(261, 173);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.lb_tarih);
			this.Controls.Add(this.dtp_tarih);
			this.Controls.Add(this.lb_tutar);
			this.Controls.Add(this.tb_tutar);
			this.Controls.Add(this.bt_onayla);
			this.Name = "OtomatikAidatEkle";
			this.Text = "OtomatikAidatEkle";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_onayla;
		private System.Windows.Forms.TextBox tb_tutar;
		private System.Windows.Forms.Label lb_tutar;
		private System.Windows.Forms.DateTimePicker dtp_tarih;
		private System.Windows.Forms.Label lb_tarih;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}