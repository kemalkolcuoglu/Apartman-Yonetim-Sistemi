using IslemKatmani;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Core;
using Microsoft.Office.Interop;

namespace ApartmanYönetimSistemi.Goruntuleme
{
	public partial class DaireGoruntule : Form
	{
		string filtre;
		string daire;
		DataTable dt;
		int en, boy;
		public DaireGoruntule()
		{
			InitializeComponent();
			en = this.Size.Width;
			boy = this.Size.Height;
			dt = VeriIslemleri.TabloDoldur("Daire", VeriIslemleri.BilgileriGetir("Daire", "DaireNo"));
			dataGridView1.DataSource = dt;
			if (dataGridView1.Rows[0].Cells[0].Value != null)
				daire = dataGridView1.Rows[0].Cells[0].Value.ToString();
		}

		private void rb_daireDurum_CheckedChanged(object sender, EventArgs e)
		{
			filtre = ((RadioButton)sender).Tag.ToString();
		}
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			daire = dataGridView1.CurrentRow.Cells["Daire Numarası"].Value.ToString();
		}
		private void bt_filtrele_Click(object sender, EventArgs e)
		{
			if (!rb_daireDurum.Checked && !rb_daireSahibi.Checked && !rb_daireSakini.Checked || textBox1.Text == "")
			{
				MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
				dataGridView1.DataSource = dt;
			}
			else
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Daire", VeriIslemleri.Filtre("Daire", filtre, aranan: textBox1.Text));
			dataGridView1.Update();
			rb_daireDurum.Checked = true;
			rb_daireDurum.Checked = false;
			textBox1.Clear();
		}

		private void bt_daireEkle_Click(object sender, EventArgs e)
		{
			DaireEkle de = new DaireEkle();
			de.ShowDialog();
			dt = VeriIslemleri.TabloDoldur("Daire", VeriIslemleri.BilgileriGetir("Daire", "DaireNo"));
			dataGridView1.DataSource = dt;
			dataGridView1.Update();
			if (dataGridView1.Rows[0].Cells[0].Value != null)
				daire = dataGridView1.Rows[0].Cells[0].Value.ToString();
		}

		private void bt_duzenle_Click(object sender, EventArgs e)
		{
			if (daire == null)
				MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
			else
			{
				DaireEkle de = new DaireEkle(VeriIslemleri.BilgileriAl("Daire", "DaireNo", daire));
				de.ShowDialog();
				dt = VeriIslemleri.TabloDoldur("Daire", VeriIslemleri.BilgileriGetir("Daire", "DaireNo"));
				dataGridView1.DataSource = dt;
				dataGridView1.Update();
			}
		}

		private void bt_sil_Click(object sender, EventArgs e)
		{
			bool durum = false;
			if (daire == null)
				MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
			else
			{
				DialogResult cevap = MessageBox.Show(daire + " Numaralı Daire Silinecek. Silmek İstediğinize Emin Misiniz?", "Daire Silinecek", MessageBoxButtons.OKCancel);
				if (cevap.ToString() == "OK")
					durum = VeriIslemleri.VeriSil("Daire", "DaireNo", daire);
			}
			if (durum)
			{
				MessageBox.Show("Silme işlemi başarılı!");
				dt = VeriIslemleri.TabloDoldur("Daire", VeriIslemleri.BilgileriGetir("Daire", "DaireNo"));
				dataGridView1.DataSource = dt;
				dataGridView1.Update();
			}
		}

		private void button1_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dataGridView1);

		private void bt_eskiDaire_Click(object sender, EventArgs e)
		{
			EskiDaireGoruntule edg = new EskiDaireGoruntule();
			edg.ShowDialog();
		}

		private void DaireGoruntule_Resize(object sender, EventArgs e)
		{
			int boyfark = this.Size.Height - boy;
			int enfark = this.Size.Width - en;
			if (this.Size.Width > en || this.Size.Width < en)
			{
				dataGridView1.Width += enfark;
				en = this.Size.Width;
			}
			if (this.Size.Height > boy || this.Size.Height < boy)
			{
				dataGridView1.Height += boyfark;
				boy = this.Size.Height;
			}
		}
	}
}
