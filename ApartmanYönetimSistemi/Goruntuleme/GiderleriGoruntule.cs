using IslemKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYönetimSistemi.Goruntuleme
{
	public partial class GiderleriGoruntule : Form
	{
		string filtre;
		string id;
		int en, boy;
		DataTable dt;
		public GiderleriGoruntule()
		{
			InitializeComponent();
			en = this.Size.Width;
			boy = this.Size.Height;
			dt = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
			dataGridView1.DataSource = dt;
			if (dataGridView1.Rows[0].Cells[0].Value != null)
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
		}

		private void rb_CheckedChanged(object sender, EventArgs e)
		{
			filtre = ((RadioButton)sender).Tag.ToString();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			id = dataGridView1.CurrentRow.Cells["Kayıt Numarası"].Value.ToString();
		}

		private void bt_giderEkle_Click(object sender, EventArgs e)
		{
			Ekle.GiderEkle ge = new Ekle.GiderEkle();
			ge.ShowDialog();
			dt = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
			dataGridView1.DataSource = dt;
			dataGridView1.Update();
			if (dataGridView1.Rows[0].Cells[0].Value != null)
				id = dataGridView1.Rows[0].Cells[0].Value.ToString();
		}
		private void bt_duzenle_Click(object sender, EventArgs e)
		{
			if (id == null)
				MessageBox.Show("Lütfen tablodan düzeltilecek değeri seçiniz!");
			else
			{
				string[] bilgiler = VeriIslemleri.BilgileriAl("Giderler", "GiderID", id);
				Ekle.GiderEkle ge = new Ekle.GiderEkle(bilgiler);
				ge.ShowDialog();
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
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
				DialogResult cevap = MessageBox.Show(id + " Numaralı Kayıt Silinecek. Silmek İstediğinize Emin Misiniz?", "Kişi Silinecek", MessageBoxButtons.OKCancel);
				if (cevap.ToString() == "OK")
					durum = VeriIslemleri.VeriSil("Giderler", "GiderID", id);
			}
			if (durum)
			{
				MessageBox.Show("Silme işlemi başarılı!");
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.BilgileriGetir("Giderler", "GiderID"));
				dataGridView1.Update();
			}
		}
		private void bt_filtrele_Click(object sender, EventArgs e)
		{
			if (!rb_giderTuru.Checked || textBox1.Text == "")
			{
				MessageBox.Show("Filtreleme için bir aranan değer giriniz!");
				dataGridView1.DataSource = dt;
			}
			else
				dataGridView1.DataSource = VeriIslemleri.TabloDoldur("Giderler", VeriIslemleri.Filtre("Giderler", filtre, aranan: textBox1.Text));
			dataGridView1.Update();
			rb_giderTuru.Checked = true;
			rb_giderTuru.Checked = false;
			textBox1.Clear();
		}

		private void button1_Click(object sender, EventArgs e) => ExcelIslemleri.ExportToExcel(dataGridView1);

		private void GiderleriGoruntule_Resize(object sender, EventArgs e)
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
