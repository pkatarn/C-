using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0;
            double b = 0.0;
            double c = 0.0;
            double p = 0.0;
            double s = 0.0;

            Console.WriteLine("Program liczy pole dowolnego trojkata wzorem Herona. Nacisnij dowolny klawisz, aby kontynuować.");
            Console.ReadKey();

            Console.Write("Podaj wielkosc boku a: ");
            if (double.TryParse(Console.ReadLine(), out a) == false )
            {
                Console.WriteLine("zla wartosc 'a', prosze podac liczbe!");
            }
            else
            {
                Console.Write("Podaj wielkosc boku b: ");
                if (double.TryParse(Console.ReadLine(), out b) == false)
                {
                    Console.WriteLine("zla wartosc 'b', prosze podac liczbe!");
                }
            else
                {
                    Console.Write("Podaj wielkosc boku c: ");
                    if (double.TryParse(Console.ReadLine(), out c) == false)
                    {
                        Console.WriteLine("zla wartosc 'c', prosze podac liczbe!");
                    }
                    else if (a + b > c && a + c > b && b + c > a)
                    {

                        p = (a + b + c) / 2;
                        s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine("Wynikiem jest {0}", s);
                    }
                    else
                    {
                        Console.WriteLine("Niestety podane wartosci sa ...");
                    }
                }
            }
            Console.ReadKey();




        }
    }
}
