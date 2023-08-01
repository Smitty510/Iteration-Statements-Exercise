namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i>= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int k = 3; k<+999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void AreTheyEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
            }
            else
            {
                Console.WriteLine($"{a} is NOT equal to {b}");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void IsEven(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            }
            else
            {
                Console.WriteLine($"{x} is odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void CheckPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckAge()
        {
            Console.WriteLine("Enter your age: ");
            bool validNumber = int.TryParse(Console.ReadLine(), out int age);

            if (validNumber == true)
            {
                if (age >= 18)
                {
                    Console.WriteLine("You can vote!");
                }
                else
                {
                    Console.WriteLine("You can't vote yet.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, invalid input.");
            }




        }    //Heatin Up Section:
             //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void InRange()
        {
            Console.WriteLine("Enter in a number. We will check to see if it's in range.");
            int number = int.Parse(Console.ReadLine());

            if (number <=10 && number >= -10)
            {
                Console.WriteLine("The number you chose is in range.");
            }
            else
            {
                Console.WriteLine("Sorry, the number you chose is outside of the range.");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DisplayMultiplicationTable(int number)
        {
            Console.WriteLine($"Multiplication Table for {number}:");
            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //Program.PrintNumbers1000();
            //Program.Threes();
            //Program.AreTheyEqual(5, 5);
            //Program.IsEven(15134);
            //Program.CheckPositiveOrNegative(56);
            //Program.InRange();
            //Program.DisplayMultiplicationTable(12);
            //Program.CheckAge();
        }
    }
}
