using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class BirinciKat : IQueue
    {
        private Araba[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public BirinciKat(int _size)
        {
            this.size = _size;
            Queue = new Araba[_size];
        }
        public void Ekle(Araba a)   //Eleman ekleme
        {
            if (count == size)
                throw new Exception("Otopark dolu!");

            if (front == -1)  //İlk eleman ekleme
                front = 0;

            if (rear == size - 1)  //Döngüsel Kuyruk işlemi
            {                     //rear son elemana geldiğinde rear'ı ilk indise eşitliyor.  
                rear = 0;
                Queue[rear] = a;
            }
            else
                Queue[++rear] = a;  //Ekleme

            count++;
        }

        public Araba Cikar()  //Eleman çıkarma 
        {
            if (IsEmpty())
                System.Windows.Forms.MessageBox.Show("Otoparkta Araç Kalmamıştır!");

            Araba temp = Queue[front];  //İlk sıradaki eleman temp'e alınıyor
            Queue[front] = null;       //ve kuyruktan kaldırılıyor. 

            if (front == size - 1)    //Döngüsel Kuyruk işlemi 
                front = 0;           //front son elemana geldiğinde front'u ilk indise eşitliyor   
            else
                front++;

            count--;
            if (count == 0)  //Eleman kalmadığında
            {
                System.Windows.Forms.MessageBox.Show("Bütün Arabalar Çıkış Yapmıştır.");
            }

            return temp;
        }
        public string ArabaListele()  //Elamnaları Listeleme
        {
            string temp = "";

            if (count == 0)
                System.Windows.Forms.MessageBox.Show("Otopark Boş.");
            if (count != 0)
            {
                foreach (Araba araba in Queue)
                {
                    if (araba == null)
                        continue;
                    temp += "No: " + araba.ArabaNo + "  Renk: " + araba.Renk + Environment.NewLine;
                }
            }
            return temp;
        }

        public Araba Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()  //Kuyruk boş mu?
        {
            return (count == 0);
        }
    }
}
