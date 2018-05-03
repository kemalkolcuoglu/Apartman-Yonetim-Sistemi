namespace ApartmanYönetimSistemi
{
	partial class DaireEkle
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
			this.cb_DaireDurum = new System.Windows.Forms.ComboBox();
			this.lb_durum = new System.Windows.Forms.Label();
			this.lb_daireNo = new System.Windows.Forms.Label();
			this.tb_daireNo = new System.Windows.Forms.TextBox();
			this.nud_kat = new System.Windows.Forms.NumericUpDown();
			this.lb_kat = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nud_kat)).BeginInit();
			this.SuspendLayout();
			// 
			// bt_kaydet
			// 
			this.bt_kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_kaydet.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_kaydet.Location = new System.Drawing.Point(77, 191);
			this.bt_kaydet.Name = "bt_kaydet";
			this.bt_kaydet.Size = new System.Drawing.Size(101, 41);
			this.bt_kaydet.TabIndex = 6;
			this.bt_kaydet.Text = "Onayla";
			this.bt_kaydet.UseVisualStyleBackColor = false;
			this.bt_kaydet.Click += new System.EventHandler(this.bt_kaydet_Click);
			// 
			// cb_DaireSakini
			// 
			this.cb_DaireSakini.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireSakini.FormattingEnabled = true;
			this.cb_DaireSakini.Location = new System.Drawing.Point(118, 130);
			this.cb_DaireSakini.Name = "cb_DaireSakini";
			this.cb_DaireSakini.Size = new System.Drawing.Size(121, 21);
			this.cb_DaireSakini.TabIndex = 4;
			// 
			// lb_daireSakini
			// 
			this.lb_daireSakini.AutoSize = true;
			this.lb_daireSakini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireSakini.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireSakini.Location = new System.Drawing.Point(32, 138);
			this.lb_daireSakini.Name = "lb_daireSakini";
			this.lb_daireSakini.Size = new System.Drawing.Size(80, 13);
			this.lb_daireSakini.TabIndex = 17;
			this.lb_daireSakini.Text = "Daire Sakini:";
			// 
			// cb_DaireSahibi
			// 
			this.cb_DaireSahibi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireSahibi.FormattingEnabled = true;
			this.cb_DaireSahibi.Location = new System.Drawing.Point(118, 103);
			this.cb_DaireSahibi.Name = "cb_DaireSahibi";
			this.cb_DaireSahibi.Size = new System.Drawing.Size(121, 21);
			this.cb_DaireSahibi.TabIndex = 3;
			// 
			// lb_daireSahibi
			// 
			this.lb_daireSahibi.AutoSize = true;
			this.lb_daireSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireSahibi.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireSahibi.Location = new System.Drawing.Point(32, 111);
			this.lb_daireSahibi.Name = "lb_daireSahibi";
			this.lb_daireSahibi.Size = new System.Drawing.Size(80, 13);
			this.lb_daireSahibi.TabIndex = 15;
			this.lb_daireSahibi.Text = "Daire Sahibi:";
			// 
			// cb_DaireDurum
			// 
			this.cb_DaireDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireDurum.FormattingEnabled = true;
			this.cb_DaireDurum.Items.AddRange(new object[] {
            "-",
            "Sahibi",
            "Kiracı"});
			this.cb_DaireDurum.Location = new System.Drawing.Point(118, 76);
			this.cb_DaireDurum.Name = "cb_DaireDurum";
			this.cb_DaireDurum.Size = new System.Drawing.Size(121, 21);
			this.cb_DaireDurum.TabIndex = 2;
			// 
			// lb_durum
			// 
			this.lb_durum.AutoSize = true;
			this.lb_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_durum.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_durum.Location = new System.Drawing.Point(24, 84);
			this.lb_durum.Name = "lb_durum";
			this.lb_durum.Size = new System.Drawing.Size(88, 13);
			this.lb_durum.TabIndex = 13;
			this.lb_durum.Text = "Daire Durumu:";
			// 
			// lb_daireNo
			// 
			this.lb_daireNo.AutoSize = true;
			this.lb_daireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireNo.Location = new System.Drawing.Point(15, 55);
			this.lb_daireNo.Name = "lb_daireNo";
			this.lb_daireNo.Size = new System.Drawing.Size(97, 13);
			this.lb_daireNo.TabIndex = 11;
			this.lb_daireNo.Text = "Daire Numarası:";
			// 
			// tb_daireNo
			// 
			this.tb_daireNo.Location = new System.Drawing.Point(118, 52);
			this.tb_daireNo.MaxLength = 4;
			this.tb_daireNo.Name = "tb_daireNo";
			this.tb_daireNo.Size = new System.Drawing.Size(121, 20);
			this.tb_daireNo.TabIndex = 1;
			// 
			// nud_kat
			// 
			this.nud_kat.Location = new System.Drawing.Point(119, 157);
			this.nud_kat.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.nud_kat.Name = "nud_kat";
			this.nud_kat.Size = new System.Drawing.Size(120, 20);
			this.nud_kat.TabIndex = 5;
			// 
			// lb_kat
			// 
			this.lb_kat.AutoSize = true;
			this.lb_kat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_kat.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_kat.Location = new System.Drawing.Point(82, 159);
			this.lb_kat.Name = "lb_kat";
			this.lb_kat.Size = new System.Drawing.Size(30, 13);
			this.lb_kat.TabIndex = 26;
			this.lb_kat.Text = "Kat:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(270, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 24);
			this.label1.TabIndex = 28;
			this.label1.Text = "Daireler";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DaireEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(254, 244);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_kat);
			this.Controls.Add(this.nud_kat);
			this.Controls.Add(this.tb_daireNo);
			this.Controls.Add(this.bt_kaydet);
			this.Controls.Add(this.cb_DaireSakini);
			this.Controls.Add(this.lb_daireSakini);
			this.Controls.Add(this.cb_DaireSahibi);
			this.Controls.Add(this.lb_daireSahibi);
			this.Controls.Add(this.cb_DaireDurum);
			this.Controls.Add(this.lb_durum);
			this.Controls.Add(this.lb_daireNo);
			this.MaximumSize = new System.Drawing.Size(270, 283);
			this.MinimumSize = new System.Drawing.Size(270, 283);
			this.Name = "DaireEkle";
			this.Text = "Daireler";
			((System.ComponentModel.ISupportInitialize)(this.nud_kat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_kaydet;
		private System.Windows.Forms.ComboBox cb_DaireSakini;
		private System.Windows.Forms.Label lb_daireSakini;
		private System.Windows.Forms.ComboBox cb_DaireSahibi;
		private System.Windows.Forms.Label lb_daireSahibi;
		private System.Windows.Forms.ComboBox cb_DaireDurum;
		private System.Windows.Forms.Label lb_durum;
		private System.Windows.Forms.Label lb_daireNo;
		private System.Windows.Forms.TextBox tb_daireNo;
		private System.Windows.Forms.NumericUpDown nud_kat;
		private System.Windows.Forms.Label lb_kat;
		private System.Windows.Forms.Label label1;
	}
}