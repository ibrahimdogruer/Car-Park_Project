using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Odev2
{
    public class IkinciKat : LinkedListADT
    {
        Stopwatch islemSuresi = new Stopwatch();   //İşlem süresi hesaplamak için.

        public void InsertFirstItem(Araba a)     //İlk eklenen eleman (Henüz eleman eklememişse).
        {
            Node tmpHead = new Node
            {
                Data = a
            };
            Head = tmpHead;       //tmpHead'i Head'e atanıyor.
            Last = Head;         //İlk eleman olduğu için Last Head'e atanıyor.
            Head.Next = Last;   //Dairesel olduğu için Head'in Next'i Last'ı gösteriyor.
        }
        public override void Insert(Araba a) //Eleman Ekleme
        {
            Node tmpHead = new Node
            {
                Data = a
            };

            if (Head == null)        //Liste boşsa
                InsertFirstItem(a);
            else
            {
                tmpHead.Next = Head;     //tmpHead'in Next'i Head'i gösteriyor.
                Last.Next = tmpHead;    //Last'ın Next'i Head'i gösteriyor(Dairesel Bağlı Liste).
                Head = tmpHead;        //Yeni Head tmpHead oldu.   
            }
            Size++;                  //LinkedList'teki eleman sayısı arttı.
        }

        public string DisplayElements()    //Elemanları listeleme
        {
            string temp = "";
            Node item = Head;
            do
            {
                temp += "" + item.Data;
                item = item.Next;
            } while (item != Head);


            return temp;
        }
        public double IslemSuresiHesaplama()  //İşlem Süresini Hesaplama
        {
            double _islemSuresi = 0;
            _islemSuresi = islemSuresi.Elapsed.TotalSeconds;

            return _islemSuresi;
        }
        public override Araba Delete()   //Elaman Silme (Josephus Problemine uyarlayarak)
        {
            islemSuresi.Start();       //İşlem süresini başlat.
            Node tmp = null;

            if (Head != null)
            {
                tmp = Head.Next;               //Head'in Next'i tmp'ye atanıyor.
                Head.Next = Head.Next.Next;   //Head'in Next'ine onun da Next'i atanıyor (Head'in Next'ini silmek için)
                Head = Head.Next;            //Head.Next yeni Head oluyor (Yani aradaki eleman silinip bir sonrakini Head yapıyor).
            }
            if (Size == 1)      //Son elemandan sonra Head ve Last null yapılıyor.
            {
                Head = null;
                Last = null;
            }
            Size--;

            islemSuresi.Stop();    //İşlem süresini durdur.
            return tmp.Data;
        }
    }
}
