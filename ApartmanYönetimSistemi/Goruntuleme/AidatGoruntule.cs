using IslemKatmani;
using System;
using System.Data;
using System.Windows.Forms;

namespace ApartmanYönetimSistemi.Goruntuleme
{
	public partial class AidatGoruntule : Form
	{
		string filtre, daire;
		string id;
		DataTable dt;
		int en, boy;

		public AidatGoruntule()
		{
			InitializeComponent();
			en = this.Size.Width;
			boy = this.Size.Height;
			dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
			dataGridView1.DataSource = dt;
			if (dataGridView1.Rows[0].Cells[0].Value != null)
			{
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
				daire = dataGridView1.Rows[0].Cells[1].Value.ToString();
			}
				
		}

		private void rb_CheckedChanged(object sender, EventArgs e)
		{
			filtre = ((RadioButton)sender).Tag.ToString();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = dataGridView1.CurrentRow.Cells["Aidat Makbuz No"].Value.ToString();
			daire = dataGridView1.CurrentRow.Cells["Daire Numarası"].Value.ToString();
		}

		private void bt_filtrele_Click(object sender, EventArgs e)
		{
			if (!rb_daireNo.Checked && !rb_tarih.Checked || textBox1.Text == "")
			{
				MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
				dataGridView1.DataSource = dt;
			}
			else
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.Filtre("Aidat", filtre, aranan: textBox1.Text));
			dataGridView1.Update();
			rb_tarih.Checked = true;
			rb_tarih.Checked = false;
			textBox1.Clear();
		}

		private void bt_daireEkle_Click(object sender, EventArgs e)
		{
			AidatEkle ai = new AidatEkle();
			ai.ShowDialog();
			dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
			dataGridView1.DataSource = dt;
			dataGridView1.Update();
			if (dataGridView1.Rows[0].Cells[0].Value != null)
			{
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
				daire = dataGridView1.Rows[0].Cells[1].Value.ToString();
			}
		}

		private void bt_duzenle_Click(object sender, EventArgs e)
		{
			if (id == null)
				MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
			else
			{
				AidatEkle ai = new AidatEkle(VeriIslemleri.BilgileriAl("Aidat", "AidatNo", id));
				ai.ShowDialog();
				dt= VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
				dataGridView1.DataSource = dt;
				dataGridView1.Update();
			}
		}

		private void bt_sil_Click(object sender, EventArgs e)
		{
			bool durum = false;
			if (id == null)
				MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
			else
			{
				DialogResult cevap = MessageBox.Show(id + " Numaralı Makbuz Kaydı Silinecek. Silmek İstediğinize Emin Misiniz?", "Makbuz Silinecek", MessageBoxButtons.OKCancel);
				if (cevap.ToString() == "OK")
					durum = VeriIslemleri.VeriSil("Aidat", "AidatNo", id);
			}
			if (durum)
			{
				MessageBox.Show("Silme işlemi başarılı!");
				dt = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
				dataGridView1.DataSource = dt;
				dataGridView1.Update();
			}
		}

		private void button1_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dataGridView1);

		private void bt_aidatTutar_Click(object sender, EventArgs e)
		{
			MessageBox.Show(daire + " Nolu Dairenin Toplam Ödediği Aidat Tutarı\n-> "+ VeriIslemleri.AidatToplamBul(daire) + "₺");
		}

		private void AidatGoruntule_Resize(object sender, EventArgs e)
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

		/*private void bt_otomatikAidatEkle_Click(object sender, EventArgs e)
		{
			Ekle.OtomatikAidatEkle oae = new Ekle.OtomatikAidatEkle();
			oae.ShowDialog();
			dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Aidat", VeriIslemleri.BilgileriGetir("Aidat", "AidatNo"));
			dataGridView1.Update();
		}*/
	}
}
