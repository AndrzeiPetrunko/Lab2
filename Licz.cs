using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Licz
    {
        private int value;
        public int Dodaj(int n)
        {
            this.value += n;
            return value;
        }
        public int Odejmij(int n)
        {
            this.value -= n;
            return value;
        }

        public void Pisz()
        {
            Console.WriteLine(value);
        }
        public Licz(int n)
        {
            this.value = n;
        }
    }
}
