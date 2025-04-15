using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulOtomasyonu
{
    internal class SqlBaglanti
    {
        public string adress = System.IO.File.ReadAllText(@"C:\VeriTabanı.txt");
        public SqlConnection BaglantiGetir()
        {
            SqlConnection baglanti = new SqlConnection(adress);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }
    }
}
