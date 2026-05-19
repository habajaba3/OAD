using System;

class Program
{
    static void Main(string[] args)
    {
        double cena = PobierzCene();

        WyswietlMenu();

        int wybor = PobierzWybor();

        IRabat rabat = WybierzRabat(wybor);

        double nowaCena = rabat.Oblicz(cena);

        WyswietlWynik(nowaCena);
    }

    static double PobierzCene()
    {
        double cena;

        while (true)
        {
            Console.Write("Podaj cenę produktu: ");

            if (double.TryParse(Console.ReadLine(), out cena) && cena >= 0)
            {
                return cena;
            }

            Console.WriteLine("Błędna wartość.");
        }
    }

    static void WyswietlMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1 - Brak rabatu");
        Console.WriteLine("2 - Rabat 10%");
        Console.WriteLine("3 - Rabat 20 zł");
    }

    static int PobierzWybor()
    {
        int wybor;

        while (true)
        {
            Console.Write("Wybierz opcję: ");

            if (int.TryParse(Console.ReadLine(), out wybor)
                && wybor >= 1
                && wybor <= 3)
            {
                return wybor;
            }

            Console.WriteLine("Niepoprawny wybór.");
        }
    }

    static IRabat WybierzRabat(int wybor)
    {
        switch (wybor)
        {
            case 1:
                return new BrakRabatu();

            case 2:
                return new RabatProcentowy(10);

            case 3:
                return new RabatStaly(20);

            default:
                return new BrakRabatu();
        }
    }

    static void WyswietlWynik(double wynik)
    {
        Console.WriteLine();
        Console.WriteLine($"Cena po rabacie: {wynik} zł");
    }
}
