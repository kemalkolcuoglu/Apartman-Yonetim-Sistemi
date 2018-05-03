namespace ApartmanYönetimSistemi
{
	partial class KullaniciSifreDegistir
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
			this.lb_gecerliSifre = new System.Windows.Forms.Label();
			this.lb_yeniSifre = new System.Windows.Forms.Label();
			this.lb_yeniTekrar = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.cb_sifreGoster = new System.Windows.Forms.CheckBox();
			this.bt_onayla = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_gecerliSifre
			// 
			this.lb_gecerliSifre.AutoSize = true;
			this.lb_gecerliSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_gecerliSifre.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_gecerliSifre.Location = new System.Drawing.Point(27, 46);
			this.lb_gecerliSifre.Name = "lb_gecerliSifre";
			this.lb_gecerliSifre.Size = new System.Drawing.Size(81, 13);
			this.lb_gecerliSifre.TabIndex = 0;
			this.lb_gecerliSifre.Text = "Geçerli Şifre:";
			// 
			// lb_yeniSifre
			// 
			this.lb_yeniSifre.AutoSize = true;
			this.lb_yeniSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_yeniSifre.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_yeniSifre.Location = new System.Drawing.Point(42, 72);
			this.lb_yeniSifre.Name = "lb_yeniSifre";
			this.lb_yeniSifre.Size = new System.Drawing.Size(66, 13);
			this.lb_yeniSifre.TabIndex = 1;
			this.lb_yeniSifre.Text = "Yeni Şifre:";
			// 
			// lb_yeniTekrar
			// 
			this.lb_yeniTekrar.AutoSize = true;
			this.lb_yeniTekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_yeniTekrar.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_yeniTekrar.Location = new System.Drawing.Point(19, 98);
			this.lb_yeniTekrar.Name = "lb_yeniTekrar";
			this.lb_yeniTekrar.Size = new System.Drawing.Size(89, 13);
			this.lb_yeniTekrar.TabIndex = 2;
			this.lb_yeniTekrar.Text = "Şifreyi Onayla:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(114, 43);
			this.textBox1.MaxLength = 8;
			this.textBox1.Name = "textBox1";
			this.textBox1.PasswordChar = '*';
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(114, 69);
			this.textBox2.MaxLength = 8;
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(114, 95);
			this.textBox3.MaxLength = 8;
			this.textBox3.Name = "textBox3";
			this.textBox3.PasswordChar = '*';
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
			// 
			// cb_sifreGoster
			// 
			this.cb_sifreGoster.AutoSize = true;
			this.cb_sifreGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cb_sifreGoster.ForeColor = System.Drawing.Color.MidnightBlue;
			this.cb_sifreGoster.Location = new System.Drawing.Point(65, 135);
			this.cb_sifreGoster.Name = "cb_sifreGoster";
			this.cb_sifreGoster.Size = new System.Drawing.Size(102, 17);
			this.cb_sifreGoster.TabIndex = 6;
			this.cb_sifreGoster.Text = "Şifreyi Göster";
			this.cb_sifreGoster.UseVisualStyleBackColor = true;
			this.cb_sifreGoster.CheckedChanged += new System.EventHandler(this.cb_sifreGoster_CheckStateChanged);
			// 
			// bt_onayla
			// 
			this.bt_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_onayla.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_onayla.Location = new System.Drawing.Point(65, 158);
			this.bt_onayla.Name = "bt_onayla";
			this.bt_onayla.Size = new System.Drawing.Size(101, 41);
			this.bt_onayla.TabIndex = 9;
			this.bt_onayla.Text = "Onayla";
			this.bt_onayla.UseVisualStyleBackColor = false;
			this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(242, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Şifre Değiştir";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KullaniciSifreDegistir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(226, 203);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_onayla);
			this.Controls.Add(this.cb_sifreGoster);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lb_yeniTekrar);
			this.Controls.Add(this.lb_yeniSifre);
			this.Controls.Add(this.lb_gecerliSifre);
			this.MaximumSize = new System.Drawing.Size(242, 242);
			this.MinimumSize = new System.Drawing.Size(242, 242);
			this.Name = "KullaniciSifreDegistir";
			this.Text = "Kullanıcı Şifresi Değiştir - KKY Site Yönetim Sistemi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_gecerliSifre;
		private System.Windows.Forms.Label lb_yeniSifre;
		private System.Windows.Forms.Label lb_yeniTekrar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.CheckBox cb_sifreGoster;
		private System.Windows.Forms.Button bt_onayla;
		private System.Windows.Forms.Label label1;
	}
}