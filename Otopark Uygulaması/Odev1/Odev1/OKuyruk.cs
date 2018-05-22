using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class OKuyruk:IQueue  //OncelikKuyrugu
    {
       double Toplamsure2=0;
        Araba[] dizi;
        int front = -1;
        int Size;
        int Count;
        public OKuyruk(int value)
        {
            dizi = new Araba[value];
            this.Size = value;
        }

        public void Insert(Araba o)
        {   if(isEmpty())
                 throw new Exception("dizi dolu");
            else
            { front++;
                dizi[front] = o;
                int i=0;
                Araba temp;
                for(i=front;i>0;i--)
                {  if (dizi[i].IslemSuresi > dizi[i - 1].IslemSuresi)
                    {
                        temp = dizi[i - 1];
                        dizi[i - 1] = dizi[i];
                        dizi[i] = temp;
                    }
                    else break;

                }
                Count++;
            } 
         }
        public object Delete()
        {      if (Count== 0)
                throw new Exception("dizi boş");
            Araba temp;
            Toplamsure2+= dizi[front].IslemSuresi;//toplam süreleri topluyor
            dizi[front].ToplamHarcananSure2 = Toplamsure2;// toplam süreleri gerekli elemana yazdırıyor
            dizi[front].SureKazancı = dizi[front].ToplamHarcananSure - dizi[front].ToplamHarcananSure2;//Surekazancını hesaplıyor.
            if (dizi[front].SureKazancı < 0)
                dizi[front].SureKazancı = 0;
            else dizi[front].SureKazancıOranı = 100 * dizi[front].SureKazancı / dizi[front].ToplamHarcananSure;
            //bir üst satırda surekazancının yüzde kaça tekabül ettiğini hesaplayıp oran değişkenine atıyor.

            temp = dizi[front];
            dizi[front] = null;
            front--;
            Count--;
            return temp;
        }
        public object Peek()
        {      if (Count== 0)
                throw new Exception("dizi boş");
            Araba temp;
            temp = dizi[front];

            return temp;
        }
        public Boolean isEmpty()
        {    if (Count == Size)
                return true;
            else
                return false;
        }

    }
}
