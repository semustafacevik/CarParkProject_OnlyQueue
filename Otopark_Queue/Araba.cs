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
        public int kuyrukSirasi;
        public int kuyrukSirasi_Oncelikli;
        public double islemTamamlamasuresi;
        public double islemTamamlamasuresi_Oncelikli;
        public double ortIslemtamamlamaSuresi;
        public double ortIslemtamamlamaSuresi_Oncelikli;

        public Araba(string arabaAdi, int islemSuresi)
        {
            ad = arabaAdi;
            this.islemSuresi = islemSuresi;
        }
    }
}
