using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public class Queue : IQueue
    {
        double Toplamsure=0;
        Araba[] dizi;
        int Size;
        int front = -1;
        int rear = -1;
        int Count = 0;
        public Queue(int value)
        {
            this.Size = value;
            dizi = new Araba[value];
        }

        public object Delete()
        {
           if (Count==0)
                throw new Exception("dizi boş");
           Araba temp;
           temp = dizi[front];
            Toplamsure += dizi[front].IslemSuresi;
           dizi[front].ToplamHarcananSure = Toplamsure;
           
           front++;
           Count--;
            return temp;

        }

        public void Insert(Araba o)
        {
            
            if (isEmpty())
                throw new Exception("dizi doluu!");
            if (front == -1)
            {
                rear++;
                front++;
                dizi[front] = o;
                Count++;
            }
            else
            {   rear++;
                dizi[rear] = o;
                Count++;
            }

        }

        public bool isEmpty()
        {         if (Count == Size)
                return true;
            else
                return false;
           
        }

        public object Peek()
        {     if (Count == 0)
                throw new Exception("dizi boş hocam..");
            Araba temp;
            temp = dizi[rear];


            return temp;
        }

       
    }
}
