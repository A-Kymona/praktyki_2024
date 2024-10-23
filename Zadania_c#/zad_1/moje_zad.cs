using System;

namespace zad_1

{
    class moje_zad
    {
        //Aplikacja konsoli C#, która pobiera od użytkownika jakiś tekst i zlicza ilość wystąpień znaku również podanego przez użytkownika
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst:");
            string inputText = Console.ReadLine();

            Console.Write("\nPodaj znak do zliczenia:");
            char characterToCount = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int count = 0;
            foreach (char c in inputText)
            {
                if (c == characterToCount)
                {
                    count++;
                }
            }

            Console.WriteLine($"\nZnak '{characterToCount}' występuje {count} razy w podanym tekście.");
            Console.ReadLine();
        }
    }
}