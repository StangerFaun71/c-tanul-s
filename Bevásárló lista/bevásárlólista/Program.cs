using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        int db =0; 
        var beLista = new List<string>();
        

        Console.WriteLine("Bevásárló lista");
        while (true)
        {
            Console.WriteLine("Kérem írjaon be egy vásárolandó dolgot (üres sor kilép):");
            string beSzoveg = Console.ReadLine();
            db++;

            if (string.IsNullOrWhiteSpace(beSzoveg))
            {
                db--;
                break;
            }

            beLista.Add(beSzoveg);
        }

        Console.WriteLine("Az összegyűjtött elemek:");

        foreach (var szoveg in beLista)
        {
            Console.WriteLine(szoveg);
        }
        Console.WriteLine($"Ennyi elem van a listádon {db}");
        Console.ReadLine();
        string eleresiUt = @"C:\Users\"felhasználónév"\Documents\bevásárló lista.txt";

        SaveToTxtFile(beLista, eleresiUt);

        Console.WriteLine($"A lista el lettek mentve a {eleresiUt} fájlba.");

        Console.ReadLine();

    }

    static void SaveToTxtFile(List<string> szovegek, string eleresiUt)
    {
        using (StreamWriter writer = new StreamWriter(eleresiUt))
        {
            writer.WriteLine($"Bevásárló lista:");
            foreach (var szoveg in szovegek)
            {
                writer.WriteLine($"-{szoveg}");
            }
        }
    }

}
