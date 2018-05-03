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

namespace ApartmanYönetimSistemi.Ekle
{
	public partial class OtomatikAidatEkle : Form
	{
		public OtomatikAidatEkle()
		{
			InitializeComponent();
		}

		private void bt_onayla_Click(object sender, EventArgs e)
		{
			DialogResult dr = MessageBox.Show("Aidatlar Eklenecek!", "Otomatik Aidat", MessageBoxButtons.OKCancel);

			if (dr.ToString() == "Cancel")
				return;

			int maxAidatNo = VeriIslemleri.AidatNoBul();
			int daireSayisi = VeriIslemleri.DaireSayisiBul();
			int[] daireNo = VeriIslemleri.DaireNoListele();
			int tutar = Convert.ToInt32(tb_tutar.Text);
			string tarih = dtp_tarih.Value.ToString();

			progressBar1.Maximum = daireSayisi;

			for (int i = 0; i < daireSayisi; i++)
			{
				//VeriIslemleri.OtomatikAidatEkle(++maxAidatNo,daireNo[i], tutar, tarih);
				progressBar1.Value += 1;
			}
			MessageBox.Show("Girdiler Otomatik Oluşturuldu!");
			this.Close();
		}
	}
}
