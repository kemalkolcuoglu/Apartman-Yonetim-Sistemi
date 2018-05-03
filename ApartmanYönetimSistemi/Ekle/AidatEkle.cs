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
	public partial class AidatEkle : Form, Ekle.IKontrol
	{
		bool gonderen;
		object[] daireler;
		AidatKayitlari ak;
		public AidatEkle()
		{
			gonderen = false;
			InitializeComponent();
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_daireNo.Items.AddRange(daireler);
			this.Text = "Aidat Girdisi Ekle - KKY Site Yönetim Sistemi";
			label1.Text = "Aidat Girdisi Ekle";
		}
		public AidatEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			cb_daireNo.DropDownStyle = ComboBoxStyle.DropDown;
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_daireNo.Items.AddRange(daireler);
			tb_aidatNo.Text = kayitlar[0];
			cb_daireNo.Text = kayitlar[1];
			dtp_tarih.Text = kayitlar[2];
			tb_tutar.Text = kayitlar[3];
			tb_ortakTutar.Text = kayitlar[4];
			tb_demirbas.Text = kayitlar[5];
			tb_toplam.Text = kayitlar[6];
			cb_daireNo.Enabled = false;
			label1.Text = "Aidat Girdisi Düzenle";
			this.Text = "Aidat Girdisi Düzenle - KKY Site Yönetim Sistemi";
		}

		public bool GirdiKontrol()
		{
			try
			{
				ak = new AidatKayitlari();
				if (tb_aidatNo.Text != "" && cb_daireNo.Text != "" && tb_tutar.Text != "" && tb_ortakTutar.Text != "")
				{
					ak.AidatNo = Convert.ToInt32(tb_aidatNo.Text);
					ak.DaireNo = Convert.ToInt32(cb_daireNo.Text);
					ak.Tarih = dtp_tarih.Value.ToString();
					ak.AidatTutar = Convert.ToInt32(tb_tutar.Text);
					ak.OrtakTutar = Convert.ToInt32(tb_ortakTutar.Text);
					ak.Demirbas = Convert.ToInt32(tb_demirbas.Text);
					ak.ToplamTutar = Convert.ToInt32(tb_toplam.Text);
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
					if (VeriIslemleri.AidatEkle(ak))
					{
						MessageBox.Show("Aidat Girdisi Ekleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Aynı Makbuz Numarasına Sahip Girdi Ekleyemezsiniz!");
				}
				else if (gonderen)
				{
					if (VeriIslemleri.AidatDuzenle(ak))
					{
						MessageBox.Show("Aidat Girdisi Düzenleme İşlemi Başarılı!");
						this.Close();
					}
				}
			}
			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}

		private void tb_Tutar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int toplam = Convert.ToInt32(tb_tutar.Text) + Convert.ToInt32(tb_ortakTutar.Text) + Convert.ToInt32(tb_demirbas.Text);
				tb_toplam.Text = toplam.ToString();
			}
			catch(Exception exp)
			{
				Console.WriteLine(exp.Message);
			}
		}
		private void textBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// only allow one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}
	}
}
