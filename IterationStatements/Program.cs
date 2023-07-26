namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintThousand()
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
        public static bool IsEqual(int a, int b)
        {
            var check = (a == b) ? true : false;

            return check;
        }
        //Write a method to check whether a given number is even or odd
        public static bool IsEven(int number)
        {
            return number %2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        public static string CheckPositiveOrNegative(int number)
        {
            if (number > 0)
            {
                return "positive";
            }
            else if (number < 0)
            {
                return "negative";
            }
            else
            {
                return "zero";
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CheckVotingEligibilityUsingTryParse()
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            if (int.TryParse(ageInput, out int age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("You are eligible to vote.");
                }
                else
                {
                    Console.WriteLine("You are not eligible to vote.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
            }
        }    //Heatin Up Section:
             //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsInRange(int number)
        {
            return number >= -10 && number <= 10;
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

        }
    }
}
