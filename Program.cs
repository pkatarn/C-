using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0d; //definicja zmiennej a typu double z wartoscia poczatkowa 0.0
            double b = 0.0d; //to samo dla b        
            double c = 0.0d; //to samo dla c

            Console.Write("Podaj wartosc a: "); //wyswietlamy komunikat "Podaj wartosc a: "

            if (double.TryParse(Console.ReadLine(), out a) == false) 
            {
                Console.WriteLine("Niepoprawna wartosc a!"); //konwertujemy wpisana liczbe z typu znakowego na typ liczbowy. Jezeli konwersja sie nie uda, wyswietlamy komunikat o bledzie
            }
            else //w przeciwnym wypadku, jezeli konwersja zostala zakoczona pomyslnie, to:
            {
                Console.Write("Podaj wartosc b: "); //wyswietlamy komunikat "Podaj wartosc b: "

                if (double.TryParse(Console.ReadLine(), out b) == false)
                {
                    Console.WriteLine("Niepoprawna wartosc b!"); //to samo tylko dla b
               
                }
                else //jezeli konwersja dla zmiennej b powiodla sie, to:
                {
                    Console.Write("Podaj wartosc c: "); //wyswietlamy komunikat "Podaj wartosc c: "

                    if (double.TryParse(Console.ReadLine(), out c) == false) //mniej wiecej w tym miejscu byl prosty blad, zamiast sprawdzania poprawnosci wpisanej liczby c, program jeszcze raz sprawdzal zmienna b
                    {
                        Console.WriteLine("Niepoprawna wartosc c!"); //to samo tylko dla c
                    }
                    else //jezeli konwersja dla zmiennej c powiodla sie, to:
                    {
                        double wynik = Math.Sqrt((a + b + c) * (a + b - c) * (a - b + c) * (-a + b + c)) / 4; //definiujemy zmienna lokalna wynik, ktorej wartosc przypisujemy jako wynik dzialania:
                        // pierwiastek kwadratowy z ((a+b+c)*(a+b-c)*(a-b+c)(-a_b_c))/4
                        if (double.IsNaN(wynik))
                        {
                            Console.WriteLine("BLAD");
                        }
                        else
                        {
                            Console.WriteLine("Wynikiem zadania jest {0}", wynik); //wyswietlanie na ekranie wyniku
                        }
                    }

    
                }
            }Console.ReadKey(); //program czeka nacisniecie dowolnego klawisza, aby zakonczyc dzialanie
        }
       
    }
    
}
