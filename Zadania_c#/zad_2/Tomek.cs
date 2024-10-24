using System.Diagnostics.CodeAnalysis;

internal class Tomek
{
    private static void Main(string[] args)
    {
        //Aplikacja konsoli C# która po wczytaniu z klawiatury 3 liczb całkowitych wypisze na ekran ich sumę oraz informację czy ich reszta z dzielenia jest równa 0.
        int liczba1, liczba2, liczba3, suma;
        Console.Write("Podaj pierwszą liczbę:");
        liczba1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPodaj drugą liczbę:");
        liczba2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nPodaj trzecią liczbę:");
        liczba3 = Convert.ToInt32(Console.ReadLine());
                
        suma = liczba1 + liczba2 + liczba3;
        if (suma % 3 == 0)
        {
            Console.WriteLine("\nSuma trzech podanych przez Ciebie liczb wynosi " + suma + ". I jest podzielna przez 3");
        }
        else
        {
            Console.WriteLine("\nSuma trzech podanych przez Ciebie liczb wynosi " + suma + ". I nie jest podzielna przez 3");
        }
        Console.ReadLine());
    }
}
