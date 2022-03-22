using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev
{
    enum CINSIYET
    {
        ERKEK,
        KADIN
    }
    enum MEDENİDURUM
    {
        EVLİ,
        BEKAR
    }
    class Personel
    {
        public Ajanda[] ajanda = new Ajanda[10];

        private string ad;
        private string soyad;
        private DateTime dogum_tarihi;
        private string meslek;
        private CINSIYET cinsiyet;
        private MEDENİDURUM medeni_durum;
        private decimal maas;
        private string Email;
        private string Adres;
        private int yas;





        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                soyad = value;
            }
        }
        public DateTime Dogum_Tarihi
        {
            get
            {
                return dogum_tarihi;
            }
            set
            {
                dogum_tarihi = value;
            }
        }
        public string Meslek
        {
            get
            {
                return meslek;
            }
            set
            {
                meslek = value;
            }
        }
        public CINSIYET Cinsiyet
        {
            get
            {
                return cinsiyet;
            }
            set
            {
                cinsiyet = value;
            }
        }
        public MEDENİDURUM Medeni_Durum
        {
            get
            {
                return medeni_durum;
            }
            set
            {
                medeni_durum = value;
            }
        }
        public decimal Maas
        {
            get
            {
                return maas;
            }
            set
            {
                maas = value;
            }
        }

        public int Yas
        {
            get
            {
                return DateTime.Now.Year - dogum_tarihi.Year;
            }
        }

     
        public string adres
        {
            get
            {
                return Adres;
            }
            set
            {
                Adres = value;
            }
        }
        public string email
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }


        public Personel(string ad, string soyad)
        {
            this.ad = ad;
            this.soyad = soyad;
        }

        public decimal ZamYap(decimal neKadarZam)
        {
            return neKadarZam + maas;
        }

        public  decimal KalanGunSayisi()
        {
            if (yas > 57)
            {
                return -1;
            }
            else if (yas == 57)
            {
                return 0;
            }
            else
            {
                return 57 - yas;
            }
        }

        public void DosyayaYaz(Personel[] personel)
        {
            string pathFile = @"C:\Users\SOVLERA\Downloads\OKUL\odev\odev\data.txt";
            FileStream fs = new FileStream(pathFile, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            string[] phone1 = new string[2] { personel[0].ajanda[0].TelAdi, personel[0].ajanda[0].TelNo };
            string[] phone2 = new string[2] { personel[0].ajanda[1].TelAdi, personel[0].ajanda[1].TelNo };
            string phone1birlestirme = string.Join(",", phone1);
            string phone2birlestirme = string.Join(",", phone2);

            string[] phone1birlestirmephone2 = new string[2] { phone1birlestirme, phone2birlestirme };
            string phone1_phone2 = string.Join("+", phone1birlestirmephone2);

            string[] personnel = new string[10] { personel[0].ad, personel[0].soyad, personel[0].dogum_tarihi.ToShortDateString(), personel[0].Meslek, personel[0].cinsiyet.ToString(), personel[0].medeni_durum.ToString(), personel[0].Maas.ToString(), phone1_phone2, personel[0].Email, personel[0].Adres };
            string birlestir = string.Join("|", personnel);
            sw.WriteLine(birlestir);

            sw.Flush();
            sw.Close();
        }
        

        public static List<Personel> DosyadanOku()
        {
            string filePath = @"C:\Users\SOVLERA\Downloads\OKUL\odev\odev\data.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            List<Personel> kayitliPersonel = null;
            string personelBilgisi = "";
            StreamReader sr = new StreamReader(fs);          
            bool varMi = true;

            while ((personelBilgisi = sr.ReadLine()) != null)
            {
                if (varMi)
                {
                    kayitliPersonel = new List<Personel>();
                    varMi = false;
                }
                if (personelBilgisi != null)
                {
                    personelBilgisi.Replace(" ", string.Empty);  // Boşlukları temizleyelim.
                    string[] parcala = personelBilgisi.Split('|');  // Okunan satırı parçalayalım . 

                    

                    Personel okunanPersonel = new Personel("", "");
                    okunanPersonel.Ad = parcala[0];
                    okunanPersonel.soyad = parcala[1];
                    okunanPersonel.dogum_tarihi = Convert.ToDateTime(parcala[2]);
                    okunanPersonel.meslek = parcala[3];
                    okunanPersonel.cinsiyet = (parcala[4] == "ERKEK" ? CINSIYET.ERKEK : CINSIYET.KADIN);
                    okunanPersonel.medeni_durum = (parcala[5] == "BEKAR" ? MEDENİDURUM.BEKAR : MEDENİDURUM.EVLİ);
                    okunanPersonel.maas = Convert.ToInt32(parcala[6]);
                    
                    okunanPersonel.email = parcala[8];
                    okunanPersonel.adres = parcala[9];
                   
                   
                    kayitliPersonel.Add(okunanPersonel);
                }
                   
            }
           
            return kayitliPersonel;
        }



    }
}
