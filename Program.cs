using System.Security.Cryptography.X509Certificates;

namespace Topic_5___If_Statements_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part2();
            //Parker
        }
        public static void Part1()
        {
            //Space Boxing
            double weight;
            string planet;
            Console.WriteLine("How much do you weigh on earth?");
            Double.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("I have info on the folowing planets.");
            Console.WriteLine("   1.Venus   2.Mars    3.Jupiter");
            Console.WriteLine("   4.Saturn  5.Uranus  6.Neptune");
            Console.WriteLine("What planet are you visiting? Give corresponding #.");
            planet = Console.ReadLine().ToLower();

            if (planet == "1" || planet == "venus")
            {
                Console.WriteLine("Your weight on venus is " +(weight * 0.78) + "lb.");
            }
            if (planet == "2" || planet == "mars")
            {
                Console.WriteLine("Your weight on Mars is " + (weight * 0.39) + "lb.");
            }
            if (planet == "3" || planet == "jupiter")
            {
                Console.WriteLine("Your weight on Jupiter is " + (weight * 2.65) + "lb.");
            }
            if (planet == "4" || planet == "saturn")
            {
                Console.WriteLine("Your weight on Saturn is " + (weight * 1.17) + "lb.");
            }
            if (planet == "5" || planet == "uranus")
            {
                Console.WriteLine("Your weight on Uranus is " + (weight * 1.05) + "lb.");
            }
            if (planet == "6" || planet == "neptune")
            {
                Console.WriteLine("Your weight on Neptune is " + (weight * 1.23) + "lb.");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public static void Part2()
        { 
        //Simple Calculator
                double num1, num2, answer;
                string math;
        Console.WriteLine("Pick any number.");
            Double.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Pick an operation");
            Console.WriteLine("   1.Add         2.Subract ");
            Console.WriteLine("   3.Multiply   4.Divide");
            Console.WriteLine("   5.Square Root");
            math = Console.ReadLine().ToLower();

            if (math == "5" || math == "sqaure root")
            {
                Console.WriteLine("The sqaure root of " + num1 + " is " + Math.Sqrt(num1)+ ".");
            }
           else
                Console.WriteLine("Pick a second number.");
            Double.TryParse(Console.ReadLine(), out num2);
            if (math == "1" || math ==  "add")
            {
               answer= num1 + num2; 
                Console.WriteLine(num1 + "+" + num2 + "=" +  answer  );
            }
            if (math == "2" || math == "subtract")
            {
                answer = num1 - num2;
                Console.WriteLine(num1 + "-" + num2 + "=" + answer);
            }
            if (math == "3" || math == "multiply")
            {
                answer = num1 * num2;
                Console.WriteLine(num1 + "*" + num2 + "=" + answer);
            }
            if (math == "4" || math == "divide")
            {
                answer = num1 / num2;
                Console.WriteLine(num1 + "/" + num2 + "=" + answer);
            }
            
            
        }
    }
}
