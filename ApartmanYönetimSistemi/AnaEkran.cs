using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IslemKatmani;

namespace ApartmanYönetimSistemi
{
	public partial class AnaEkran : Form
	{
		public AnaEkran()
		{
			InitializeComponent();
		}

		private void bt_daireEkle_Click(object sender, EventArgs e)
		{
			DaireEkle de = new DaireEkle();
			toolStripStatusLabel1.Text = "Daire Ekleme İşlemine Tıklandı";
			de.ShowDialog();
			toolStripStatusLabel1.Text = "İşlem Tamamlandı";
		}
		private void bt_kisiEkle_Click(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = "Kişi Ekleme İşlemine Tıklandı";
			KisiEkle ke = new KisiEkle();
			ke.ShowDialog();
			toolStripStatusLabel1.Text = "İşlem Tamamlandı";
		}
		private void bt_aidatEkle_Click(object sender, EventArgs e)
		{
			AidatEkle ai = new AidatEkle();
			toolStripStatusLabel1.Text = "Aidat Girdisi Ekleme İşlemine Tıklandı";
			ai.ShowDialog();
			toolStripStatusLabel1.Text = "İşlem Tamamlandı";
		}
		private void bt_yakitEkle_Click(object sender, EventArgs e)
		{
			YakitEkle yk = new YakitEkle();
			toolStripStatusLabel1.Text = "Yakit Girdisi Ekleme İşlemine Tıklandı";
			yk.ShowDialog();
			toolStripStatusLabel1.Text = "İşlem Tamamlandı";
		}
		private void bt_aracEkle_Click(object sender, EventArgs e)
		{
			AracEkle ar = new AracEkle();
			toolStripStatusLabel1.Text = "Araç Ekleme İşlemine Tıklandı";
			ar.ShowDialog();
			toolStripStatusLabel1.Text = "İşlem Tamamlandı";
		}

		private void çıkışToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

		private void bt_daireGoruntule_Click(object sender, EventArgs e)
		{
			Goruntuleme.DaireGoruntule dg = new Goruntuleme.DaireGoruntule();
			toolStripStatusLabel1.Text = "Daire Kayıtları Görüntüleniyor";
			dg.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
		}

		private void bt_kisiGoruntule_Click(object sender, EventArgs e)
		{
			Goruntuleme.KisiGoruntule kg = new Goruntuleme.KisiGoruntule();
			toolStripStatusLabel1.Text = "Kişi Kayıtları Görüntüleniyor";
			kg.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
		}

		private void bt_aracGoruntule_Click(object sender, EventArgs e)
		{
			Goruntuleme.AracGoruntule ag = new Goruntuleme.AracGoruntule();
			toolStripStatusLabel1.Text = "Araç Kayıtları Görüntüleniyor";
			ag.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
		}

		private void bt_aidatGoruntule_Click(object sender, EventArgs e)
		{
			Goruntuleme.AidatGoruntule ag = new Goruntuleme.AidatGoruntule();
			toolStripStatusLabel1.Text = "Aidat Kayıtları Görüntüleniyor";
			ag.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
		}

		private void bt_yakitGoruntule_Click(object sender, EventArgs e)
		{
			Goruntuleme.YakitGoruntule yg = new Goruntuleme.YakitGoruntule();
			toolStripStatusLabel1.Text = "Yakit Kayıtları Görüntüleniyor";
			yg.ShowDialog();
			toolStripStatusLabel1.Text = "Kullanıma Hazır";
		}

		private void bt_sifreDegistir_Click(object sender, EventArgs e)
		{
			KullaniciSifreDegistir ksd = new KullaniciSifreDegistir();
			ksd.ShowDialog();
		}

		private void bt_siteGiderleri_Click(object sender, EventArgs e)
		{
			Goruntuleme.GiderleriGoruntule gg = new Goruntuleme.GiderleriGoruntule();
			gg.ShowDialog();
		}

		private void bt_yardimTalebi_Click(object sender, EventArgs e)
		{
			Hakkinda hk = new Hakkinda();
			toolStripStatusLabel1.Text = "Kemal KOLCUOGLU © 2018 - Bütün Hakları Saklıdır.";
			hk.ShowDialog();
		}

		private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hakkinda hk = new Hakkinda();
			toolStripStatusLabel1.Text = "Kemal KOLCUOGLU © 2018 - Bütün Hakları Saklıdır.";
			hk.ShowDialog();
		}
	}
}
