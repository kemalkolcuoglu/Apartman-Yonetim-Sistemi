using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using KayitKatmani;

namespace IslemKatmani
{
	public static class VeriIslemleri
	{
		public static OleDbDataAdapter BilgileriGetir(string veritabani, string duzen)
		{
			OleDbDataAdapter da = new OleDbDataAdapter("Select * From " + veritabani + " Order By " + duzen + " ASC ", BaglantiSinifi.Con);
			return da;
		}
		public static DataGridView BilgileriGetirGridView(string veritabani, string duzen)
		{
			DataGridView GridView = new DataGridView();
			OleDbCommand cmd = new OleDbCommand("Select * From " + veritabani + " Order By " + duzen + " ASC ", BaglantiSinifi.Con);
			BaglantiSinifi.Con.Open();
			OleDbDataReader dr = cmd.ExecuteReader();
			GridView.DataSource = dr;
			BaglantiSinifi.Con.Close();
			return GridView;
		}

		public static DataTable TabloDoldur(string veritabani, OleDbDataAdapter da)
		{
			try
			{
				DataTable dt = new DataTable();
				da.Fill(dt);
				dt.TableName = veritabani;
				switch(dt.TableName)
				{
					case "Kisi":
						dt.Columns["KisiID"].ColumnName = "Kişi Numarası";
						dt.Columns["KisiDurum"].ColumnName = "Sahip/Kiracı";
						dt.Columns["TelefonNo1"].ColumnName = "1. Telefon Numarası";
						dt.Columns["TelefonNo2"].ColumnName = "2. Telefon Numarası";
						dt.Columns["TelefonNo3"].ColumnName = "3. Telefon Numarası";
						dt.Columns["Eposta"].ColumnName = "E-Posta Adresi";
						dt.Columns["IsAdresi"].ColumnName = "İş Adresi";
						dt.Columns["Aciklama"].ColumnName = "Açıklama"; break;
					case "Daire":
						dt.Columns["DaireNo"].ColumnName = "Daire Numarası";
						dt.Columns["DaireDurum"].ColumnName = "Daire Durumu";
						dt.Columns["DaireSahibi"].ColumnName = "Dairenin Sahibi";
						dt.Columns["DaireSakini"].ColumnName = "Dairenin Sakini"; break;
					case "Aidat":
						dt.Columns["AidatNo"].ColumnName = "Aidat Makbuz No";
						dt.Columns["DaireNo"].ColumnName = "Daire Numarası";
						dt.Columns["AidatTutar"].ColumnName = "Aidat Tutarı";
						dt.Columns["OrtakTutar"].ColumnName = "Ortak Yakıt Tutarı";
						dt.Columns["Demirbas"].ColumnName = "Demirbaş Tutarı";
						dt.Columns["ToplamTutar"].ColumnName = "Toplam Tutar"; break;
					case "Yakit":
						dt.Columns["YakitID"].ColumnName = "Yakıt Makbuz No";
						dt.Columns["DaireNo"].ColumnName = "Daire Numarası";
						dt.Columns["AlinanKontorMiktari"].ColumnName = "Alınan Kontör Miktarı"; break;
					case "Arac":
						dt.Columns["AracPlaka"].ColumnName = "Araç Plaka";
						dt.Columns["DaireNo"].ColumnName = "Daire Numarası";
						dt.Columns["TelefonNo"].ColumnName = "İrtibat Numarası"; break;
					case "Giderler":
						dt.Columns["GiderID"].ColumnName = "Kayıt Numarası";
						dt.Columns["GiderTuru"].ColumnName = "Gider Türü";
						dt.Columns["Aciklama"].ColumnName = "Açıklama"; break;
					case "EskiDaire":
						dt.Columns["KayitID"].ColumnName = "Kayıt Numarası";
						dt.Columns["DaireNo"].ColumnName = "Daire Numarası";
						dt.Columns["DaireSahibi"].ColumnName = "Dairenin Sahibi";
						dt.Columns["DaireSakini"].ColumnName = "Dairenin Sakini";
						dt.Columns["GirisTarihi"].ColumnName = "Giriş Tarihi";
						dt.Columns["CikisTarihi"].ColumnName = "Çıkış Tarihi";
						dt.Columns["Aciklama"].ColumnName = "Açıklama"; break;
				}
				return dt;
			}
			catch(Exception exp)
			{
				MessageBox.Show(exp.Message);
				return null;
			}
		}

		public static OleDbDataAdapter Filtre(string veritabani, string filtre, string aranan)
		{
			string query = "Select * From " + veritabani + " Where " + filtre + " Like @aranan;";
			OleDbDataAdapter da = new OleDbDataAdapter(query, BaglantiSinifi.Con);
			da.SelectCommand.Parameters.Add("@aranan", OleDbType.VarChar).Value = "%" + aranan + "%";
			return da;
		}
		public static int KisiSayisiBul()
		{
			int sayi = 0;
			OleDbCommand cmd = new OleDbCommand("Select Count(*) From Kisi", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				sayi = Convert.ToInt32(cmd.ExecuteScalar().ToString());
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return sayi;
		}
		public static string[] Kisiler()
		{
			string[] kisiler = new string[KisiSayisiBul()];
			OleDbCommand cmd = new OleDbCommand("Select KisiID, Ad, Soyad From Kisi Order By KisiID ASC;", BaglantiSinifi.Con);
			try
			{
				int sayac = 0;
				BaglantiSinifi.Con.Open();
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read())
				{
					kisiler[sayac++] = dr["KisiID"].ToString() + " - " + dr["Ad"].ToString() + " " + dr["Soyad"].ToString();
				}
				Console.WriteLine(kisiler.Length + "kadar kişi bulundu.");
			}
			catch (Exception exp) { Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return kisiler;
		}
		public static int DaireSayisiBul()
		{
			int sayi = 0;
			OleDbCommand cmd = new OleDbCommand("Select Count(*) From Daire", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				sayi = Convert.ToInt32(cmd.ExecuteScalar().ToString());
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return sayi;
		}
		public static int[] DaireNoListele()
		{
			int[] daireler = new int[DaireSayisiBul()];
			int sayi = 0;
			OleDbCommand cmd = new OleDbCommand("Select DaireNo From Daire Order By DaireNo ASC;", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read())
					daireler[sayi++] = Convert.ToInt32(dr[0].ToString());
				Console.WriteLine(daireler.Length + " kişi bulundu.");
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return daireler;
		}
		public static string[] BilgileriAl(string veritabani, string istenen, string aranan)
		{   // Bu method Veri Düzenleme işlemlerinde Formdaki bileşenlere yerleşecek verileri getirir 
			OleDbCommand cmd;
			string[] bilgiler = new string[10];
			if(veritabani != "Arac")
				cmd = new OleDbCommand("Select * From " + veritabani + " Where " + istenen + " = " + aranan, BaglantiSinifi.Con);
			else
				cmd = new OleDbCommand("Select * From " + veritabani + " Where " + istenen + " = '" + aranan + "'", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read())
				{
					for (int i = 0; i < 9; i++)
						bilgiler[i] = dr[i].ToString();
				}
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return bilgiler;
		}
		public static int SifreAl()
		{
			int sifre = -1;
			OleDbCommand cmd = new OleDbCommand("Select Sifre From Giris Where KullaniciAdi = admin", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				sifre = Convert.ToInt32(cmd.ExecuteScalar().ToString());
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return sifre;
		}

		public static int AidatNoBul()
		{
			int sayi = 0;
			OleDbCommand cmd = new OleDbCommand("Select Max(AidatNo) As Aidat From Aidat", BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				sayi = Convert.ToInt32(cmd.ExecuteScalar().ToString());
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return sayi;
		}
		public static string AidatToplamBul(string daireNo)
		{
			int toplam = 0;
			OleDbCommand cmd = new OleDbCommand("Select ToplamTutar From Aidat Where DaireNo = " + daireNo, BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				OleDbDataReader dr = cmd.ExecuteReader();
				while(dr.Read())
					toplam += Convert.ToInt32(dr[0]);
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			return toplam.ToString();
		}
		public static string[] YakitToplamBul(string daireNo)
		{
			int toplam = 0;
			int kontor = 0;
			OleDbCommand cmd = new OleDbCommand("Select Tutar,AlinanKontorMiktari From Yakit Where DaireNo = " + daireNo, BaglantiSinifi.Con);
			try
			{
				BaglantiSinifi.Con.Open();
				OleDbDataReader dr = cmd.ExecuteReader();
				while (dr.Read())
				{
					toplam += Convert.ToInt32(dr[0]);
					kontor += Convert.ToInt32(dr[1]);
				}
			}
			catch (Exception exp)
			{ Console.WriteLine(exp.Message); }
			finally
			{
				BaglantiSinifi.Con.Close();
			}
			string[] dizi = { toplam.ToString(), kontor.ToString() };
			return dizi;
		}

		public static bool Sorgu(OleDbCommand cmd)
		{
			try
			{
				if (BaglantiSinifi.Con.State != ConnectionState.Open)
					BaglantiSinifi.Con.Open();
				int etk = cmd.ExecuteNonQuery();
				return etk > 0 ? true : false;
			}
			catch (Exception exp)
			{
				Console.WriteLine(exp.Message);
				return false;
			}
			finally
			{
				if (BaglantiSinifi.Con.State == ConnectionState.Open)
					BaglantiSinifi.Con.Close();
			}
		}

		public static bool DaireEkle(DaireKayitlari dk)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Daire values (@s2,@s3,[@s4],[@s5],@s6)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s2", dk.DaireNo);
			cmd.Parameters.AddWithValue("@s3", dk.DaireDurum);
			cmd.Parameters.AddWithValue("@s4", dk.DaireSahibi);
			cmd.Parameters.AddWithValue("@s5", dk.DaireSakini);
			cmd.Parameters.AddWithValue("@s6", dk.Kat);
			return Sorgu(cmd);
		}
		public static bool EskiDaireEkle(EskiDaireKayitlari dk)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into EskiDaire (DaireNo, DaireSahibi, DaireSakini, GirisTarihi, CikisTarihi, Aciklama) values (@s1,@s2,@s3,@s4,@s5,@s6)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", dk.DaireNo);
			cmd.Parameters.AddWithValue("@s2", dk.DaireSahibi);
			cmd.Parameters.AddWithValue("@s3", dk.DaireSakini);
			cmd.Parameters.AddWithValue("@s4", dk.GirisTarihi);
			cmd.Parameters.AddWithValue("@s5", dk.CikisTarihi);
			cmd.Parameters.AddWithValue("@s6", dk.Aciklama);
			return Sorgu(cmd);
		}
		public static bool KisiEkle(KisiKayitlari kk)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Kisi (KisiDurum, Ad, Soyad, TelefonNo1, TelefonNo2, TelefonNo3, Eposta, IsAdresi, Aciklama) values (@s1,@s2,@s3,@s4,@s5,@s6,@s7,@s8,@s9)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", kk.Durum);
			cmd.Parameters.AddWithValue("@s2", kk.Ad);
			cmd.Parameters.AddWithValue("@s3", kk.Soyad);
			cmd.Parameters.AddWithValue("@s4", kk.TelefonNo1);
			cmd.Parameters.AddWithValue("@s5", kk.TelefonNo2);
			cmd.Parameters.AddWithValue("@s6", kk.TelefonNo3);
			cmd.Parameters.AddWithValue("@s7", kk.Eposta);
			cmd.Parameters.AddWithValue("@s8", kk.IsAdresi);
			cmd.Parameters.AddWithValue("@s9", kk.Aciklama);
			return Sorgu(cmd);
		}
		public static bool AidatEkle(AidatKayitlari ak)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Aidat values (@s1,@s2,@s3,@s4,@s5,@s6,@s7)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", ak.AidatNo);
			cmd.Parameters.AddWithValue("@s2", ak.DaireNo);
			cmd.Parameters.AddWithValue("@s3", ak.Tarih);
			cmd.Parameters.AddWithValue("@s4", ak.AidatTutar);
			cmd.Parameters.AddWithValue("@s5", ak.OrtakTutar);
			cmd.Parameters.AddWithValue("@s6", ak.Demirbas);
			cmd.Parameters.AddWithValue("@s7", ak.ToplamTutar);
			return Sorgu(cmd);
		}
		public static bool YakitEkle(YakitKayitlari yk)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Yakit values (@s1,@s2,@s3,@s4,@s5)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", yk.YakitNo);
			cmd.Parameters.AddWithValue("@s2", yk.DaireNo);
			cmd.Parameters.AddWithValue("@s3", yk.Tarih);
			cmd.Parameters.AddWithValue("@s4", yk.Tutar);
			cmd.Parameters.AddWithValue("@s5", yk.OdenenKontorMiktari);
			return Sorgu(cmd);
		}
		public static bool AracEkle(AracKayitlari ak)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Arac values (@s1,@s2,@s3,@s4,@s5)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", ak.DaireNo);
			cmd.Parameters.AddWithValue("@s2", ak.AracPlaka);
			cmd.Parameters.AddWithValue("@s3", ak.Marka);
			cmd.Parameters.AddWithValue("@s4", ak.Model);
			cmd.Parameters.AddWithValue("@s5", ak.TelefonNo);
			return Sorgu(cmd);
		}
		public static bool GiderEkle(GiderKayitlari gk)
		{
			OleDbCommand cmd = new OleDbCommand("Insert Into Giderler (GiderTuru, Tutar, Tarih, Aciklama) values (@s1,@s2,@s3,@s4)", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", gk.GiderTuru);
			cmd.Parameters.AddWithValue("@s2", gk.Tutar);
			cmd.Parameters.AddWithValue("@s3", gk.Tarih);
			cmd.Parameters.AddWithValue("@s4", gk.Aciklama);
			return Sorgu(cmd);
		}

		public static bool DaireDuzenle(DaireKayitlari dk)
		{
			OleDbCommand cmd = new OleDbCommand("Update Daire Set DaireDurum = @s1, DaireSahibi = @s2, DaireSakini = @s3, Kat = @s4 Where DaireNo = @s5", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", dk.DaireDurum);
			cmd.Parameters.AddWithValue("@s2", dk.DaireSahibi);
			cmd.Parameters.AddWithValue("@s3", dk.DaireSakini);
			cmd.Parameters.AddWithValue("@s4", dk.Kat);
			cmd.Parameters.AddWithValue("@s5", dk.DaireNo);
			return Sorgu(cmd);
		}
		public static bool EskiDaireDuzenle(EskiDaireKayitlari dk)
		{
			OleDbCommand cmd = new OleDbCommand("Update EskiDaire Set DaireNo = @s1, DaireSahibi = @s2, DaireSakini = @s3, GirisTarihi = @s4, CikisTarihi = @s5, Aciklama = @s6 Where KayitID = @s7", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", dk.DaireNo);
			cmd.Parameters.AddWithValue("@s2", dk.DaireSahibi);
			cmd.Parameters.AddWithValue("@s3", dk.DaireSakini);
			cmd.Parameters.AddWithValue("@s4", dk.GirisTarihi);
			cmd.Parameters.AddWithValue("@s5", dk.CikisTarihi);
			cmd.Parameters.AddWithValue("@s6", dk.Aciklama);
			cmd.Parameters.AddWithValue("@s7", dk.KayitID);
			return Sorgu(cmd);
		}
		public static bool KisiDuzenle(KisiKayitlari kk)
		{
			string sorgu = "Update Kisi Set KisiDurum = @s1, Ad = @s2, Soyad = @s3, TelefonNo1 = @s4, TelefonNo2 = @s5, TelefonNo3 = @s6, Eposta = @s7, IsAdresi = @s8, Aciklama = @s9 Where KisiID = @s10";
			OleDbCommand cmd = new OleDbCommand(sorgu,BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", kk.Durum);
			cmd.Parameters.AddWithValue("@s2", kk.Ad);
			cmd.Parameters.AddWithValue("@s3", kk.Soyad);
			cmd.Parameters.AddWithValue("@s4", kk.TelefonNo1);
			cmd.Parameters.AddWithValue("@s5", kk.TelefonNo2);
			cmd.Parameters.AddWithValue("@s6", kk.TelefonNo3);
			cmd.Parameters.AddWithValue("@s7", kk.Eposta);
			cmd.Parameters.AddWithValue("@s8", kk.IsAdresi);
			cmd.Parameters.AddWithValue("@s9", kk.Aciklama);
			cmd.Parameters.AddWithValue("@s10", kk.KisiID);
			return Sorgu(cmd);
		}
		public static bool AracDuzenle(AracKayitlari ak)
		{
			OleDbCommand cmd = new OleDbCommand("Update Arac Set DaireNo = @s1, Marka = @s2, Model = @s3, TelefonNo = @s4 Where AracPlaka = @s5", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", ak.DaireNo);
			cmd.Parameters.AddWithValue("@s2", ak.Marka);
			cmd.Parameters.AddWithValue("@s3", ak.Model);
			cmd.Parameters.AddWithValue("@s4", ak.TelefonNo);
			cmd.Parameters.AddWithValue("@s5", ak.AracPlaka);
			return Sorgu(cmd);
		}
		public static bool AidatDuzenle(AidatKayitlari ak)
		{
			OleDbCommand cmd = new OleDbCommand("Update Aidat Set DaireNo = @s1, Tarih = @s2, AidatTutar = @s3, OrtakTutar = @s4, Demirbas = @s5, ToplamTutar = @s6 Where AidatNo = @s7", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", ak.DaireNo);
			cmd.Parameters.AddWithValue("@s2", ak.Tarih);
			cmd.Parameters.AddWithValue("@s3", ak.AidatTutar);
			cmd.Parameters.AddWithValue("@s4", ak.OrtakTutar);
			cmd.Parameters.AddWithValue("@s5", ak.Demirbas);
			cmd.Parameters.AddWithValue("@s6", ak.ToplamTutar);
			cmd.Parameters.AddWithValue("@s7", ak.AidatNo);
			return Sorgu(cmd);
		}
		public static bool YakitDuzenle(YakitKayitlari yk)
		{
			OleDbCommand cmd = new OleDbCommand("Update Yakit Set DaireNo = @s1, Tarih = @s2, Tutar = @s3, OdenenTutar = @s4 Where YakitID = @s5", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", yk.DaireNo);
			cmd.Parameters.AddWithValue("@s2", yk.Tarih);
			cmd.Parameters.AddWithValue("@s3", yk.Tutar);
			cmd.Parameters.AddWithValue("@s4", yk.OdenenKontorMiktari);
			cmd.Parameters.AddWithValue("@s5", yk.YakitNo);
			return Sorgu(cmd);
		}
		public static bool GiderDuzenle(GiderKayitlari gk)
		{
			OleDbCommand cmd = new OleDbCommand("Update Giderler Set GiderTuru = @s1, Tutar = @s2, Tarih = @s3, Aciklama = @s4 Where GiderID = @s5", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", gk.GiderTuru);
			cmd.Parameters.AddWithValue("@s2", gk.Tutar);
			cmd.Parameters.AddWithValue("@s3", gk.Tarih);
			cmd.Parameters.AddWithValue("@s4", gk.Aciklama);
			cmd.Parameters.AddWithValue("@s5", gk.GiderID);
			return Sorgu(cmd);
		}
		public static bool SifreDuzenle(int sifre)
		{
			OleDbCommand cmd = new OleDbCommand("Update Giris Set Sifre = @s1 Where KullaniciAdi = yonetici", BaglantiSinifi.Con);
			cmd.Parameters.AddWithValue("@s1", sifre);
			return Sorgu(cmd);
		}

		public static bool VeriSil(string veritabani, string id, string silinecek)
		{
			string sorgu = "Delete From " + veritabani + " Where " + id + " = " + silinecek;
			OleDbCommand cmd = new OleDbCommand(sorgu, BaglantiSinifi.Con);
			return Sorgu(cmd);
		}
		public static bool AracSil(string silinecek)
		{
			string sorgu = "Delete From Arac Where AracPlaka = '" + silinecek + "'";
			OleDbCommand cmd = new OleDbCommand(sorgu, BaglantiSinifi.Con);
			return Sorgu(cmd);
		}
	}
}
