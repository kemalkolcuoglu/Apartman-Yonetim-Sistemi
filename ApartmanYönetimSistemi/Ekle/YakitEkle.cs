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
	public partial class YakitEkle : Form, Ekle.IKontrol
	{
		bool gonderen;
		object[] daireler;
		YakitKayitlari yk;
		public YakitEkle()
		{
			gonderen = false;
			InitializeComponent();
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_daireNo.Items.AddRange(daireler);
			label3.Text = "Yakıt Girdisi Ekle";
			this.Text = "Yakıt Girdisi Ekle - KKY Site Yönetim Sistemi";
		}
		public YakitEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			cb_daireNo.DropDownStyle = ComboBoxStyle.DropDown;
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_daireNo.Items.AddRange(daireler);

			tb_yakitNo.Text = kayitlar[0];
			cb_daireNo.Text = kayitlar[1];
			dtp_tarih.Text = kayitlar[2];
			tb_tutar.Text = kayitlar[3];
			tb_alinanKontorMiktari.Text = kayitlar[4];
			cb_daireNo.Enabled = false;
			label3.Text = "Yakıt Girdisi Düzenle";
			this.Text = "Yakıt Girdisi Düzenle - KKY Site Yönetim Sistemi";
		}

		public bool GirdiKontrol()
		{
			try
			{
				yk = new YakitKayitlari();
				if (tb_yakitNo.Text != "" && cb_daireNo.Text != "" && tb_tutar.Text != "" && tb_alinanKontorMiktari.Text != "")
				{
					yk.YakitNo = Convert.ToInt32(tb_yakitNo.Text);
					yk.DaireNo = Convert.ToInt32(cb_daireNo.Text);
					yk.Tarih = dtp_tarih.Value.ToString();
					yk.Tutar = Convert.ToInt32(tb_tutar.Text);
					yk.OdenenKontorMiktari = Convert.ToInt32(tb_alinanKontorMiktari.Text);
					return true;
				}
			}
			catch (Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
			return false;
		}

		private void bt_onayla_Click(object sender, EventArgs e)
		{
			if (GirdiKontrol())
			{
				if (!gonderen)
				{
					if (VeriIslemleri.YakitEkle(yk))
					{
						MessageBox.Show("Yakıt Girdisi Ekleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Aynı Yakit Numarasına Sahip Girdi Ekleyemezsiniz!");
				}
				else if (gonderen)
				{
					if (VeriIslemleri.YakitDuzenle(yk))
					{
						MessageBox.Show("Yakıt Girdisi Düzenleme İşlemi Başarılı!");
						this.Close();
					}
				}
			}
			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}
	}
}
