using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    
    public interface IQueue
    {
        void Insert(Araba newCar); // Kuyruğa ekleme 
        Araba Remove(); // Kuyruktan çıkarma

        // Bu proje için sadece bu fonksiyonlar yeterli görünmüştür.
    }
}
