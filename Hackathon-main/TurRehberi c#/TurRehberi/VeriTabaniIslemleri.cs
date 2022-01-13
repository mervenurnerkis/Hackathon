using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurRehberi
{
    class VeriTabaniIslemleri
    {
        SqlConnection con= new SqlConnection(@"Data Source=DESKTOP-TLNPHQ6;Initial Catalog=TurRehberi;Integrated Security=True");//sql baglanti cümlecigi yazılır;
        SqlDataAdapter da;
        DataTable dt;
        DataSet dts;

        public DataTable GeziBilgileriniGetir()//wiew gezibilgilerini döndürür
        {
            con.Open();//baglanti acilir
            da = new SqlDataAdapter(@"select *from geziBilgi", con);//sql sorgu cumlecigi yazilir
            dt = new DataTable();//soru sonucunda olusan tabloyu datatable aktarmak icin bir nesne yaratilir
            da.Fill(dt);//sorgu sonucunda gelen tablo dt adındaki datatable atılır
            con.Close();//baglanti kapatilir
            return dt;//kullanilmak uzere datatable geri donderilir
        }


        public DataTable RehberBilgileriniGetir()//wiew rehberBilgi vievini döndürür
        {
           
            con.Open();
            da = new SqlDataAdapter(@"select *from rehberBilgi ", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable MusterileriGetir()//view musterBilgi vievini döndürür
        {
           
            con.Open();
            da = new SqlDataAdapter(@"select *from musteriBilgi", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataSet UlkeleriGetir()// combobox'a ulke isimlerini getirme
        {
    
            con.Open();
            da = new SqlDataAdapter(@"select *from tblUlke", con);
            dts = new DataSet(); //sorgu sonucundaki tablo data sete aktarmak icin bir nesne tanilmlanir
            da.Fill(dts);//sorgu sonucunda gelen tablo dts adındaki datasete atilir
            con.Close(); //hata almamak icin baglanti kapatilir
            return dts;

        }
        public DataSet RehberleriGetir()//combobox'a rehber isimlerini getirme
        {
    
            con.Open();
            da = new SqlDataAdapter(@"select *from tblRehber", con);
            dts = new DataSet();
            da.Fill(dts);
            con.Close();
            return dts;

        }
        public DataSet RehberAdinaGoreListele(string rehberAdi)//ilgili procedürü parametreye göre çalıştırır
        { 
            con.Open();

            SqlCommand cmd = new SqlCommand(); //storedprocedure yazilacagi icin bir sql command nesnesi yaratilir
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;//storedprocedur oldugu belirtilir
            cmd.CommandText = "rehberAdinaGoreListele ";//procedurun ismi yazilir
            cmd.Parameters.AddWithValue("@rehberAdi", rehberAdi);//prosedurun parametreleri yazilir ve deger atilir
            da = new SqlDataAdapter(cmd);//sgq adapter nesnesine sqlcoomand verilir ve sonuc bir tablo doner
            dts = new DataSet();//geri donen tabloyu fonksiyonla geri dondermek icin dataset yaratilir
            da.Fill(dts); //geri donen tablo dataset nesnesi olan dts'ye doldurulur
            con.Close();//baglanti kapatilir
            return dts;//dataset geri donderilir

        }
        public DataSet UlkeyeGoreMusteriListele(string ulkeAdi)//ilgili procedürü parametreye göre çalıştırır
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ulkeyeGoreAra ";
            cmd.Parameters.AddWithValue("@ulkeAdi", ulkeAdi);
            da = new SqlDataAdapter(cmd);
            dts = new DataSet();
            da.Fill(dts);
            con.Close();
            return dts;

        }
        public DataSet MusteriKimlikNosunaGoreGetir(string kimlikNo)//text'e yazilan musteri kimlik numarasina gore musteri bilgilerini getirir. funcition 
        {
    
            con.Open();//veritabanina baglanilir
            SqlCommand cmd = new SqlCommand("SELECT * FROM musteriAra(@kimlikNo)", con); //sql command nesnesi yaratılır ve sorgu yazılır 
            cmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);//ilkgili parametreye deger atanır
            da = new SqlDataAdapter(cmd);//sorgu adaptare verilir ve sonuc bir tablo doner 
            dts = new DataSet();////geri donen tabloyu fonksiyonla geri dondermek icin dataset yaratilir
            da.Fill(dts);//geri donen tablo dataset nesnesi olan dts'ye doldurulur
            con.Close();//baglanti kapatilir
            return dts;//dataset geridonderilir
        }
        public DataSet RehberKimlikNosunaGoreGetir(string kimlikNo)//text'e yazilan rehber kimlik numarasina gore rehberin bilgilerini getirir. funcition
        {
            //sql baglantisi olusturuldu

            con.Open(); //baglanti acildi
            SqlCommand cmd = new SqlCommand("SELECT * FROM rehberAra(@kimlikNo)", con);//sql de bulunan musteriAra fonksiyonun sorgusu yazildi.
            cmd.Parameters.AddWithValue("@kimlikNo", kimlikNo);
            da = new SqlDataAdapter(cmd);
            dts = new DataSet();
            da.Fill(dts);
            con.Close();
            return dts;
        }
        public DataTable DilBilgileriniGoster()//view dilbilgileritablosunu viewini geri döner  
        {

            con.Open();
            da = new SqlDataAdapter(@"select *from DilBilgileriniGoster ", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SifreleriGoster()//view SifrelerGoster viewini geri döner 
        {

            con.Open();
            da = new SqlDataAdapter(@"select *from SifreleriGoster ", con);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }

    }
}

