﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark_Queue
{
    public class ArabaKuyrugu : IQueue
    {
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

        public void Insert(Araba yeniAraba)
        {
            if (front == -1)
                front = 0;

            Kuyruk[++rear] = yeniAraba;
            count++;
        }

        public Araba Remove()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
    }
}