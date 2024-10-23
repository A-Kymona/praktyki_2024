internal class Krzysiek
{
    private static void Main(string[] args)
    //Aplikacja konsoli C# która pobiera od użytkownika 2 liczby, wykonuje na nich działania odejmowania, mnożenia, dodawania i dzielenia i je wyświetla.
    {
        double iloraz1, iloraz2, liczba2,suma, roznica1,roznica2, iloczyn,liczba1;
        Console.Write("Podaj pierwszą liczbę: ");
        liczba1 = double.Parse(Console.ReadLine());
        Console.Write("\nPodaj drugą liczbę: ");
        liczba2 = double.Parse(Console.ReadLine());

        suma = liczba2 + liczba1;
        
        roznica2 = liczba1 - liczba2; 

        roznica1 = liczba2 - liczba1; 
        
        iloczyn = liczba2 * liczba1;

        Console.WriteLine($"\nSuma liczb {liczba1} i {liczba2} wynosi {suma}");
        Console.WriteLine($"\nRóżnica liczb {liczba1} i {liczba2} wynosi {roznica2}");
        Console.WriteLine($"\nRóżnica liczb {liczba2} i {liczba1} wynosi {roznica1}");
        Console.WriteLine($"\nIloczyn  liczb {liczba1} i {liczba2} wynosi {iloczyn}");

        if (liczba2 != 0 && liczba1 != 0){
            if (liczba2 != 0)
            {
                iloraz1 = liczba1 / liczba2;
                Console.WriteLine($"\nIloraz liczb {liczba1} i {liczba2} wynosi {iloraz1}");
            }
            if (liczba1 != 0)
            {
                iloraz2 = liczba2 / liczba1;
                Console.WriteLine($"\nIloraz liczb {liczba2} i {liczba1} wynosi {iloraz2}");
            }
        }
        else
        {
            Console.WriteLine("\nNie można dzielić przez 0.");
        }
    }
}