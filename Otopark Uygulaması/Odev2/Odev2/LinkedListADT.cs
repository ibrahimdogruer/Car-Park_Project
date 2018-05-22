using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public abstract class LinkedListADT
    {
        public Node Head;
        public Node Last;
        public int Size = 0;
        public abstract void Insert(Araba a);
        public abstract Araba Delete();
    }
}
