using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class Araba
    {
        public string ad;
        public int islemSuresi;

        public Araba()
        {
        }

        public Araba(string arabaAdi, int islemSuresi)
        {
            ad = arabaAdi;
            this.islemSuresi = islemSuresi;
        }
    }
}
