namespace CSharpTestPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter the functions you want to test:");
            Console.WriteLine("1. AddTwoNumbers");
            Console.WriteLine("2. IsEven");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter two integers to add:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The sum is: {AddTwoNumbers(a, b)}");
                    break;
                case "2":
                    Console.WriteLine("Enter an integer to check if it's even:");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Is the number even? {IsEven(number)}");
                    break;
                case "3":
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    GreetUser(name);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            }

        //==============  Functions ========================
        //  Create a function named AddTwoNumbers that takes two integers and returns their sum.
        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        //  Write a method called IsEven that returns true if a number is even
        public static bool IsEven(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            // Check if the number is even
            // An even number is divisible by 2 with no remainder
            if (number < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            if (number == 0)
            {
                return true; // 0 is considered even
            }
            // Return true if the number is even, false otherwise
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        //  Create a method GreetUser(string name) that prints 'Welcome, <name>!
        public static void GreetUser(string name)
        {
            // Validate the input name
            if (string.IsNullOrEmpty(name))
            {
                // Throw an exception if the name is null or empty
                throw new ArgumentException("Name cannot be null or empty.");
            }
            Console.WriteLine($"Welcome, {name}!");
        }


    }
}
