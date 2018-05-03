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
	public partial class DaireEkle : Form, Ekle.IKontrol
	{
		bool gonderen;
		DaireKayitlari dk;
		string daireSahibi, daireSakini;
		public DaireEkle()
		{
			gonderen = false;
			InitializeComponent();
			cb_DaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
			cb_DaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
			label1.Text = "Daire Ekle";
			this.Text = "Daire Ekle - KKY Site Yönetim Sistemi";
		}
		public DaireEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			cb_DaireSahibi.Items.AddRange(VeriIslemleri.Kisiler());
			cb_DaireSakini.Items.AddRange(VeriIslemleri.Kisiler());
			tb_daireNo.Text = kayitlar[0];
			cb_DaireDurum.Text = kayitlar[1];
			cb_DaireSahibi.Text = kayitlar[2];
			daireSahibi = kayitlar[2];
			cb_DaireSakini.Text = kayitlar[3];
			daireSakini = kayitlar[3];
			nud_kat.Text = kayitlar[4];
			tb_daireNo.Enabled = false;
			label1.Text = "Daire Düzenle";
			this.Text = "Daire Düzenle - KKY Site Yönetim Sistemi";
		}
		public bool GirdiKontrol()
		{
			try
			{
				dk = new DaireKayitlari();
				if (tb_daireNo.Text != "" && cb_DaireDurum.Text != "" && cb_DaireSahibi.Text != "" && cb_DaireSakini.Text != "")
				{
					dk.DaireNo = Convert.ToInt32(tb_daireNo.Text);
					dk.DaireDurum = cb_DaireDurum.Text;
					dk.DaireSahibi = cb_DaireSahibi.Text;
					dk.DaireSakini = cb_DaireSakini.Text;
					dk.Kat = Convert.ToInt32(nud_kat.Value);
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
				if (!gonderen)
				{
					if (VeriIslemleri.DaireEkle(dk))
					{
						MessageBox.Show("Daire Ekleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Aynı numaraya sahip daire ekleyemezsiniz!");
				}
				else if (gonderen)
				{
					if (VeriIslemleri.DaireDuzenle(dk))
					{
						MessageBox.Show("Daire Düzenleme İşlemi Başarılı!");
						EskiDaireEkle ede = new EskiDaireEkle(daireNo: dk.DaireNo.ToString(), daireSahibi: daireSahibi, daireSakini: daireSakini);
						ede.ShowDialog();
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
