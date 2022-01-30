using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    { 
        DateTime NOW = DateTime.Now;
        string sr = $"{NOW}.txt";
        using (StreamWriter sw = File.CreateText(sr))
        {
            string A;
            sw.WriteLine("Captains Log");
            sw.WriteLine("Stardate " + NOW);
            do
            {
                Console.WriteLine(NOW);
                A = Console.ReadLine();
                if (A == "start") do { A = Console.ReadLine(); sw.WriteLine(Console.ReadLine()); } 
                    while (A != "stop");
            } while (A != "stop");
            sw.WriteLine("Jean-Luc Pacard");

        }
    }
}

