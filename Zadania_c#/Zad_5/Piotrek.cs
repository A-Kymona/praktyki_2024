internal class Piotrek
{
    private static void Main(string[] args)
    //Aplikacja konsoli C#, która pobiera od użytkownika liczbę całkowitą i sprawdza czy jest ona dodatnia, ujemna czy zerowa
    {
        Console.Write("Podaj jakąś liczbę: ");
        int liczba = Convert.ToInt32(Console.ReadLine());
        if (liczba != 0)
        {
            if (liczba > 0) { Console.WriteLine($"\nLiczba {liczba} jest dodatnia"); }
            else { Console.WriteLine($"\nLiczba {liczba} jest ujemna"); }
        }
        else { Console.WriteLine($"\nLiczba {liczba} nie jest ani dodatnia ani ujemna"); }
        Console.ReadLine());
    }
}