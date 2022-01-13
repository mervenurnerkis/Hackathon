# -*- coding: utf-8 -*-
"""
Created on Wed Dec 29 14:02:49 2021

@author: TUBA AKBAŞ
"""

import hashlib
from cryptography.fernet import Fernet
from ecies.utils import generate_eth_key
from ecies import encrypt
import binascii
import pyodbc

class DilKontrol:
    
    def _init_(self):
        pass
    
    def cumlelereAyir(self, metin):
            cumle=metin.split(".")#cumledeki nokta işaretine gore boler
            cumleSayisi=len(cumle)
            return cumleSayisi-1 #cumle nokta ile bittiginden dolayı cumle sayisindan 1 cikarttik       
            
    def kelimelereAyir(self, metin): 
            kelime=metin.split()#cumledeki bosluklara gore boller
            kelimeSayisi=len(kelime)
            return kelimeSayisi #kelime sayisini doner    
    
    def sesliHarfleriSay(self, metin):
            sesliHarfler="AEIİOÖUÜaeıioöuü"##sesli harfler tanimlanir
            sayac=0
            for i in metin:#metnin her bir karakteri i degiskenine sırayla atilip kontrol edilir ahmett 
                if i in sesliHarfler:##uyusan var ise sayac bir artirilir a> A a>E.
                    sayac=sayac+1
            return sayac #toplam sesli harf sayisini doner

              
    def buyukUnluUyumKontrolEt(self,metin): 
       kelimeler=metin.split()
       kalinUnluler="aıouAIOU" ##kalın ünlüler tanımlanır
       inceUnluler="eiöüEİÖÜ)"##ince ünlüler tanimlanır
       kuralaUymayanSayisi=0 #buyuk unlu uyumuna uymayan sayisini tutmak icin kullanilir
       kuralaUyanSayisi=0
       
       inceUnlusonuc=False #kontrol ici kullanilir
       kalinUnluSonuc=False
       
       for kelime in kelimeler: #kelimeler listesinin her bir elemanini i degiskenine sırayla atilip kontrol edilir MUSTAFA,MEHMET
      
        for j in kelime:#kelimenin her bir harfi icinde donulur mustafa m,u,s,t,a,f,a, şeklinde
           if j in inceUnluler: # harf inceunlulerrde kontrol edilir 
                inceUnlusonuc=True # ince unlu bulduysa inceunlu sonucu true yapilir
           if j in kalinUnluler: # harf kalin unlulerde varmi bakilir
               kalinUnluSonuc=True #varsa true sonucu doner
        if inceUnlusonuc and kalinUnluSonuc:##eger iki sonuc true ise iki kısmada girdigi icin kurala uymaz
            kuralaUymayanSayisi=kuralaUymayanSayisi+1
            inceUnlusonuc=False #bir sonraki kelime icin false degerlerine geri cekilir
            kalinUnluSonuc=False
            
        elif inceUnlusonuc==False and kalinUnluSonuc==False: ##ikiside degilse
             continue
            
            
        else: ##biri false biri true ise yani iki harf dizisinide icermiyorsa kuralla uyuyordur 
           kuralaUyanSayisi=kuralaUyanSayisi+1 
           inceUnlusonuc=False #bir sonraki kelime icin false degerlerine geri cekilir
           kalinUnluSonuc=False
       return (kuralaUymayanSayisi,kuralaUyanSayisi)##kurala uymayan ve uyan sayisi tuple olarak dondurulur


class SifrelemeYontemleri:   
    def _init_(self): #kurucu metod
        pass
    
    
    def ecies(self,str): #asimetrik sifreleme
        privKey = generate_eth_key()#asimetirik şifrelemede iki anahtar kullanılır
        pubKeyHex=privKey.public_key.to_hex()
        encrypted = encrypt (pubKeyHex, str.encode())
        enc= binascii.hexlify(encrypted)#ikili gösterimi onaltılıya dönüştürür
        return enc
    
    def fernetSifrele(self, str): #Simetrik Sifreleme
        anahtar = Fernet.generate_key()# simetrikte sifrelemede tek anahtar kullanilir
        fernet = Fernet(anahtar)#anahtar Fernetin kurucu  metoduna  parametre olarak verilir ve fernet nesnesi olusturulur
        sifreliMesaj = fernet.encrypt(bytes(str.encode())) #str encode(utf-8 e gore) edilir sonra byte cevrilir ve sifrelenir
        return sifreliMesaj
    
    #Hash 6 tane
    def sha256(self, str):
        sifreliMesaj = hashlib.sha256(str.encode()) 
        return (sifreliMesaj.hexdigest())##mesaj sifrelenir ve geri donderilir
    
    def sha384(self,str):
        sifreliMesaj = hashlib.sha384(str.encode())       
        return (sifreliMesaj.hexdigest())
        
    def sha224(self,str):
        sifreliMesaj = hashlib.sha224(str.encode())      
        return (sifreliMesaj.hexdigest())
        
    def sha512(self,str):
        sifreliMesaj = hashlib.sha512(str.encode())
        return (sifreliMesaj.hexdigest())
        
    def sha1(self,str):
        sifreliMesaj = hashlib.sha1(str.encode())
        return (sifreliMesaj.hexdigest())
    def md5(self,str):
        result = hashlib.md5(str.encode())##mesaj encode edilir ve sifrelenir
        result.update(b"str")
        return (result.hexdigest())##olusan sifre 16 lık tabana cevrilerek ekrana yazdirilir
class HELP:
    
    conn = pyodbc.connect(
        "Driver={SQL Server Native Client 11.0};"
        "Server=DESKTOP-TLNPHQ6;"
        "Database=TurRehberi;"
        "Trusted_Connection=yes;"
    )

    cursor = conn.cursor()
    
    dosya = open("bilgiler.txt","w",encoding="utf-8")#kodların bulundugu kısma acar
    def _init_(self):
     pass
    
    def SifrelemeYontemleriSinifi(self, metin):
        
          try:
            sifre=SifrelemeYontemleri() # pyAdi.classAdi ile Sifreleme Yontemleri Sinifinin nesnesi olusturuldu
            ##ata olmadigi zaman sifreler ekrana yazdirlir
            HELP.dosya.write("\n")
            HELP.dosya.write("""|sha1:| Bir hash şifrleme yöntemidir. Bir  mesajı uzunluğundan daha kısa bir bit dizisi elde etmeye çalışır. 
160 bitlik özet oluşturur. Verilen metnin sifreli bitleri onaltılık biçimde döndürülür.\n"""
                             +"Metnin Sha1 İle Sifrelenmiş Hali:" + sifre.sha1(metin)+"\n\n") #sifre nesnesinden yararlanilarak sifrelendirme islemi yapilir
            
            HELP.dosya.write("""|sha224:| Bir hash şifrleme yöntemidir. 224 bittir. SHA-2 şifreleme karma işlevleri grubunun bir parçasıdır.
Karma işlevi, metin dosyası gibi rastgele bir veri öğeleri kümesini tek bir sabit uzunluk değerine (karma) dönüştüren (karma) bir algoritmadır.
Verilen metni sifreli bir sekilde geri döndürülür.\n"""
                             +"Metnin Sha224 İle Sifrelenmiş Hali:"+ sifre.sha224(metin)+"\n\n")
            
            HELP.dosya.write("""|sha256:| Bir hash şifrleme yöntemidir. 256 bit boyutunda olup veriler hash değerlerine dönüştürülür. 
Tek yönlü bir şifreleme algoritmasıdır. Kodlanmış veriler onaltılık biçimde döndürülür.\n"""
                             +"Metnin Sha256 İle Sifrelenmiş Hali:"+ sifre.sha256(metin)+"\n\n")
            
            HELP.dosya.write("""|sha384:| Bir hash şifrleme yöntemidir. Sha 1' in evrimi olan şifreleme algoritmasıdır. 
Çıktı 384 bitte kesilmesi dışında Sha512 ile aynı şifrelemedir.\n"""
                             +"Metnin Sha384 İle Sifrelenmiş Hali:"+ sifre.sha384(metin)+"\n\n")
            
            HELP.dosya.write("""|sha512:| Bir hash şifrleme yöntemidir. Herhangi bir uzunluktaki metni sabit boyutlu bir dizeye dönüştürmek için kullanılan bir karma algoritmadır.
Her çıktı, 512 bitlik (64 bayt) bir SHA-512 uzunluğu üretir.\n"""
                             +"Metnin Sha512 İle Sifrelenmiş Hali:"+ sifre.sha512(metin)+"\n\n")
            
            HELP.dosya.write("""|md5:| Bir hash şifrleme yöntemidir. MD5, metni 128 bitlik uzunluğa dönüştürür verileri her biri 32 bitten oluşan 16 kelimeye bölünmüş 512 bitlik diziler halinde işler.
MD5'ten gelen çıktı, 128 bitlik bir mesaj özeti değeridir.
Önceki aşamada hesaplanan değerle birlikte her 512 bitlik veri bloğunu işleyen ayrı aşamalarda gerçekleştirilir. 
İlk aşama, ardışık onaltılık sayısal değerler kullanılarak başlatılan mesaj özeti değerleriyle başlar. 
Her aşama, mevcut veri bloğundaki değerleri ve önceki bloktan işlenen değerleri işleyen dört mesaj özeti geçişi içerir. 
Son bloktan hesaplanan son değer, o blok için MD5 özeti olur.\n"""
                             +"Metnin Md5 İle Sifrelenmiş Hali:"+ sifre.md5(metin)+"\n\n")
            
            HELP.dosya.write("""|fernetSifrele:| Bir simetrik sifreleme yöntemidir. Fernet, şifrelenen mesajın anahtar olmadan okunmamasını sağlayan simetrik bir şifreleme yöntemidir.
Anahtar Fernetin kurucu  metoduna  parametre olarak verilir ve fernet nesnesi olusturulur. Str encode(utf-8 e gore) edilir sonra byte cevrilir ve sifrelenir.\n"""
                             +"Metnin Fernent İle Sifrelenmiş Hali:" + str(sifre.fernetSifrele(metin))+"\n\n")#geri dönüs olan byte str formatina cevrilip ekrana yazilir
            
            HELP.dosya.write("""|ecies:| Bir asimetrik sifreleme yöntemidir. Fernet, 56 bit ECC public anahtarını kullanarak bir mesajı şifreler. Asimetrik şifrelemedir. 
Publickey onaltılık tabana çevrilir. Şifrelemek istediğimiz metin encode edilerek encrypt edildi. Encrypt olan metin ikilik gösterimden onaltılıya dönüştürüldü.\n"""
                             +"Metnin Ecies İle Sifrelenmiş Hali: " 
                             +str(sifre.ecies(metin))+"\n\n")#geri dönüs olan byte str formatina cevrilip ekrana yazilir
           
            HELP.cursor.execute("INSERT INTO tblSifreler (Metin, Sha1, Sha224, Sha256, Sha384, Sha512, Md5, Fernet, Ecies) VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?)", 
                               (metin, sifre.sha1(metin), sifre.sha224(metin), sifre.sha256(metin), sifre.sha384(metin), sifre.sha512(metin), sifre.md5(metin), str(sifre.fernetSifrele(metin)),  str(sifre.ecies(metin))))
            HELP.conn.commit()
            print("Veritabanına Eklendi")  
          except AttributeError:
             print()
             print("Lütfen Metin Giriniz!")
          except OverflowError:
             print()
             print("Hata: Dosya İçerisindeki Metin Çok Uzun")

        
    def DilKontrolSinifi(self, metin):
      
         try:
            dil=DilKontrol() #Dil Kontrol sifinin nesnesi olusturuldu
            ##dil sinifinin fonksiyonlari yazildi
            HELP.dosya.write("\n")
            HELP.dosya.write("|CumlelereAyir:| fonksiyonu kendisine gönderilen metni split fonksiyonu yardımıyla noktalara göre ayırır ve bir listeye atar. Liste boyutu bir azaltılarak boyutu döndürülür.\nCumle Sayisi:"                    
                             + str(dil.cumlelereAyir(metin))+"\n\n") #dil nesnesinden yararlanilarak dil kontrolleri saglanir
                            
            
            HELP.dosya.write("|kelimelereAyir:| fonksiyonu kendisine gönderilen metni split fonksiyonu yardımıyla ayırır ve bir diziye atar listeye boyutunu döndürür.\nKelime Sayisi:"
                            + str(dil.kelimelereAyir(metin))+"\n\n")
            
            HELP.dosya.write("""|sesliHarfleriSay:| fonksiyonu kendisine gönderilen metnin her bir karakterini sesli harfler listesinin içinde olup olmadığına bakar. 
Bakılan karakter sesli harf ise sesli harf sayacini artirir metnin karakterleri bittiğinde  sesli harf sayacinin değerini geri döndürür.\nSesli Harf Sayisi:"""
                             + str(dil.sesliHarfleriSay(metin))+"\n\n")
            
            HELP.dosya.write("""|buyukUnluUyumKontrolEt:| fonksiyonu kendisine gönderilen metnin her bir kelimesini split fonksiyonu ile bir listeye atar.
Her bir kelime her bir harfi ince ünlüler ve kalın ünlüler listesi içinde olup olmadığına bakılır kelime sadece ince unlu veya kalin unlulerden olusuyor ise
Ünlü uyumuna uyan sayac 1 arttırılır. İkisinede uyuyorsa unlu uyumuna uymayan sayac 1 arttırılır ve sayaclar tuple olarak geri döndürülür.\nBüyük Ünlü Uyumuna Uymayan Sayisi:"""
                             + str(dil.buyukUnluUyumKontrolEt(metin)[0])+"\n")
            
            HELP.dosya.write("Büyük Ünlü Uyumuna Uyan Sayisi:"+ str(dil.buyukUnluUyumKontrolEt(metin)[1])+"\n")
            
            
            HELP.cursor.execute("INSERT INTO tblDilKontrol (Metin, CumleSayisi, KelimeSayisi, SesliHarfSayisi, BuyukUnluUyumunaUymayanSayisi, BuyukUnluUyumunaUyanSayisi) VALUES(?, ?, ?, ?, ?, ?)", 
                               (metin, dil.cumlelereAyir(metin), dil.kelimelereAyir(metin), dil.sesliHarfleriSay(metin), dil.buyukUnluUyumKontrolEt(metin)[0], dil.buyukUnluUyumKontrolEt(metin)[1])) 
            HELP.conn.commit()
            print("Veritabanına Eklendi\n")
            
         except TypeError:
            print("Hatalı Tip Girişi!")
    
    def main(self): 
       nesne=HELP()
       dosyaYolu=("Mesaj.txt")#kodların bulundugu kısımda arar
       dosya=open(dosyaYolu,"r",encoding="utf-8")
       
       HELP.dosya.write("Metniniz: "+dosya.read()+"\n")## txt basina metni yazdiriyoruz
       dosya.close()
       dosya=open(dosyaYolu,"r",encoding="utf-8")
    
       print("Dil Kuralları için Fonksiyonların Çalışması:",'\n')#dil kontrolu yapmak için tekrar acıyorum
       nesne.DilKontrolSinifi(dosya.read())
       dosya.close()
       
       dosya=open(dosyaYolu,"r",encoding="utf-8")
       print("Şifreleme Yöntemleri için Fonksiyonların Çalışması:",'\n')#Metni sifreleme için tekrar acıyorum
       dosya=open(dosyaYolu,"r",encoding="utf-8")
       nesne.SifrelemeYontemleriSinifi(dosya.read())
       
       dosya.close()
       HELP().dosya.close()#kayit icin acilan dosya kapatilir
       
    
            
      
           
