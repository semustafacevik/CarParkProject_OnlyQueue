using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class ArabaKuyrugu_Oncelikli : IQueue
    {
        public Araba[] Kuyruk;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public ArabaKuyrugu_Oncelikli(int kuyrukBoyutu)
        {
            size = kuyrukBoyutu;
            Kuyruk = new Araba[kuyrukBoyutu];
        }

        public void Insert(Araba yeniAraba)
        {
            if (IsEmpty())
            {
                Kuyruk[++front] = yeniAraba;
                count++;
            }

            else
            {
                int arabaIndexi = count - 1; // Kuyruk[arabaIndexi] -> Kuyruk[2] vb.
                for (arabaIndexi = count - 1; arabaIndexi >= 0; arabaIndexi--)
                {
                    if (yeniAraba.islemSuresi > Kuyruk[arabaIndexi].islemSuresi) // İşlem süreleri karşılaştırılıyor.
                        Kuyruk[arabaIndexi + 1] = Kuyruk[arabaIndexi];

                    else
                        break;
                }
                Kuyruk[arabaIndexi + 1] = yeniAraba;
                front++;
                count++;
            }
        }

        private int cikisSuresi = 0;

        public Araba Remove()
        {
            Araba cikanAraba = Kuyruk[front];
            Kuyruk[front] = null;

            cikisSuresi += cikanAraba.islemSuresi; 

            cikanAraba.kuyruktanCikissuresi_Oncelikli += cikisSuresi;

            front--;
            count--;

            return cikanAraba;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}
