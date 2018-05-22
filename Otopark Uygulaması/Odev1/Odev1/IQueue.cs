using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    public interface IQueue
    {
        void Insert(Araba o);
        object Delete();
        object Peek();
        Boolean isEmpty();

    }
}
