using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-UEC3TAH\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True"); 
            //;Trust Server Certificate=True yukarıdaki satırın sonuna eklenecek sorun çıkarsa
            baglan.Open ();
            return baglan;
        }
    }
}
