using System.Data.SqlClient; // SqlConnection kullanmak için kütüpjanei dahil ediyoruz...

namespace AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


 
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            #region Aciklama


            // SqlConnection sýnýfýný kullanmak iiçn package managerden System.Data.SqlClient kütüphanesi kurmamýz gerekir.. 

            // Projeye dahil edeceimiz kütüphaneleri projemize sað týk yaparak Manage Nuget Package penrecesinden dahil ederiz...
            // code ekranýdna indirilen kütüphanenin namespace using ifadesi ile dahil edilir...

            // SqlConnection => veritabanýmýz ile uygulamamýz arasýnda bir kanal açar. sorgularýmýz bu kanal aracalýðý ile execute edilir. 

            //ConnectionString => veritabaný yolunu belirten ifadedir...
            // Ornk ConnectionString (SqlServerAuthentiocation) => Server=<ServerAdi>;Database=<DatabaseAdi>;uid=<sqlserverusername>;password=<usepassword>
            // Ornk ConnectionString (WindowsAuthentication) =>  Server=<ServerAdi>;Database=<DatabaseAdi>; TrustedConnection=true;

            // bir string içerisinde \ karaktare kaçýþ karakteri olarak adlandýrýlý. bu karakter özel karakterdir yani beklediði karakterleer geldiðinde stringde farklýlýklr oluþur. tab, enter vb.string içerisinde bu karakteri normal kullanmak istiyorsam \\ veya string'in baþýna @ ifadesi atarýz.
            #endregion

            SqlConnection cnn = new SqlConnection(@"Server=.\mssqlexpress; Database=Northwind;uid=sa;password=123");
            cnn.Open(); // baðlantýyý aç....

            // sql ifadelerini çalýþtýr....

            cnn.Close(); // baðlantý kapat...
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region aciklama
            //SqlCommand sýnýfý => c# ortamýnda sql ifadeleri yazmak için kullanýlýr.. sql ifaderi  commanda yazýlýr connectioný belirtilir daha sonra execute edilir...

            // Execute iþleminde farklý result vardýr..Bunlarý açýkca belirtmek gerekir..
            //ExecuteScalar();   => sorgu çalýþtýrýldýktan sonra geriye tek satýr tek sütun döner. yani scalar-valued functionlar için kullanýlýr
            //ExecuteReader(); => sorgu çalýþtýrýktan sonra geriye tablo dönmek için kullanýlýr
            //ExecuteNonQuery(); => sorgu çalýþtýrýktan sonra geriye etkilen satýr sayýsýný dönmek için kullanýlýr (insert, update,delete ifadelerinin çalýþtýrmak için


            #endregion

            SqlConnection cnn = new SqlConnection(@"Server=.\mssqlexpress; Database=Northwind;uid=sa;password=123");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Categories (CategoryName,Description) values('koddan','ado.net öðreniyoruz..')";
            cmd.Connection = cnn;

            cnn.Open();
            int result =  cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Kayýt eklendi " + result);
        }
    }
}