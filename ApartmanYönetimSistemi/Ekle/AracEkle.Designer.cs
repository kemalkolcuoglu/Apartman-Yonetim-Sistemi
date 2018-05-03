namespace ApartmanYönetimSistemi
{
	partial class AracEkle
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
			this.lb_plaka = new System.Windows.Forms.Label();
			this.lb_marka = new System.Windows.Forms.Label();
			this.lb_model = new System.Windows.Forms.Label();
			this.tb_plaka = new System.Windows.Forms.TextBox();
			this.tb_marka = new System.Windows.Forms.TextBox();
			this.tb_model = new System.Windows.Forms.TextBox();
			this.bt_onayla = new System.Windows.Forms.Button();
			this.cb_DaireNo = new System.Windows.Forms.ComboBox();
			this.lb_daireNo = new System.Windows.Forms.Label();
			this.tb_telefonNo = new System.Windows.Forms.TextBox();
			this.lb_telefonNo = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_plaka
			// 
			this.lb_plaka.AutoSize = true;
			this.lb_plaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_plaka.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_plaka.Location = new System.Drawing.Point(23, 60);
			this.lb_plaka.Name = "lb_plaka";
			this.lb_plaka.Size = new System.Drawing.Size(73, 13);
			this.lb_plaka.TabIndex = 0;
			this.lb_plaka.Text = "Araç Plaka:";
			// 
			// lb_marka
			// 
			this.lb_marka.AutoSize = true;
			this.lb_marka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_marka.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_marka.Location = new System.Drawing.Point(50, 86);
			this.lb_marka.Name = "lb_marka";
			this.lb_marka.Size = new System.Drawing.Size(46, 13);
			this.lb_marka.TabIndex = 1;
			this.lb_marka.Text = "Marka:";
			// 
			// lb_model
			// 
			this.lb_model.AutoSize = true;
			this.lb_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_model.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_model.Location = new System.Drawing.Point(51, 112);
			this.lb_model.Name = "lb_model";
			this.lb_model.Size = new System.Drawing.Size(45, 13);
			this.lb_model.TabIndex = 2;
			this.lb_model.Text = "Model:";
			// 
			// tb_plaka
			// 
			this.tb_plaka.Location = new System.Drawing.Point(102, 57);
			this.tb_plaka.MaxLength = 10;
			this.tb_plaka.Name = "tb_plaka";
			this.tb_plaka.Size = new System.Drawing.Size(100, 20);
			this.tb_plaka.TabIndex = 1;
			this.tb_plaka.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_plaka_KeyPress);
			// 
			// tb_marka
			// 
			this.tb_marka.Location = new System.Drawing.Point(102, 83);
			this.tb_marka.MaxLength = 25;
			this.tb_marka.Name = "tb_marka";
			this.tb_marka.Size = new System.Drawing.Size(100, 20);
			this.tb_marka.TabIndex = 2;
			// 
			// tb_model
			// 
			this.tb_model.Location = new System.Drawing.Point(102, 109);
			this.tb_model.MaxLength = 25;
			this.tb_model.Name = "tb_model";
			this.tb_model.Size = new System.Drawing.Size(100, 20);
			this.tb_model.TabIndex = 3;
			// 
			// bt_onayla
			// 
			this.bt_onayla.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bt_onayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.bt_onayla.ForeColor = System.Drawing.Color.MidnightBlue;
			this.bt_onayla.Location = new System.Drawing.Point(62, 201);
			this.bt_onayla.Name = "bt_onayla";
			this.bt_onayla.Size = new System.Drawing.Size(101, 41);
			this.bt_onayla.TabIndex = 6;
			this.bt_onayla.Text = "Onayla";
			this.bt_onayla.UseVisualStyleBackColor = false;
			this.bt_onayla.Click += new System.EventHandler(this.bt_onayla_Click);
			// 
			// cb_DaireNo
			// 
			this.cb_DaireNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_DaireNo.FormattingEnabled = true;
			this.cb_DaireNo.Items.AddRange(new object[] {
            "-"});
			this.cb_DaireNo.Location = new System.Drawing.Point(102, 135);
			this.cb_DaireNo.Name = "cb_DaireNo";
			this.cb_DaireNo.Size = new System.Drawing.Size(100, 21);
			this.cb_DaireNo.TabIndex = 4;
			// 
			// lb_daireNo
			// 
			this.lb_daireNo.AutoSize = true;
			this.lb_daireNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_daireNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_daireNo.Location = new System.Drawing.Point(35, 138);
			this.lb_daireNo.Name = "lb_daireNo";
			this.lb_daireNo.Size = new System.Drawing.Size(61, 13);
			this.lb_daireNo.TabIndex = 7;
			this.lb_daireNo.Text = "Daire No:";
			// 
			// tb_telefonNo
			// 
			this.tb_telefonNo.Location = new System.Drawing.Point(102, 162);
			this.tb_telefonNo.MaxLength = 15;
			this.tb_telefonNo.Name = "tb_telefonNo";
			this.tb_telefonNo.Size = new System.Drawing.Size(100, 20);
			this.tb_telefonNo.TabIndex = 5;
			// 
			// lb_telefonNo
			// 
			this.lb_telefonNo.AutoSize = true;
			this.lb_telefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lb_telefonNo.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lb_telefonNo.Location = new System.Drawing.Point(32, 165);
			this.lb_telefonNo.Name = "lb_telefonNo";
			this.lb_telefonNo.Size = new System.Drawing.Size(64, 13);
			this.lb_telefonNo.TabIndex = 10;
			this.lb_telefonNo.Text = "İrtibat No:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.MidnightBlue;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(-8, 9);
			this.label1.MinimumSize = new System.Drawing.Size(240, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 24);
			this.label1.TabIndex = 28;
			this.label1.Text = "Taşıtlar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AracEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(224, 254);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_telefonNo);
			this.Controls.Add(this.tb_telefonNo);
			this.Controls.Add(this.cb_DaireNo);
			this.Controls.Add(this.lb_daireNo);
			this.Controls.Add(this.bt_onayla);
			this.Controls.Add(this.tb_model);
			this.Controls.Add(this.tb_marka);
			this.Controls.Add(this.tb_plaka);
			this.Controls.Add(this.lb_model);
			this.Controls.Add(this.lb_marka);
			this.Controls.Add(this.lb_plaka);
			this.MaximumSize = new System.Drawing.Size(240, 293);
			this.MinimumSize = new System.Drawing.Size(240, 293);
			this.Name = "AracEkle";
			this.Text = "Taşıtlar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_plaka;
		private System.Windows.Forms.Label lb_marka;
		private System.Windows.Forms.Label lb_model;
		private System.Windows.Forms.TextBox tb_plaka;
		private System.Windows.Forms.TextBox tb_marka;
		private System.Windows.Forms.TextBox tb_model;
		private System.Windows.Forms.Button bt_onayla;
		private System.Windows.Forms.ComboBox cb_DaireNo;
		private System.Windows.Forms.Label lb_daireNo;
		private System.Windows.Forms.TextBox tb_telefonNo;
		private System.Windows.Forms.Label lb_telefonNo;
		private System.Windows.Forms.Label label1;
	}
}