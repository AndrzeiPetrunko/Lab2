using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            Zadanie2();
        }
        static void Zadanie1()
        {
            Licz liczba1 = new Licz(12);
            liczba1.Pisz();
            liczba1.Dodaj(23);
            liczba1.Pisz();
            liczba1.Dodaj(12);
            liczba1.Pisz();
            liczba1.Odejmij(4);
            liczba1.Pisz();
        }
        static void Zadanie2()
        {
            Console.WriteLine();
            Console.WriteLine("Zadanie 2");
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Sumator obj1 = new Sumator(a);
            Console.WriteLine("Suma liczb: " + obj1.Suma());
            Console.WriteLine("Suma liczb, dzielacych sie na 2: " + obj1.SumaPodziel2());
            Console.WriteLine("Ilosc elementow w tablicy: " + obj1.IleElementow());
            Console.Write("Wszystkie elementy w tablicy: ");
            obj1.WypiszWszystkie();
            obj1.Index(-1, 90);



        }

    }

}
