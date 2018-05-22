using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev1
{  public partial class Form1 : Form
    {
        Queue OtoparkKuyrugu;
        OKuyruk OncelikKuyrugu;
        double OrtalamaSure1,OrtalamaSure2;
        int ArabaSayisi;
        List<Araba> Arabalar= new List<Araba>();
        public Form1()
        {  
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.Bounds.Location;       
    
        }
        private void txtSayi_TextChanged(object sender, EventArgs e)// girişde text deki veriyi kullanmak için çalışıyor.
        {
            int sayi = Convert.ToUInt16(txtSayi.Text);
            this.OtoparkKuyrugu = new Queue(sayi);
            this.OncelikKuyrugu = new OKuyruk(sayi);
            this.ArabaSayisi = sayi;

        }
        private void btnEkle_Click(object sender, EventArgs e)// Kuyruklara arabaları ekleme butonu!!!
        {
            Random rast = new Random();
            int i;
            for (i = 1; i <= ArabaSayisi; i++)
            {
                Araba car = new Araba();
                car.Numara = i;
                car.IslemSuresi = rast.Next(0, 10);
                OtoparkKuyrugu.Insert(car);
                OncelikKuyrugu.Insert(car);
            }
            MessageBox.Show("Kuyruklara araçlar eklenmiştir.");
        }



        private void btnKuyruk_Click(object sender, EventArgs e)//Kuyruk dan arabaları çıkarıp  yazdırma butonu!!
        {   int i;
            Araba Keeper;
            if (ArabaSayisi == 0)
                OtoparkKuyrugu.Delete();//bu metodun içine burada girerse kuyruk boş oldugu için hata verecektir..
            else
            {
                for (i = 0; i < ArabaSayisi; i++)
                {      //burada kuyruk dan silinen nesneyi Keeper'a atayarak ardından text 'e yazdırma işlemi yapılıyor
                         Keeper = (Araba)OtoparkKuyrugu.Delete();
                         textBox1.Text += Environment.NewLine + "Araba No:" + Keeper.Numara+ "  " +
                        "Araba İslem Suresi:" + Keeper.IslemSuresi+ "    " +
                        "Toplam Gecen süre :" + Keeper.ToplamHarcananSure + Environment.NewLine;


                    OrtalamaSure1 = Keeper.ToplamHarcananSure / ArabaSayisi;
                }
                textBox1.Text += "Ortalama işlem Tamamlama Süresi: " + OrtalamaSure1 + Environment.NewLine+ Environment.NewLine;

            }
        }
       
        

        private void button1_Click_1(object sender, EventArgs e)//Oncelik kuyrugundan arabaları çıkarıp yazdırma butonu!!!
        {
            int i;
            Araba Keeper;
            if (ArabaSayisi == 0)
                OncelikKuyrugu.Delete();// burada delete metod'u çağrıldığında hata verecektir.
            else
            {
                 for (i = 0; i < ArabaSayisi; i++)
                    {
                       Keeper = (Araba)OncelikKuyrugu.Delete();//Arabayı oncelik kuyruğundan siliyor ve keeper'a atıyor.
                    txtOncelik.Text += Environment.NewLine + "Araba No:" + Keeper.Numara + "  " +
                    "Araba İslem Suresi:" + Keeper.IslemSuresi + "      " +
                    "Toplam Gecen süre :" + Keeper.ToplamHarcananSure2 +
                    "      Sure Kazancı:  " + Keeper.SureKazancı+
                    "      Kazanc Oranı %"+Keeper.SureKazancıOranı+
                       Environment.NewLine;

                    if (Keeper.ToplamHarcananSure2 < Keeper.ToplamHarcananSure)
                           Arabalar.Add(Keeper);
                    //2.durumdaki bekleme süresi daha azsa sonradan yazdırılmak üzere bir listeye atıyor. 

                    OrtalamaSure2 = Keeper.ToplamHarcananSure2;
                    }
                textBox1.Text += Environment.NewLine + "Ortalama İşlem tamamlama süresi:" + (OrtalamaSure2 / ArabaSayisi);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//2. durumda daha az Bekleyen aracları gösteren buton!!
        {   int i;
            if (ArabaSayisi == 0)
                 MessageBox.Show("Araba yok");
            else
            {      foreach (Araba Reader in Arabalar)
                {  txtAz.Text += Environment.NewLine + "Araba No:" + Reader.Numara + "  " +
                   "Araba İslem Suresi:" + Reader.IslemSuresi + "      " +
                   "Toplam Gecen süre :" + Reader.ToplamHarcananSure2 + Environment.NewLine;
                }
            }
       }
        
   }
}
