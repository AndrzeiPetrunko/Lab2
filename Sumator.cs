using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Sumator
    {
        private int[] Liczby;
        public Sumator(int[] x)
        {
            this.Liczby = x;
        }
        public int Suma()
        {
            int sum = 0;
            foreach (int x in Liczby)
            {
                sum += x;
            }
            return sum;
        }
        public int SumaPodziel2()
        {
            int sum2 = 0;

            foreach (int x in Liczby)
            {
                if (x % 2 == 0)
                {
                    sum2 += x;
                }

            }
            return sum2;
        }
        public int IleElementow()
        {
            int ilosc = 0;
            foreach (var x in Liczby)
            {
                ilosc++;
            }
            return ilosc;
        }
        public void WypiszWszystkie()
        {
            foreach (var x in Liczby)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
        }
        public void Index(int lowIndex, int highIndex)
        {
            while (lowIndex < 0)
            {
                lowIndex++;
            }
            while (highIndex >= Liczby.Length - 1)
            {
                highIndex--;
            }
            for (int i = lowIndex; i <= highIndex; i++)
            {
                Console.Write($"{Liczby[i]} ");
            }
        }
    }
}
