using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class ArabaKuyrugu_Oncelikli : IQueue
    {
        // Kuyruk için gerekli tanımlamaların yapılması - öncelikli kuyruk olduğu için rear değişkenine gerek yoktur -
        public Araba[] Kuyruk;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public ArabaKuyrugu_Oncelikli(int kuyrukBoyutu)
        {
            size = kuyrukBoyutu;
            Kuyruk = new Araba[kuyrukBoyutu];
        }

        /// <summary>
        /// Kuyruğa araba ekleme fonksiyonu
        /// </summary>
        /// <param name="yeniAraba">Kuyruğa eklenecek ilgili araba</param>
        public void Insert(Araba yeniAraba)
        {
            if (count == 0) // kuyrukta araba yoksa front değerine ilgili araba eklenir
            {
                Kuyruk[++front] = yeniAraba;
                count++;
            }

            else // kuyrukta araba varsa işlem süresine bakılarak ekleme yapılır - işlem süresi en az olan front değerine eklenir
            {
                int arabaIndexi; // Kuyruk[arabaIndexi] -> Kuyruk[2] vb

                for (arabaIndexi = count - 1; arabaIndexi >= 0; arabaIndexi--)
                {
                    if (yeniAraba.islemSuresi > Kuyruk[arabaIndexi].islemSuresi) // İşlem sürelerinin karşılaştırılması
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


        /// <summary>
        /// Kuyruktan araba çıkarma fonksiyonu
        /// </summary>
        /// <returns>Kuyruktan çıkan ilgili araba</returns>
        public Araba Remove()
        {
            Araba cikanAraba = Kuyruk[front];
            Kuyruk[front] = null;

            cikisSuresi += cikanAraba.islemSuresi; 
            cikanAraba.islemTamamlamasuresi_Oncelikli += cikisSuresi;  // çıkan arabaya ait çıkış süresinin hesaplanması

            front--;
            count--;

            return cikanAraba;
        }
    }
}
