using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IslemKatmani;

namespace ApartmanYönetimSistemi.Goruntuleme
{
	public partial class KisiGoruntule : Form
	{
		string filtre;
		string kisi;
		string id;
		int en, boy;
		DataTable dt;
		public KisiGoruntule()
		{
			InitializeComponent();
			en = this.Size.Width;
			boy = this.Size.Height;
			dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
			dataGridView1.DataSource = dt;
			if (dataGridView1.Rows[0].Cells[0].Value != null)
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
		}

		private void bt_kisiEkle_Click(object sender, EventArgs e)
		{
			KisiEkle ke = new KisiEkle();
			ke.ShowDialog();
			dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
			dataGridView1.DataSource = dt;
			dataGridView1.Update();
			try
			{
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
			}
			catch
			{ }
		}

		private void bt_filtrele_Click(object sender, EventArgs e)
		{
			if (!rb_sahipKiraci.Checked && !rb_ad.Checked && !rb_soyad.Checked & !rb_girisTarihi.Checked && !rb_cikisTarihi.Checked || textBox1.Text == "")
			{
				MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
				dataGridView1.DataSource = dt;
			}
			else
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.Filtre("Kisi", filtre, aranan: textBox1.Text));
			dataGridView1.Update();
			rb_ad.Checked = true;
			rb_ad.Checked = false;
			textBox1.Clear();
		}
		private void rb_CheckedChanged(object sender, EventArgs e)
		{
			filtre = ((RadioButton)sender).Tag.ToString();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			kisi = dataGridView1.CurrentRow.Cells["Ad"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["Soyad"].Value.ToString();
			id = dataGridView1.CurrentRow.Cells["Kişi Numarası"].Value.ToString();
		}

		private void bt_duzenle_Click(object sender, EventArgs e)
		{
			if (id == null)
				MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
			else
			{
				string[] bilgiler = VeriIslemleri.BilgileriAl("Kisi", "KisiID", id);
				KisiEkle ke = new KisiEkle(bilgiler);
				ke.ShowDialog();
				dt = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
				dataGridView1.DataSource = dt;
				dataGridView1.Update();
			}
		}

		private void bt_sil_Click(object sender, EventArgs e)
		{
			bool durum = false;
			if (kisi == null)
				MessageBox.Show("Lütfen tablodan silinecek değeri seçiniz!");
			else
			{
				DialogResult cevap = MessageBox.Show(kisi + " Silinecek. Silmek İstediğinize Emin Misiniz?", "Kişi Silinecek", MessageBoxButtons.OKCancel);
				if (cevap.ToString() == "OK")
					durum = VeriIslemleri.VeriSil("Kisi", "KisiID", id);
			}
			if(durum)
			{
				MessageBox.Show("Silme işlemi başarılı!");
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Kisi", VeriIslemleri.BilgileriGetir("Kisi", "KisiID"));
				dataGridView1.Update();
			}
		}

		private void button1_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dataGridView1);

		private void KisiGoruntule_Resize(object sender, EventArgs e)
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
