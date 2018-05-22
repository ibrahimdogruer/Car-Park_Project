using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public interface IStack
    {
        void Push(Araba item);
        Araba Pop();
        Araba Peek();
        bool IsEmpty();
        int Top { get; set; }
    }
}
