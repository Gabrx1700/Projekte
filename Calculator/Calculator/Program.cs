using System;

// Programm starten
class Program
{
    static void Main()
    {
        // Titel anzeigen
        Console.WriteLine("Taschenrechner");

        // Erste Zahl
        Console.Write("Erste Zahl: ");
        double zahl1 = Convert.ToDouble(Console.ReadLine());

        // Operator eingeben
        Console.Write("Operator (+, -, *, /): ");
        string operatorZeichen = Console.ReadLine();

        // Zweite Zahl
        Console.Write("Zweite Zahl: ");
        double zahl2 = Convert.ToDouble(Console.ReadLine());

        // Ergebnis speichern
        double ergebnis = 0;

        // Plus rechnen
        if (operatorZeichen == "+")
        {
            ergebnis = zahl1 + zahl2;
        }

        // Minus rechnen
        else if (operatorZeichen == "-")
        {
            ergebnis = zahl1 - zahl2;
        }

        // Mal rechnen
        else if (operatorZeichen == "*")
        {
            ergebnis = zahl1 * zahl2;
        }

        // Geteilt rechnen
        else if (operatorZeichen == "/")
        {
            // Null prüfen
            if (zahl2 == 0)
            {
                Console.WriteLine("Fehler: Nicht durch 0 teilen!");
                return;
            }

            ergebnis = zahl1 / zahl2;
        }

        // Falscher Operator
        else
        {
            Console.WriteLine("Ungültiger Operator!");
            return;
        }

        // Ergebnis anzeigen
        Console.WriteLine("Ergebnis: " + ergebnis);
    }
}
