using System.Data.SqlClient; // SqlConnection kullanmak i�in k�t�pjanei dahil ediyoruz...

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


            // SqlConnection s�n�f�n� kullanmak ii�n package managerden System.Data.SqlClient k�t�phanesi kurmam�z gerekir.. 

            // Projeye dahil edeceimiz k�t�phaneleri projemize sa� t�k yaparak Manage Nuget Package penrecesinden dahil ederiz...
            // code ekran�dna indirilen k�t�phanenin namespace using ifadesi ile dahil edilir...

            // SqlConnection => veritaban�m�z ile uygulamam�z aras�nda bir kanal a�ar. sorgular�m�z bu kanal aracal��� ile execute edilir. 

            //ConnectionString => veritaban� yolunu belirten ifadedir...
            // Ornk ConnectionString (SqlServerAuthentiocation) => Server=<ServerAdi>;Database=<DatabaseAdi>;uid=<sqlserverusername>;password=<usepassword>
            // Ornk ConnectionString (WindowsAuthentication) =>  Server=<ServerAdi>;Database=<DatabaseAdi>; TrustedConnection=true;

            // bir string i�erisinde \ karaktare ka��� karakteri olarak adland�r�l�. bu karakter �zel karakterdir yani bekledi�i karakterleer geldi�inde stringde farkl�l�klr olu�ur. tab, enter vb.string i�erisinde bu karakteri normal kullanmak istiyorsam \\ veya string'in ba��na @ ifadesi atar�z.
            #endregion

            SqlConnection cnn = new SqlConnection(@"Server=.\mssqlexpress; Database=Northwind;uid=sa;password=123");
            cnn.Open(); // ba�lant�y� a�....

            // sql ifadelerini �al��t�r....

            cnn.Close(); // ba�lant� kapat...
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region aciklama
            //SqlCommand s�n�f� => c# ortam�nda sql ifadeleri yazmak i�in kullan�l�r.. sql ifaderi  commanda yaz�l�r connection� belirtilir daha sonra execute edilir...

            // Execute i�leminde farkl� result vard�r..Bunlar� a��kca belirtmek gerekir..
            //ExecuteScalar();   => sorgu �al��t�r�ld�ktan sonra geriye tek sat�r tek s�tun d�ner. yani scalar-valued functionlar i�in kullan�l�r
            //ExecuteReader(); => sorgu �al��t�r�ktan sonra geriye tablo d�nmek i�in kullan�l�r
            //ExecuteNonQuery(); => sorgu �al��t�r�ktan sonra geriye etkilen sat�r say�s�n� d�nmek i�in kullan�l�r (insert, update,delete ifadelerinin �al��t�rmak i�in


            #endregion

            SqlConnection cnn = new SqlConnection(@"Server=.\mssqlexpress; Database=Northwind;uid=sa;password=123");

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert Categories (CategoryName,Description) values('koddan','ado.net ��reniyoruz..')";
            cmd.Connection = cnn;

            cnn.Open();
            int result =  cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show("Kay�t eklendi " + result);
        }
    }
}