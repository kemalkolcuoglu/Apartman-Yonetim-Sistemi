using IslemKatmani;
using KayitKatmani;
using System;
using System.Windows.Forms;

namespace ApartmanYönetimSistemi
{
	public partial class EskiDaireEkle : Form, Ekle.IKontrol
	{
		byte gonderen;
		EskiDaireKayitlari dk;
		public EskiDaireEkle()
		{
			dk = new EskiDaireKayitlari();
			gonderen = 0;
			InitializeComponent();
			cb_DaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
			cb_DaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
			label1.Text = "Eski Daire Kaydı Ekle";
			this.Text = "Eski Daire Kaydı Ekle - KKY Site Yönetim Sistemi";
		}
		public EskiDaireEkle(string[] kayitlar)
		{
			dk = new EskiDaireKayitlari();
			gonderen = 1;
			InitializeComponent();
			cb_DaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
			cb_DaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
			tb_daireNo.Enabled = false;
			dk.KayitID = Convert.ToInt32(kayitlar[0]);
			tb_daireNo.Text = kayitlar[1];
			cb_DaireSahibi.Text = kayitlar[2];
			cb_DaireSakini.Text = kayitlar[3];
			dtp_almaGiris.Text = kayitlar[4];
			dtp_satmaCikma.Text = kayitlar[5];
			tb_aciklama.Text = kayitlar[6];
			label1.Text = "Eski Daire Kaydı Düzenle";
			this.Text = "Eski Daire Kaydı Düzenle - KKY Site Yönetim Sistemi";
		}
		public EskiDaireEkle(string daireNo, string daireSahibi, string daireSakini)
		{
			dk = new EskiDaireKayitlari();
			gonderen = 2;
			InitializeComponent();
			cb_DaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
			cb_DaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
			tb_daireNo.Text = daireNo;
			cb_DaireSahibi.Text = daireSahibi;
			cb_DaireSakini.Text = daireSakini;
			label1.Text = "Eski Daire Kaydı Ekle";
			this.Text = "Eski Daire Kaydı Ekle - KKY Site Yönetim Sistemi";
		}
		public bool GirdiKontrol()
		{
			try
			{
				if (tb_daireNo.Text != "" && cb_DaireSahibi.Text != "" && cb_DaireSakini.Text != "")
				{
					dk.DaireNo = Convert.ToInt32(tb_daireNo.Text);
					dk.DaireSahibi = cb_DaireSahibi.Text;
					dk.DaireSakini = cb_DaireSakini.Text;
					dk.GirisTarihi = dtp_almaGiris.Value.ToShortDateString();
					dk.CikisTarihi = dtp_satmaCikma.Value.ToShortDateString();
					dk.Aciklama = tb_aciklama.Text;
					return true;
				}
			}
			catch (Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			return false;
		}

		private void bt_kaydet_Click(object sender, EventArgs e)
		{
			if (GirdiKontrol())
			{
				if (gonderen == 0 || gonderen == 2)
				{
					if (VeriIslemleri.EskiDaireEkle(dk))
					{
						MessageBox.Show("Eski Daire Kaydı Ekleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Aynı numaraya sahip daire ekleyemezsiniz!");
				}
				else if (gonderen == 1)
				{
					if (VeriIslemleri.EskiDaireDuzenle(dk))
					{
						MessageBox.Show("Eski Daire Kaydı Düzenleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Düzenleme işlemi gerçekleştirilemedi!\nLütfen değerleri kontrol ediniz.");
				}
			}
			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}
	}
}
