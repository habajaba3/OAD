// See https://aka.ms/new-console-template for more information

using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization; // dla parsowania liczb z przecinkiem/kropką

class Program
{
    static void Main()
    {
        string sciezka = "ranking_raw.txt";
        string output = "ranking_cleared.txt";
        if (!File.Exists(sciezka))
        {
            return;
        }

        string[] linieTablica = File.ReadAllLines(sciezka);
        if (linieTablica.Length == 0)
        {
            Console.WriteLine("Plik jest pusty");
            return;
        }

        //Tworzymy listę na linie (łatwiej modyfikować)
        List<string> wynik = new List<string>();
        string header = linieTablica[0];
        wynik.Add(header);
        for (int i = 1; i < linieTablica.Length; i++)
        {
            string linia = linieTablica[i];
            if (string.IsNullOrWhiteSpace(linia)) continue;
            string[] pola = linia.Split(';');
            if (pola.Length != 5)
            {
                Console.WriteLine($"linia {i + 1} ma zła liczbę pól : {linia}");
                continue;
            }

            string nick = pola[0]; // ID
            string czas = pola[1]; // Nazwa
            string punktyTekst = pola[2]; // Kategoria
            string status = pola[3]; // Cena
            string opis = pola[4]; // Ilosc
            bool badtime = (czas == "00:00:01" || czas == "0:00:01");
            bool HACKER = (status == "HACKER" || badtime);
            if (HACKER)
            {
                continue;
            }

            int punkty;
            if (!int.TryParse(pola[4], out punkty))
            {
                punkty = 0;
            }

            string nowaLinia = $"{nick};{czas};{punktyTekst};{status};{opis}";
            wynik.Add(nowaLinia);

        }

        File.WriteAllLines(output, wynik);
        string[] linie = File.ReadAllLines(output);
        foreach (string l in linie)
        {
            Console.WriteLine(l);
        }
    }
}