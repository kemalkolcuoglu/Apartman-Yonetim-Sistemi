using IslemKatmani;
using KayitKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanYönetimSistemi
{
	public partial class KisiEkle : Form, Ekle.IKontrol
	{
		bool gonderen;
		KisiKayitlari kk;
		public KisiEkle()
		{
			gonderen = false;
			InitializeComponent();
			kk = new KisiKayitlari();
			label3.Text = "Kişi Ekle";
			this.Text = "Kişi Ekle - KKY Site Yönetim Sistemi";
		}

		public KisiEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			kk = new KisiKayitlari();
			kk.KisiID = Convert.ToInt32(kayitlar[0]);
			cb_sahipSakin.Text = kayitlar[1];
			tb_ad.Text = kayitlar[2];
			tb_soyad.Text = kayitlar[3];
			tb_telno1.Text = kayitlar[4];
			tb_telno2.Text = kayitlar[5];
			tb_telno3.Text = kayitlar[6];
			tb_eposta.Text = kayitlar[7];
			tb_isAdresi.Text = kayitlar[8];
			tb_aciklama.Text = kayitlar[9];
			label3.Text = "Kişi Düzenle";
			this.Text = "Kişi Düzenle - KKY Site Yönetim Sistemi";
		}

		public bool GirdiKontrol()
		{
			try
			{
				if (cb_sahipSakin.Text != "" && tb_ad.Text != "" && tb_soyad.Text != "" && tb_telno1.Text != "")
				{
					kk.Durum = cb_sahipSakin.Text;
					kk.Ad = tb_ad.Text;
					kk.Soyad = tb_soyad.Text;
					kk.TelefonNo1 = tb_telno1.Text;
					kk.TelefonNo2 = tb_telno2.Text;
					kk.TelefonNo3 = tb_telno3.Text;
					kk.Eposta = tb_eposta.Text;
					kk.IsAdresi = tb_isAdresi.Text;
					kk.Aciklama = tb_aciklama.Text;
					return true;
				}
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			return false;
		}

		private void bt_onayla_Click(object sender, EventArgs e)
		{
			if(GirdiKontrol())
			{
				if (!gonderen)
				{
					if (VeriIslemleri.KisiEkle(kk))
					{
						MessageBox.Show("Kişi Ekleme İşlemi Başarılı!");
						this.Close();
					}
				}
				else if (gonderen)
				{
					if (VeriIslemleri.KisiDuzenle(kk))
					{
						MessageBox.Show("Kişi Düzenleme İşlemi Başarılı!");
						this.Close();
					}
				}
			}
			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}
	}
}
