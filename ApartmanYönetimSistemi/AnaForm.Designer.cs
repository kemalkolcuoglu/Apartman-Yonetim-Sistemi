namespace ApartmanYönetimSistemi
{
	partial class AnaForm
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.lb_kullaniciAdi = new System.Windows.Forms.Label();
			this.tb_kullaniciAdi = new System.Windows.Forms.TextBox();
			this.lb_sifre = new System.Windows.Forms.Label();
			this.tb_sifre = new System.Windows.Forms.TextBox();
			this.bt_giris = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_kullaniciAdi
			// 
			this.lb_kullaniciAdi.AutoSize = true;
			this.lb_kullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_kullaniciAdi.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_kullaniciAdi.Location = new System.Drawing.Point(25, 74);
			this.lb_kullaniciAdi.Name = "lb_kullaniciAdi";
			this.lb_kullaniciAdi.Size = new System.Drawing.Size(111, 20);
			this.lb_kullaniciAdi.TabIndex = 0;
			this.lb_kullaniciAdi.Text = "Kullanıcı Adı:";
			// 
			// tb_kullaniciAdi
			// 
			this.tb_kullaniciAdi.Location = new System.Drawing.Point(142, 74);
			this.tb_kullaniciAdi.MaxLength = 10;
			this.tb_kullaniciAdi.Name = "tb_kullaniciAdi";
			this.tb_kullaniciAdi.Size = new System.Drawing.Size(142, 20);
			this.tb_kullaniciAdi.TabIndex = 1;
			// 
			// lb_sifre
			// 
			this.lb_sifre.AutoSize = true;
			this.lb_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_sifre.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_sifre.Location = new System.Drawing.Point(84, 110);
			this.lb_sifre.Name = "lb_sifre";
			this.lb_sifre.Size = new System.Drawing.Size(52, 20);
			this.lb_sifre.TabIndex = 2;
			this.lb_sifre.Text = "Şifre:";
			// 
			// tb_sifre
			// 
			this.tb_sifre.Location = new System.Drawing.Point(142, 110);
			this.tb_sifre.MaxLength = 10;
			this.tb_sifre.Name = "tb_sifre";
			this.tb_sifre.PasswordChar = '*';
			this.tb_sifre.Size = new System.Drawing.Size(142, 20);
			this.tb_sifre.TabIndex = 3;
			// 
			// bt_giris
			// 
			this.bt_giris.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_giris.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_giris.Location = new System.Drawing.Point(112, 151);
			this.bt_giris.Name = "bt_giris";
			this.bt_giris.Size = new System.Drawing.Size(100, 41);
			this.bt_giris.TabIndex = 4;
			this.bt_giris.Text = "Giriş";
			this.bt_giris.UseVisualStyleBackColor = false;
			this.bt_giris.Click += new System.EventHandler(this.bt_giris_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(340, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(340, 50);
			this.label1.TabIndex = 8;
			this.label1.Text = "Site Yönetim Sistemi\r\nYönetici Girişi";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(324, 204);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_giris);
			this.Controls.Add(this.tb_sifre);
			this.Controls.Add(this.lb_sifre);
			this.Controls.Add(this.tb_kullaniciAdi);
			this.Controls.Add(this.lb_kullaniciAdi);
			this.MaximumSize = new System.Drawing.Size(340, 243);
			this.MinimumSize = new System.Drawing.Size(340, 243);
			this.Name = "AnaForm";
			this.Text = "KKY Site Yönetim Sistemi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_kullaniciAdi;
		private System.Windows.Forms.TextBox tb_kullaniciAdi;
		private System.Windows.Forms.Label lb_sifre;
		private System.Windows.Forms.TextBox tb_sifre;
		private System.Windows.Forms.Button bt_giris;
		private System.Windows.Forms.Label label1;
	}
}

