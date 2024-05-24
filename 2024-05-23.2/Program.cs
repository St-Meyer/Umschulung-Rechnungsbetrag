using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_05_23._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Settings
            Console.OutputEncoding = Encoding.UTF8;

            // Deklaration
            double price1, price2, price3, 
                   sum, vat_amount ,endsum;
            int number1, number2, number3, 
                vat = 19; // Mehrwertsteuersatz von 19%

            // Eingabe und Initailaisierung
            Console.WriteLine("Herzlich Willkommen im Programm XY, "+
                              "wir berechnen Ihren Rechnungsbetrag.\n");
            Console.WriteLine("1. Produkt");
            Console.Write("Anzahl: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Preis: ");
            price1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n2. Produkt");
            Console.Write("Anzahl: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Preis: ");
            price2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n3. Produkt");
            Console.Write("Anzahl: ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("Preis: ");
            price3 = double.Parse(Console.ReadLine());

            // Berechnung
            sum = (number1 * price1) + (number2 * price2) + (number3 * price3);
            vat_amount = sum * vat / 100;
            endsum = vat_amount + sum;

            // Ausgabe
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nNettopreis: {0}€", sum);
            Console.WriteLine("Mehrwertsteuer 19%: {0}€", vat_amount);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Gesamtsumme: {0}€", endsum);
            Console.WriteLine("════════════════════");
            Console.ResetColor();
        }
    }
}