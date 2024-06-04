using System;
namespace session5;
public class Atom
{

    public int AtomicNumber { get; set; }
    public string Symbol { get; set; }
    public string FullName { get; set; }
    public float AtomicWeight { get; set; }

    public bool Accept()
    {
        Console.Write("Enter atomic number: ");
        if (!int.TryParse(Console.ReadLine(), out int atomicNumber) || atomicNumber <= 0)
        {
            Console.WriteLine("Invalid symbol. Try again.");
            return false;
        }

        Console.Write("Enter symbol: ");
        string symbol = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(symbol))
        {
            Console.WriteLine("Invalid symbol. Try again.");
            return false;
        }

        Console.Write("Enter full name: ");
        string fullName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fullName))
        {
            Console.WriteLine("Invalid symbol. Try again.");
            return false;
        }

        Console.Write("Enter atomic weight: ");
        if (!float.TryParse(Console.ReadLine(), out float atomicWeight) || atomicWeight <= 0)
        {
            Console.WriteLine("Invalid symbol. Try again.");
            return false;
        }

        AtomicNumber = atomicNumber;
        Symbol = symbol;
        FullName = fullName;
        AtomicWeight = atomicWeight;
        return true;
    }
    public void Display()
    {
        Console.WriteLine($"{AtomicNumber} {Symbol} {FullName} {AtomicWeight}");
    }
}
