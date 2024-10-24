using System;

namespace zad_1
{
    class moje_zad
    {
        // Aplikacja konsoli C#, która pobiera od użytkownika jakiś tekst i zlicza ilość wystąpień znaku również podanego przez użytkownika
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj tekst:");
                string inputText = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    Console.WriteLine("Tekst nie może być pusty. Spróbuj ponownie.");
                    continue; 
                }

                Console.Write("\nPodaj znak do zliczenia:");
                string znakInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(znakInput) || znakInput.Length != 1 )
                {
                    Console.WriteLine("\nPodano nieprawidłowe dane. Czy chcesz spróbować ponownie? (t/n) : ");
                    string wybor = Console.ReadLine().ToLower();

                    if (wybor == "t")
                    {
                        Console.WriteLine("Czy chcesz wprowadzić wszystkie dane od nowa? (t/n)");
                        string odp = Console.ReadLine().ToLower();

                        if (odp == "t")
                        {
                            Console.Clear();
                            continue; 
                        }
                        else
                        {
                            Console.Write("\nPodaj znak do zliczenia:");
                            znakInput = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(znakInput) || znakInput.Length != 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Nieprawidłowy znak. Kończę program.");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Kończę program.");
                        break;
                    }
                }

                char zliczanie = znakInput[0];
                int count = 0;

                foreach (char c in inputText)
                {
                    if (c == zliczanie)
                    {
                        count++;
                    }
                }

                Console.WriteLine($"\nZnak '{zliczanie}' występuje {count} razy w podanym tekście.");
                Console.WriteLine("\nCzy chcesz użyć progamu jeszcze raz? (t/n)");
                string ponownie = Console.ReadLine().ToLower();

                if (ponownie != "t")
                {
                    Console.Clear();
                    break; 
                }
            }

            Console.WriteLine("Dziękuję za skorzystanie z programu.");
            Console.ReadLine();
        }
    }
}
