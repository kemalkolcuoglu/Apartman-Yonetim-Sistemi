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
	public partial class AracEkle : Form, Ekle.IKontrol
	{
		bool gonderen;
		AracKayitlari ak;
		object[] daireler;
		public AracEkle()
		{
			gonderen = false;
			InitializeComponent();
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_DaireNo.Items.AddRange(daireler);
			label1.Text = "Taşıt Ekle";
			this.Text = "Taşıt Ekle - KKY Site Yönetim Sistemi";
		}
		public AracEkle(string[] kayitlar)
		{
			gonderen = true;
			InitializeComponent();
			cb_DaireNo.DropDownStyle = ComboBoxStyle.DropDown;
			tb_plaka.Enabled = false;
			cb_DaireNo.Enabled = false;
			daireler = VeriIslemleri.DaireNoListele().Cast<object>().ToArray();
			cb_DaireNo.Items.AddRange(daireler);
			tb_plaka.Text = kayitlar[1];
			tb_marka.Text = kayitlar[2];
			tb_model.Text = kayitlar[3];
			cb_DaireNo.Text = kayitlar[0];
			tb_telefonNo.Text = kayitlar[4];
			label1.Text = "Taşıt Düzenle";
			this.Text = "Taşıt Düzenle - KKY Site Yönetim Sistemi";
		}
		public bool GirdiKontrol()
		{
			try
			{
				ak = new AracKayitlari();
				if (tb_plaka.Text != "" && tb_marka.Text != "" && tb_model.Text != "" && cb_DaireNo.Text != "")
				{
					ak.AracPlaka = tb_plaka.Text;
					ak.Marka = tb_marka.Text;
					ak.Model = tb_model.Text;
					ak.DaireNo = Convert.ToInt32(cb_DaireNo.Text);
					ak.TelefonNo = tb_telefonNo.Text;
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
					if (VeriIslemleri.AracEkle(ak))
					{
						MessageBox.Show("Araç Ekleme İşlemi Başarılı!");
						this.Close();
					}
					else
						MessageBox.Show("Aynı Plakaya Sahip Araç Eklenemez!");
				}
				else if (gonderen)
				{
					if (VeriIslemleri.AracDuzenle(ak))
					{
						MessageBox.Show("Araç Düzenleme İşlemi Başarılı!");
						this.Close();
					}
				}
			}

			else
				MessageBox.Show("Eksik ya da Hatalı Giriş Yaptınız!\nTekrar Deneyiniz.");
		}

		private void tb_plaka_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == ' ')
			{
				e.Handled = true;
			}
		}
	}
}
