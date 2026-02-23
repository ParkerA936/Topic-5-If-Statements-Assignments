namespace Topic_5___If_Statements_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            //Parker
        }
        public static void Part1()
        {
            //Space Boxing
            int weight;
            Console.WriteLine("How much do you weigh on earth?");
            int.TryParse(Console.ReadLine(), out weight);
            Console.WriteLine("I have info on the folowing planets.");
            Console.WriteLine("1.Venus   2.Mars    3.Jupiter");
            Console.WriteLine("4.Saturn  5.Uranus  6.Neptune");
            Console.WriteLine("What planet are you visiting?");


        }
    }
}
