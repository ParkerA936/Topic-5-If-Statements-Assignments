using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Topic_5___If_Statements_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part3();
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
        public static void Part3()
        {
            //Mini Quiz
            string name, ans1, ans2, ans3, ans4;
            int count;
            Console.WriteLine("Hello and welcome to the Maxim Fediv today show!");
            Console.WriteLine("Today will will be doing a quiz about the one, the only, Maxim Fediv!");
            Console.WriteLine("Hello contestant, what is your name?");
            name= Console.ReadLine();
            Console.WriteLine("Okay, " + name + " we will now get this show on the road!");
            Console.WriteLine("I will ask you four questions. Your answer should be either true or false.");
            Console.WriteLine();
            Console.WriteLine(" Question 1");
            Console.WriteLine("Maxim Fediv is 63 inches small.");
            ans1= Console.ReadLine().ToLower();
            count = 0;
            if (ans1 == "true" || ans1 == "t")
            {
                Console.WriteLine("Correct, I guess your not a total idiot." );
                count += 1;
            }
            else if (ans1 == "false" || ans1 == "f")
            {
                Console.WriteLine("Wrong, Maxim Fediv is 63 inches small.");
            }
            else
            {
                Console.WriteLine("Sorry, but that is not a specified answer.");
            }
            Console.WriteLine();
            Console.WriteLine("Question 2");
            Console.WriteLine("Maxim Fediv's cats name is Mrs.Whiskers");
            ans2 = Console.ReadLine().ToLower();
            if (ans2 == "true" || ans2 == "t")
            {
                Console.WriteLine("That is inccorect his cats name is Mr.Whiskers.");
            }
            else if (ans2 == "false" || ans2 == "f")
            {
                Console.WriteLine("Corect his cats name is actully Mr.Whiskers.");
                count += 1;
            }
            else
            {
                Console.WriteLine("Invalid answer.");
            }
            Console.WriteLine();
            Console.WriteLine("Question 3");
            Console.WriteLine("Maxim Fediv has a older brother named Ryan.");
            ans3 = Console.ReadLine().ToLower();
            if (ans3 == "true" || ans3 == "t")
            {
                Console.WriteLine("Wow, fell for it again. Better luck next time");
                
            }
            else if (ans3 == "false" || ans3 == "f")
            {
                Console.WriteLine("Correct, his sisters name is actully Ryan");
                count += 1;
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine();
            Console.WriteLine("Question 4. FINAL QUESTION!");
            Console.WriteLine("Maxim Fediv got is hat from Roots.");
            ans4 = Console.ReadLine().ToLower();
            if (ans4 == "true" || ans4 == "t")
            { Console.WriteLine("Correct!");
                count += 1;
            }
            else if (ans4 == "false" || ans4 == "f")
            { Console.WriteLine("Incorect!"); }
            else {Console.WriteLine("Incorect"); }

            Console.WriteLine(count);

            if (count == 4)
            {
                Console.WriteLine("You got 100% on the quiz!");
                Console.WriteLine("You must be a Maxim Fediv FANBOY");
            }
            if (count == 3)
            {
                Console.WriteLine(" 75% not bad kid.");
            }
            if (count == 2)
            {
                Console.WriteLine("50% I guess it's still a passing grade");
            }
            if (count == 1)
            {
                Console.WriteLine("25% did you even try?");
            }
            if (count ==0)
            {
                Console.WriteLine("Wow your terrible, just give up. Not even a single question right.");
            }



        }
    }
}
