namespace CSharpTestPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Test Practice!");
            Console.WriteLine("Choose a section to test:");
            Console.WriteLine("1. Functions");
            Console.WriteLine("2. Loops");
            Console.WriteLine("3. Arrays");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Functions();
                    break;
                case "2":
                    Loops();
                    break;
                case "3":
                    Arrays();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    break;
            }

        }

        //==============  Functions ========================
        public static void Functions()
        {
            Console.WriteLine("Hello,In Functions Section!");
            Console.WriteLine("Enter the functions you want to test:");
            Console.WriteLine("1. AddTwoNumbers");
            Console.WriteLine("2. IsEven");
            Console.WriteLine("3. GreetUser");
            Console.WriteLine("4. Max");
            Console.WriteLine("5. Factorial");
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
                case "4":
                    Console.WriteLine("Enter two doubles to find the maximum:");
                    double x = double.Parse(Console.ReadLine());
                    double y = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The maximum value is: {Max(x, y)}");
                    break;
                case "5":
                    Console.WriteLine("Enter a number to calculate its factorial:");
                    int n = int.Parse(Console.ReadLine());
                    try
                    {
                        Console.WriteLine($"The factorial of {n} is: {Factorial(n)}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
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

        //  Define a method Max that takes two doubles and returns the greater one.
        public static double Max(double a, double b)
        {
            // Check if the first number is greater than the second
            if (a > b)
            {
                return a; // Return the first number if it's greater
            }
            else
            {
                return b; // Otherwise, return the second number
            }


        }

        // Create a recursive method to calculate factorial of a number.
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Number must be non-negative.");
            }
            if (n == 0 || n == 1)
            {
                return 1; // Base case: factorial of 0 or 1 is 1
            }
            else
            {
                return n * Factorial(n - 1); // Recursive case
            }
            /* 
            For example, to calculate Factorial(5):
            It returns 5 * Factorial(4)
            Factorial(4) returns 4 * Factorial(3)
            Factorial(3) returns 3 * Factorial(2)
            Factorial(2) returns 2 * Factorial(1)

            */
        }

        //============== Loops ========================

        public static void Loops()
        {
            Console.WriteLine("Hello,In Loops Section!");
            // Add loop-related methods here
            Console.WriteLine("Choose a loop to test:");
            Console.WriteLine("1. PrintNumbers");
            Console.WriteLine("2. PrintEvenNumbers");
            Console.WriteLine("3. AcceptPassword");
            Console.WriteLine("4. SumNumbers");
            Console.WriteLine("5. PrintNames (using foreach)");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrintNumbers();
                    break;
                case "2":
                    PrintEvenNumbers();
                    break;
                case "3":
                    AcceptPassword();
                    break;
                case "4":
                    SumNumbers();
                    break;
                case "5":
                    Console.WriteLine("Enter names separated by commas:");
                    string input = Console.ReadLine();
                    string[] names = input.Split(',');
                    PrintNames(names);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        }
        // Use a for loop to print numbers 1 to 10
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //  Use a while loop to print even numbers from 2 to 20.
        public static void PrintEvenNumbers()
        {
            int i = 2; // Start from the first even number
            while (i <= 20) // Continue until 20
            {
                if (i % 2 == 0) // Check if the number is even
                {
                    Console.WriteLine(i); // Print the current even number
                }

                /*OR
                Console.WriteLine(i); // Print the current even number
                i += 2; // Move to the next even number
                */
            }
        }

        // Create a do-while loop that accepts password input until 'admin' is entered.
        public static void AcceptPassword()
        {
            string password;
            do
            {
                Console.WriteLine("Enter the password:");
                password = Console.ReadLine();
            } while (password != "admin");
            Console.WriteLine("Successfully password input!");
        }

        // Sum numbers from 1 to 100 using a loop.
        public static void SumNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i; // Add each number to the sum (sum = sum + i)
            }
            Console.WriteLine($"The sum of numbers from 1 to 100 is: {sum}");
        }

        // Print names in a string array using foreach.
        public static void PrintNames(string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        // ============== Arrays ========================
        public static void Arrays()
        {
            Console.WriteLine("Hello,In Arrays Section!");
            // Add array-related methods here
            Console.WriteLine("Choose an array operation to test:");
            Console.WriteLine("1. First and Last Elements");
            Console.WriteLine("2. Max Value in Array");
            Console.WriteLine("3. Store and Print Names in Reverse");
            Console.WriteLine("4. Sum Array Elements");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrintFirstVsLastElements();
                    break;
                case "2":
                    int maxValue = MaxValue();
                    Console.WriteLine($"The maximum value in the array is: {maxValue}");
                    break;
                case "3":
                    StoreAndPrintNamesInReverse();
                    break;
                case "4":
                    int sum = SumArrayElements();
                    Console.WriteLine($"The sum of the array elements is: {sum}");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Create an array {5,10,15,20} and print first and last elements.
        public static void PrintFirstVsLastElements()
        {
            int[] numbers = { 5, 10, 15, 20 };
            Console.WriteLine($"First element: {numbers[0]}");
            Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");
        }

        //  Find the max value in an int array.
        public static int MaxValue()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            int max = numbers[0]; // Assume the first element is the maximum
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) // Compare with each element
                {
                    max = numbers[i]; // Update max if a larger number is found
                }
            }
            return max; // Return the maximum value found
        }

        //  Store 3 names from user input in an array, print in reverse.
        public static void StoreAndPrintNamesInReverse()
        {
            string[] names = new string[3]; // Create an array to hold 3 names
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Enter name {i + 1}:");
                names[i] = Console.ReadLine(); // Store user input in the array
            }
            Console.WriteLine("Names in reverse order:");
            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(names[i]); // Print names in reverse order
            }
        }

        //  Sum all elements in array {3,6,9,12}.
        public static int SumArrayElements()
        {
            int[] numbers = { 3, 6, 9, 12 };
            int sum = 0; // Initialize sum to 0
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i]; // Add each element to the sum
            }
            return sum; // Return the total sum
        }


    }

}
