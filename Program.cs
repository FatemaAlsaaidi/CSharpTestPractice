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
            Console.WriteLine("4. Exceptions");
            Console.WriteLine("5. Data Types"); 

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
                case "4":
                    Exceptions();
                    break;
                case "5":
                    DataTypes();
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
            Console.WriteLine("5. Count Odd Numbers in Array");
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
                case "5":
                    Console.WriteLine("Enter numbers separated by spaces:");
                    string input = Console.ReadLine();
                    int[] userArray = Array.ConvertAll(input.Split(' '), int.Parse);
                    int oddCount = CountOddNumbers(userArray);
                    Console.WriteLine($"The count of odd numbers in the array is: {oddCount}");
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

        // Count how many odd numbers are in a user-defined array.

        public static int CountOddNumbers(int[] array)
        {
            int count = 0; // Initialize count to 0
            foreach (int number in array) // Iterate through each number in the array
            {
                if (number % 2 != 0) // Check if the number is odd
                {
                    count++; // Increment count for each odd number found
                }
            }
            return count; // Return the total count of odd numbers
        }


        // ============== Exceptions ========================
        public static void Exceptions()
        {
            Console.WriteLine("Hello,In Exceptions Section!");
            // Add exception-related methods here
            Console.WriteLine("Choose an exception operation to test:");
            Console.WriteLine("1. Catch format exception");
            Console.WriteLine("2. Catch divide by zero exception");
            Console.WriteLine("3. Check if file exists before reading");
            Console.WriteLine("4. Finally block example");
            Console.WriteLine("5. Validate number input with try-catch");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    FormatExceptionExample();
                    break;
                case "2":
                    DivideByZeroExceptionExample();
                    break;
                case "3":
                    FileExistsExample();
                    break;
                case "4":
                    FinallyBlockExample();
                    break;
                case "5":
                    ValidateNumberInput();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        //  Catch format exception when parsing an int.
        public static void FormatExceptionExample()
        {
            try
            {
                Console.WriteLine("Enter a number to parse:");
                int number = int.Parse(Console.ReadLine()); // This may throw a FormatException
                Console.WriteLine($"Parsed number: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
        }

        //  Handle divide-by-zero exception with try-catch.
        public static void DivideByZeroExceptionExample()
        {
            try
            {
                Console.WriteLine("Enter a number to divide by zero:");
                int number = int.Parse(Console.ReadLine());
                int result = number / 0; // This will cause a DivideByZeroException
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
        }

        //  Use try-catch to check if a file exists before reading
        public static void FileExistsExample()
        {
            try
            {
                string filePath = "example.txt"; // Specify the file path
                string content = System.IO.File.ReadAllText(filePath); // Read the file content
                Console.WriteLine("File content:");
                Console.WriteLine(content);
                
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Demonstrate finally block that always prints 'Finished'.
        public static void FinallyBlockExample()
        {
            try
            {
                Console.WriteLine("Executing try block...");
                // Simulate some operation that may throw an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finished"); // This will always execute
            }
        }

        //  Wrap user input in try-catch to validate number entry.
        public static void ValidateNumberInput()
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = int.Parse(Console.ReadLine()); // This may throw a FormatException
                Console.WriteLine($"You entered: {number}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
        }

        
        // ================= Data Types ========================
        public static void DataTypes()
        {
            Console.WriteLine("Hello,In Data Types Section!");
            // Add data type-related methods here
            Console.WriteLine("Choose a data type operation to test:");
            Console.WriteLine("1. Declare and Print Data Types");
            Console.WriteLine("2. Ask for Age");
            Console.WriteLine("3. Calculate Circle Area");
            Console.WriteLine("4. Add Two Float Numbers");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrintDataTypes();
                    break;
                case "2":
                    AskForAge();
                    break;
                case "3":
                    Console.WriteLine("Enter the radius of the circle:");
                    double radius = double.Parse(Console.ReadLine());
                    try
                    {
                        double area = CalculateCircleArea(radius);
                        Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "4":
                    AddTwoFloatNumbers();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        //  Declare and print variables: name (string), age (int), height (double).
        public static void PrintDataTypes()
        {
            string name = "John Doe"; // Declare a string variable
            int age = 30; // Declare an integer variable
            double height = 5.9; // Declare a double variable
            // Print the values of the variables
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height} feet");
        }
        //  Ask for age and print 'You are X years old'.
        public static void AskForAge()
        {
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine()); // Read user input and convert to integer
            Console.WriteLine($"You are {age} years old."); // Print the age
        }
        // Calculate area of a circle using const double Pi.
        public const double Pi = 3.14159; // Define a constant for Pi
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius must be non-negative.");
            }
            return Pi * radius * radius; // Area = π * r^2
        }

        // Add two float numbers and print result formatted to 2 decimals.
        public static void AddTwoFloatNumbers()
        {
            Console.WriteLine("Enter two float numbers to add:");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float sum = num1 + num2; // Calculate the sum
            Console.WriteLine($"The sum is: {sum:F2}"); // Print the result formatted to 2 decimal places
        }




    }

}
