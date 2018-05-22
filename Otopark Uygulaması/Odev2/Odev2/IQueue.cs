using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public interface IQueue
    {
        void Ekle(Araba a);
        Araba Cikar();
        Araba Peek();
        Boolean IsEmpty();
    }
}
