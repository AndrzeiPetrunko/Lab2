using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab
{
    class Liczba
    {
        private int[] tablica;
        public Liczba(string liczba)
        {
            int dlugosc = liczba.Length;
            tablica = new int[dlugosc];
            for(int i = 0; i < dlugosc; i++)
            {
                tablica[i] = liczba[i];
            }
        }
        public void Wypisywanie()
        {
            Console.Write("Wypisywanie: ");
            foreach(int i in tablica)
            {
                Console.Write(i - '0' + " ");
            }
            Console.WriteLine();
        }
        public void Mnozenie(int number)
        {
            string liczSTR = "";
            foreach(char x in tablica)
            {
                liczSTR += x;
            }
            int liczINT = Convert.ToInt32(liczSTR);
            string wynik = Convert.ToString(liczINT * number);
            int[] tablica2 = new int[wynik.Length];
            for (int i = 0; i < wynik.Length; i++)
            {
                tablica2[i] = wynik[i];
            }
            tablica = tablica2;


        }
        public void Silnia(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Silnia z liczby ujemnej nie istnieje.");
            } else if (n == 0 || n == 1 ) {
                Console.WriteLine($"Silnia z {n} jest równa 1.");
            } else
            {
                BigInteger wynik = 1;
                for (int i = 2; i <= n; i++)
                {
                    wynik *= i;
                }

                Console.WriteLine($"Silnia z {n} jest równa {wynik}");
            }
            
        }
        
    }   

}



