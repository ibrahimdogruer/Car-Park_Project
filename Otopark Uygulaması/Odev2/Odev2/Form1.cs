using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Odev2
{
    public partial class Form1 : Form
    {
        BodrumKat bkat = new BodrumKat(15);           //Katların nesneleri oluşturuluyor.
        BirinciKat kat1 = new BirinciKat(15);
        IkinciKat kat2 = new IkinciKat();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)  //Araçları Listeleme Butonu
        {
            lblBodrumKat.Visible = true;
            lblIkinciKat.Visible = true;
            lblkat1siradakiler.Visible = true;

            if (kat1.IsEmpty())    //1.kat boşsa otopark da boştur.
            {
                MessageBox.Show("Otopark Boş!");
                button3.Enabled = false;
            }
            else
                lblkat1siradakiler.Text = kat1.ArabaListele();

            if (!bkat.IsEmpty())   //bodrum katı boş değilse
            {
                lblBodrumKat.Text = bkat.Display();
                button2.Enabled = true;         //Araba Çıkar butonu aktif ediliyor.
            }

            if (kat2.Size != 0)   //2.kat boş değilse
                lblIkinciKat.Text = kat2.DisplayElements();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba a31 = new Araba(311, "Lavanta");      //Bodrum kattaki arabalar
            Araba a32 = new Araba(312, "Leylak Rengi");
            Araba a33 = new Araba(313, "Limoni");
            Araba a34 = new Araba(314, "Nar Rengi");
            Araba a35 = new Araba(315, "Nane Yeşili");
            Araba a36 = new Araba(316, "Prusya");
            Araba a37 = new Araba(317, "Siyah");
            Araba a38 = new Araba(318, "Teal");
            Araba a39 = new Araba(319, "Tarçın Rengi");
            Araba a40 = new Araba(320, "Turkuaz");
            Araba a41 = new Araba(321, "Zeytuni");
            Araba a42 = new Araba(322, "Zümrüt");
            Araba a43 = new Araba(323, "Mercan");
            Araba a44 = new Araba(324, "Altın");
            Araba a45 = new Araba(325, "Yeşim");

            Araba a1 = new Araba(111, "Mavi"); //1.kattaki arabalar
            Araba a2 = new Araba(112, "Mor");
            Araba a3 = new Araba(113, "Yeşil");
            Araba a4 = new Araba(114, "Sari");
            Araba a5 = new Araba(115, "Pembe");
            Araba a6 = new Araba(116, "Beyaz");
            Araba a7 = new Araba(117, "Alev Kırmızısı");
            Araba a8 = new Araba(118, "Gök Mavisi");
            Araba a9 = new Araba(119, "Asker Yeşili");
            Araba a10 = new Araba(120, "Barut Rengi");
            Araba a11 = new Araba(121, "Bebek Mavisi");
            Araba a12 = new Araba(122, "Bej");
            Araba a13 = new Araba(123, "Bordo");
            Araba a14 = new Araba(124, "Buğday Rengi");
            Araba a15 = new Araba(125, "Cam Göbeği");

            Araba a16 = new Araba(211, "Çam Yeşili");  //2.kattaki arabalar
            Araba a17 = new Araba(212, "Çelik Mavisi");
            Araba a18 = new Araba(213, "Fildişi Rengi");
            Araba a19 = new Araba(214, "Gri");
            Araba a20 = new Araba(215, "Gül Rengi");
            Araba a21 = new Araba(216, "Gümüş");
            Araba a22 = new Araba(217, "Haki");
            Araba a23 = new Araba(218, "Hardal Rengi");
            Araba a24 = new Araba(219, "Kahverengi");
            Araba a25 = new Araba(220, "Karanfil Rengi");
            Araba a26 = new Araba(221, "Kayısı Rengi");
            Araba a27 = new Araba(222, "Kırmızımsı");
            Araba a28 = new Araba(223, "Koyu Mavi");
            Araba a29 = new Araba(224, "Koyu Yeşil");
            Araba a30 = new Araba(225, "Lacivert");

            bkat.Push(a45);  //Bodrum kata arabalar eklendi..
            bkat.Push(a44);
            bkat.Push(a43);
            bkat.Push(a42);
            bkat.Push(a41);
            bkat.Push(a40);
            bkat.Push(a39);
            bkat.Push(a38);
            bkat.Push(a37);
            bkat.Push(a36);
            bkat.Push(a35);
            bkat.Push(a34);
            bkat.Push(a33);
            bkat.Push(a32);
            bkat.Push(a31);

            kat1.Ekle(a1);   //Kat1 e arabalar eklendi..
            kat1.Ekle(a2);
            kat1.Ekle(a3);
            kat1.Ekle(a4);
            kat1.Ekle(a5);
            kat1.Ekle(a6);
            kat1.Ekle(a7);
            kat1.Ekle(a8);
            kat1.Ekle(a9);
            kat1.Ekle(a10);
            kat1.Ekle(a11);
            kat1.Ekle(a12);
            kat1.Ekle(a13);
            kat1.Ekle(a14);
            kat1.Ekle(a15);

            kat2.Insert(a30);  //Kat2 ye arabalar eklendi..
            kat2.Insert(a29);
            kat2.Insert(a28);
            kat2.Insert(a27);
            kat2.Insert(a26);
            kat2.Insert(a25);
            kat2.Insert(a24);
            kat2.Insert(a23);
            kat2.Insert(a22);
            kat2.Insert(a21);
            kat2.Insert(a20);
            kat2.Insert(a19);
            kat2.Insert(a18);
            kat2.Insert(a17);
            kat2.Insert(a16);

        }

        private void button2_Click(object sender, EventArgs e)  //Araç Çıkarma Butonu
        {
            lblCikanArac.Visible = true;

            Random rastgele = new Random();   //0 ile 1 arasında rastgele sayı (%50 için)
            int secim = rastgele.Next(0, 2);

            if (bkat.IsEmpty() && kat2.Head == null)  //Bodrum katı ve 2.kat boş ise
                secim = -1;

            else if (bkat.IsEmpty())    //Sadece bodrum katı boş ise
                secim = 1;

            else if (kat2.Size == 0)   //Sadece bodrum katı boş ise
                secim = 0;

            if (secim == 0)         //secim 0 ise bodrum kattan eleman pop et.
            {
                lblCikanArac.Text = kat1.Cikar().ToString();
                if (!bkat.IsEmpty())
                    kat1.Ekle(bkat.Pop());
            }
            else if (secim == 1)    //secim 0 ise 2.kattan eleman Delete et.
            {
                lblCikanArac.Text = kat1.Cikar().ToString();
                if (kat2.Size > 0)
                    kat1.Ekle(kat2.Delete());
            }
            //secim 0 veya 1 değilse yani bodrum ve 2.kat boş ise sadece 1.kattan araba çıkar. 
            else
                lblCikanArac.Text = kat1.Cikar().ToString();

            //Listeleme
            if (kat2.Size > 0)
                lblIkinciKat.Text = kat2.DisplayElements();
            else
                lblIkinciKat.Text = "İkinci Kat Boştur";

            if (!bkat.IsEmpty())
                lblBodrumKat.Text = bkat.Display();
            else
                lblBodrumKat.Text = "Bodrum Katı Boştur";

            if (!kat1.IsEmpty())
                lblkat1siradakiler.Text = kat1.ArabaListele();
            else
            {
                lblkat1siradakiler.Text = "Otopark Boştur.";
                button2.Enabled = false;
                btnHesapla.Enabled = true;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)  //5 saniyede yapılan işlem
        {
            double islemSayisi = 0, islemSuresi = 0;
            islemSuresi = kat2.IslemSuresiHesaplama();          //2.kattaki islemSuresiHesaplama metodu çağrılıyor.
            islemSayisi = 5 / islemSuresi;                     //5' i bulunan işlem süresine bölüp işlem sayısını hesaplıyor.
            islemSayisi = Convert.ToInt32(islemSayisi);       //double'ı int'e çeviriyor.
            txtIslemSayisi.Text = "5 saniyede " + islemSayisi.ToString() + " işlem yapılmıştır.";
        }
    }
}
