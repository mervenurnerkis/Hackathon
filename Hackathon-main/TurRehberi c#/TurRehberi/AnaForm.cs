using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurRehberi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri veriTabani = new VeriTabaniIslemleri();
    

        private void btnRehberListele_Click(object sender, EventArgs e)
        {
           
            grdwTablo.DataSource = veriTabani.RehberBilgileriniGetir(); //formdaki datagridviewew sorgu sonucu olusan tablolar aktarilir
       
        }

        private void btnGeziBilgileriniListele_Click(object sender, EventArgs e)
        {
         
            grdwTablo.DataSource = veriTabani.GeziBilgileriniGetir();
        }
        private void UlkeleriGetir()
        {
            cmbUlkeler.DataSource = veriTabani.UlkeleriGetir().Tables[0];//formdaki datagridviewew sorgu sonucu olusan datasetin 0 tablosu aktarili
            cmbUlkeler.DisplayMember = "ulke";//ulke uyelerini goster 

        }
        private void RehberleriGetir()
        {
            cmbRehberler.DataSource = veriTabani.RehberleriGetir().Tables[0];
            cmbRehberler.DisplayMember = "rehberAd";//rehber ad uyelerini goster 
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            //form acildigi anda ulke ve rehber adlarini combobox'a getirir.
            UlkeleriGetir();//comboboxa uyeleri aktarir
            RehberleriGetir();//comboboxa rehberleri aktarir
            grdwTablo.AutoGenerateColumns = true;//datagridwiew gelen tabloya gore sutunlarinin otomatik olusturmasi icin bu ozellik true yapilir

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            grdwTablo.DataSource = veriTabani.MusterileriGetir();
        }

        private void btnUlkesineGoreListele_Click(object sender, EventArgs e)
        {
            
            cmbUlkeler.ValueMember = "ulke";//
            grdwTablo.DataSource = veriTabani.UlkeyeGoreMusteriListele(cmbUlkeler.SelectedValue.ToString()).Tables[0];
        }

        private void btnRehberProgramListele_Click(object sender, EventArgs e)
        {
         
            cmbRehberler.ValueMember = "rehberAd";//secilen verinin rehberAd degerini alir
            grdwTablo.DataSource = veriTabani.RehberAdinaGoreListele(cmbRehberler.SelectedValue.ToString()).Tables[0];//secilen uyenin rehberAd degeri parametre olarak verilir
                                                                                                                      //sorgu sonucu donen tablo aktarilir
        } 

        private void btnMusteriKimlikNoAra_Click(object sender, EventArgs e)//musteri kimlik numarasına göre sorgulama yapar
        {
       
            grdwTablo.DataSource = veriTabani.MusteriKimlikNosunaGoreGetir(txtMusteriKimlikNo.Text).Tables[0];
        }

        private void btnRehberKimlikNoAra_Click(object sender, EventArgs e)//rehber kimlik numarasına gore sorgulama yapar
        {
          
            grdwTablo.DataSource = veriTabani.RehberKimlikNosunaGoreGetir(txtRehberKimlikNo.Text).Tables[0];
        }

      
        private void btnDilBilgileriniGoster_Click(object sender, EventArgs e)
        {
   grdwTablo.DataSource = veriTabani.DilBilgileriniGoster(); //DilBilgilerini goster vievinin sonucunu datagridwieve aktarır python için
        }

        private void btnSifreleriGoster_Click(object sender, EventArgs e)
        {
            grdwTablo.DataSource = veriTabani.SifreleriGoster(); //Sifreleri goster vievinin sonucunu datagridwieve aktarır pyhon için
        }
    }
}
