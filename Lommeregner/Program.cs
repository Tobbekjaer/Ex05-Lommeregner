using System.ComponentModel.Design;

namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Menu();

            



            Console.ReadLine();
        }


        
        static void Menu()
        {

        

            Console.Clear();

            

            Console.WriteLine(
    @"Min lommeregner: 
1. Brug addition
2. Brug subtraktion
3. Brug division
4. Brug multiplikation
5. Luk lommeregneren...");

            // Creating a new instance of the Calculator class
            Calculator calc = new Calculator();

            // Jeg erklærer to variable
            int num1 = 8;
            int num2 = 4;
            var key = Console.ReadKey(true); // Jeg laver et nyt key instance, som skal være true, så det læser tastaturtrykket med det samme

            // Opretter et switch statement til at oprette forskellige udfald
            switch (key.Key) // Vi bruger vores variabel key med .Key metoden, som kan læse hvilken tast, der bliver trykket på
            {
                case ConsoleKey.D1: // Læser tasten 1 fra tastaturet
                    int add = calc.Add(num1, num2); // Bruger calc.Add() metoden fra Calculator.cs
                    Console.ReadLine(); 
                    Menu();
                    break;
                case ConsoleKey.D2:
                    int subtract = calc.Subtract(num1, num2); 
                    Console.ReadLine();
                    Menu();
                    break;
                case ConsoleKey.D3:
                    double divide = calc.Divide(num1, num2); 
                    Console.ReadLine();
                    Menu();
                    break;
                case ConsoleKey.D4:
                    int multiply = calc.Multiply(num1, num2); 
                    Console.ReadLine();
                    Menu();
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("Du tastede: 5");
                    Console.WriteLine("Du valgte at lukke lommeregneren...");
                    break;
                default:
                    Console.WriteLine("Ugyldigt input: vælg igen...");
                    Console.ReadLine();
                    Menu();
                    break;
                    

            }




        }
    }
}