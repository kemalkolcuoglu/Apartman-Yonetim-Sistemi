using System.Data.OleDb;

namespace IslemKatmani
{
	public static class BaglantiSinifi
	{
		private static OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = ays.mdb");
		public static OleDbConnection Con => con;
	}
}
