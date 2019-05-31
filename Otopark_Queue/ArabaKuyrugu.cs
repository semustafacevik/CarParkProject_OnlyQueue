using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class ArabaKuyrugu : IQueue
    {
        // Kuyruk için gerekli tanımlamalar
        public Araba[] Kuyruk;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;

        public ArabaKuyrugu(int kuyrukBoyutu)
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
            if (front == -1)
                front = 0;

            Kuyruk[++rear] = yeniAraba;
            count++;
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
            cikanAraba.islemTamamlamasuresi += cikisSuresi; // çıkan arabaya ait çıkış süresinin hesaplanması

            front++;
            count--;

            return cikanAraba;
        }
    }
}
