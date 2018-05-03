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

namespace ApartmanYönetimSistemi.Ekle
{
	public partial class GiderEkle : Form
	{
		bool gonderen;
		KayitKatmani.GiderKayitlari gk;

		public GiderEkle()
		{
			gonderen = false;
			InitializeComponent();
			gk = new KayitKatmani.GiderKayitlari();
			label3.Text = "Gider Ekle";
			this.Text = "Gider Ekle - KKY Site Yönetim Sistemi";
		}
		public GiderEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			gk = new KayitKatmani.GiderKayitlari();
			gk.GiderID = Convert.ToInt32(kayitlar[0]);
			tb_giderTuru.Text = kayitlar[1];
			tb_tutar.Text = kayitlar[2];
			dtp_tarih.Text = kayitlar[3];
			tb_aciklama.Text = kayitlar[4];
			label3.Text = "Gider Düzenle";
			this.Text = "Gider Düzenle - KKY Site Yönetim Sistemi";
		}

		public bool GirdiKontrol()
		{
			try
			{
				if (tb_giderTuru.Text != "" && tb_tutar.Text != "")
				{
					gk.GiderTuru = tb_giderTuru.Text;
					gk.Tutar = Convert.ToInt32(tb_tutar.Text);
					gk.Tarih = dtp_tarih.Value.ToString();
					gk.Aciklama = tb_aciklama.Text;
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (GirdiKontrol())
			{
				if (!gonderen)
				{
					if (VeriIslemleri.GiderEkle(gk))
					{
						MessageBox.Show("Gider Girdisi Ekleme İşlemi Başarılı!");
						this.Close();
					}
				}
				else if (gonderen)
				{
					if (VeriIslemleri.GiderDuzenle(gk))
					{
						MessageBox.Show("Gider Girdisi Düzenleme İşlemi Başarılı!");
						this.Close();
					}
				}
			}
			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}
	}
}
