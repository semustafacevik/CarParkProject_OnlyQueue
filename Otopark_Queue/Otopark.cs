using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class Otopark
    {
        public List<Araba> OtoparktakiArabalar;

        public Otopark(int arabaSayisi)
        {
            OtoparktakiArabalar = new List<Araba>(arabaSayisi);
        }

        public void OtoparkaArabaEkle(Araba yeniAraba)
        {
            OtoparktakiArabalar.Add(yeniAraba);
        }
    }
}
