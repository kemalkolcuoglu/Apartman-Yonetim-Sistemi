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

namespace ApartmanYönetimSistemi
{
	public partial class KullaniciSifreDegistir : Form
	{
		public KullaniciSifreDegistir()
		{
			InitializeComponent();
		}

		private void cb_sifreGoster_CheckStateChanged(object sender, EventArgs e)
		{
			if (cb_sifreGoster.Checked)
			{
				textBox1.PasswordChar = '\0';
				textBox2.PasswordChar = '\0';
				textBox3.PasswordChar = '\0';
			}
			else
			{
				textBox1.PasswordChar = '*';
				textBox2.PasswordChar = '*';
				textBox3.PasswordChar = '*';
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

		private bool GirdiKontrol()
		{
			int suanSifre = VeriIslemleri.SifreAl();
			if (suanSifre != Convert.ToInt32(textBox1.Text) && textBox2.Text != textBox3.Text)
				MessageBox.Show("Hatalı Giriş Yaptınız! Lütfen Tekrar Deneyiniz.");
			else
				return true;
			return false;
		}

		private void bt_onayla_Click(object sender, EventArgs e)
		{
			if(GirdiKontrol())
			{
				VeriIslemleri.SifreDuzenle(Convert.ToInt32(textBox2.Text));
				MessageBox.Show("Şifre Güncelleme İşlemi Başarıyla Tamamlandı!");
				this.Close();
			}
		}
	}
}
