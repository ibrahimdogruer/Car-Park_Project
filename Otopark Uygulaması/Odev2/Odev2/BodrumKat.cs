using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class BodrumKat : IStack
    {
        private Araba[] items;
        private int top = -1;

        public BodrumKat(int itemCount)
        {
            this.items = new Araba[itemCount];
        }

        public void Push(Araba item)  //Eleman ekleme 
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Bodrum Stack doldu!");
            }
            items[++Top] = item;
        }
        public string Display()  //Elemanları listeleme
        {
            string temp = "";
            foreach (Araba araba in items)
            {
                if (araba == null)

                    continue;

                temp += "No: " + araba.ArabaNo + "  Renk: " + araba.Renk + Environment.NewLine;
            }
            return temp;
        }

        public Araba Pop()  //Elemanları Stackten çıkarma
        {
            if (IsEmpty())
                System.Windows.Forms.MessageBox.Show("Bodrum Katı Boşalmıştır..");

            Araba temp = items[Top];    //En üstteki eleman temp'e alınıyor
            items[Top] = null;         //ve o eleman siliniyor.
            Top--;
            return temp;
        }

        public Araba Peek()
        {
            return items[Top];
        }
        public bool IsEmpty()  //Stack boş mu?
        {
            return Top == -1 ? true : false;
        }

        public int Top      //Stack'in en üstteki elamanının indisi
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }

    }
}
