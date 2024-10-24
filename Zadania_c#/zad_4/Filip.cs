internal class Filip
{
    private static void Main(string[] args)
    //aplikacja konsolowa w C#, która pobiera od użytkownika 4 liczby całkowite. Program sprawdza, czy wszystkie liczby są parzyste, a następnie wypisuje wynik w postaci "Tak" lub "Nie".
    {       
        int[] liczby = new int[4];
        int i = 0;
        while (i < 4)
        {
            Console.Write($"Podaj liczbę: ");
            
            liczby[i]=Convert.ToInt32(Console.ReadLine());
            i++;
 
        }
        Console.WriteLine("\nCzy wszystkie liczby podane przez użytkownika są parzyste? ");
        bool wszystkieParzyste = true;
        foreach (int liczba in liczby)
        {
            if (liczba % 2 != 0)
            {
                wszystkieParzyste = false;
                break; 
            }
        }

        if (wszystkieParzyste)
        {
            Console.WriteLine("Tak");
        }
        else
        {
            Console.WriteLine("Nie");
        }
        Console.ReadLine();
    }
}