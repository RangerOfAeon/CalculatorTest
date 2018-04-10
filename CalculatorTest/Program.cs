using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{
   public class CalculatorTest
    {
        public static void Main(string[] args)
        {
            int Continue = 1;                                              // Här sätter jag upp variablen som får loopen att loppas, för att välja
            string choose;                                                 // operatör & för att hålla talen.
            double First;
            double Second;

            while (Continue > 0)                                           // Här börjar jag while-loopen, och sedan får jag användaren att skriva in
            {                                                              // ett tal, som omvandlar till en double.
                Console.Clear();
                Console.WriteLine("Skriv ditt första tal");
                First = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Välj din operatör. Välj emellan:");     // Här väljer användaren sin operatör, och dom kan vänja emellan +, -, *, /.
                Console.WriteLine("+        -          *          /");
                choose = Console.ReadLine();

                Console.WriteLine("Skriv ditt andra tal");                 // Får använderan att skriva ett till nummer som blir till en double.
                Second = Convert.ToDouble(Console.ReadLine());
                
                switch (choose)
                {
                    case "+":                                              // Här kommer koden att välja vilken operatör beronde på vad användaren
                        double SummaAdd = Addition(First, Second);         // valde innan, och dom alla kallar på sin särskilda metod för att räkna ut  
                        Console.WriteLine(SummaAdd);                       // vad summan blir. Det går i ordningen Addition, Minus, Times och Division. 
                        break;
                    case "-":
                        double SummaMin = Minus(First, Second);
                        Console.WriteLine(SummaMin);
                        break;
                    case "*":
                        double SummaTim = Times(First, Second);
                        Console.WriteLine(SummaTim);
                        break;
                    case "/":
                        double SummaDiv = Division(First, Second);
                        Console.WriteLine(SummaDiv);
                        break;
                    default:
                        Console.WriteLine("Detta var ingen operatör, börja om från början");
                        break;
                }

                Console.WriteLine("Skriv 0 om du vill avsluta, skriv 1 eller ett högre tal för att fortsätta.");  // Här frågar koden om användaren vill
                Continue = int.Parse(Console.ReadLine());                                                         // fortsätta, genom att skriva 0 om
            }                                                                                                     // man vill avsluta, annars 1 eller 
            double Addition(double FirstAdd, double SecondAdd)                                                    // högre för att fortsätta.
            {
                double SummaAdd = FirstAdd + SecondAdd;
                return SummaAdd;
            }
            double Minus(double FirstMin, double SecondMin)                // Här är metoderna, i samma ordning som switch-casen, och det är dom som
            {                                                              // räknar ut summan av talet, beroende på vilken operatör användaren 
                double SummaMin = FirstMin - SecondMin;                    // använder.
                return SummaMin;
            }
            double Times(double FirstTim, double SecondTim)
            {
                double SummaTim = FirstTim * SecondTim;
                return SummaTim;
            }
            double Division(double FirstDiv, double SecondDiv)
            {
                double SummaDiv = FirstDiv / SecondDiv;
                return SummaDiv;
            }


        }
        
    }
}
