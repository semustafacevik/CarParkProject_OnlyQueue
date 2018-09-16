using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public interface IQueue
    {
        void Insert(Araba newCar);
        Araba Remove();
        Boolean IsEmpty();
    }
}
