﻿namespace CSharpTestPractice
{
    using System;
    using System.Windows.Markup;

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
            Console.WriteLine("6. Operators");
            Console.WriteLine("7. Access Modifiers");
            Console.WriteLine("8. Input/Output");
            Console.WriteLine("9. File Handling");

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
                case "6":
                    Operators();
                    break;
                case "7":
                    AccessModifiers();
                    break;
                case "8":
                    InputOutput();
                    break;
                case "9":
                    FileHandling();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    break;
            }

            /*DerivedClass obj = new DerivedClass();
            obj.CallProtectedMethod(); // Output: Protected method in BaseClass called.

            //================================

            ScopeExample obj = new ScopeExample();
            obj.ShowScope();
            obj.AnotherMethod();*/

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
            Console.WriteLine("5. Use Var with String");
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
                case "5":
                    UseVarWithString();
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

        // Use var with string value and print its type
        public static void UseVarWithString()
        {
            var message = "Hello, World!"; // Declare a variable using var
            Console.WriteLine($"Message: {message}"); // Print the message
            Console.WriteLine($"Type of message: {message.GetType()}"); // Print the type of the variable
        }

        // ================ Operators ========================
        public static void Operators()
        {
            Console.WriteLine("Hello,In Operators Section!");
            // Add operator-related methods here
            Console.WriteLine("Choose an operator operation to test:");
            Console.WriteLine("1. Arithmetic Operators");
            Console.WriteLine("2. Comparison Operators");
            Console.WriteLine("3. Ternary Operator");
            Console.WriteLine("4. Logical Operators");
            Console.WriteLine("5. Incremented Value");
            Console.WriteLine("6. Assignment Operators");
            Console.WriteLine("7. Compare Strings using == operator");
            Console.WriteLine("8. Bitwise Operators");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ArithmeticOperators();
                    break;
                case "2":
                    ComparisonOperators();
                    break;
                case "3":
                    TernaryOperator();
                    break;
                case "4":
                    LogicalOperators();
                    break;
                case "5":
                    IncrementedValue();
                    break;
                case "6":
                    AssignmentOperators();
                    break;
                case "7":
                    CompareStrings();
                    break;
                case "8":
                    BitwiseOperators();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        //  Input two numbers, show sum, difference, product, and quotient.
        public static void ArithmeticOperators()
        {
            Console.WriteLine("Enter two numbers:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Difference: {num1 - num2}");
            Console.WriteLine($"Product: {num1 * num2}");
            if (num2 != 0)
            {
                Console.WriteLine($"Quotient: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

        //  Check if number is >10 and even using logical AND.
        public static void ComparisonOperators()
        {
            Console.WriteLine("Enter a number to check if it's greater than 10 and even:");
            int number = int.Parse(Console.ReadLine());
            if (number > 10 && number % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even.");
            }
            else
            {
                Console.WriteLine("The number is either not greater than 10 or not even.");
            }
        }

        // Use ternary operator to check if age >= 18 (Adult/Minor).
        public static void TernaryOperator()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            string status = (age >= 18) ? "Adult" : "Minor"; // Ternary operator to determine status
            Console.WriteLine($"You are an {status}.");
        }

        // logical operators example
        public static void LogicalOperators()
        {
            Console.WriteLine("Enter two boolean values (true/false):");
            bool a = bool.Parse(Console.ReadLine());
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine($"AND: {a && b}"); // Logical AND
            Console.WriteLine($"OR: {a || b}"); // Logical OR
            Console.WriteLine($"NOT a: {!a}"); // Logical NOT
            Console.WriteLine(
                $"XOR: {a ^ b}"); // Logical XOR
            Console.WriteLine(
                $"NAND: {!(a && b)}"); // Logical NAND
            Console.WriteLine(
                $"NOR: {!(a || b)}"); // Logical NOR
            Console.WriteLine(
                $"XNOR: {!(a ^ b)}"); // Logical XNOR
            Console.WriteLine(
                $"Conditional AND: {(a ? b : false)}"); // Conditional AND
            Console.WriteLine(
                $"Conditional OR: {(a ? true : b)}"); // Conditional OR
            Console.WriteLine(
                $"Short-circuit AND: {(a && b)}"); // Short-circuit AND
            Console.WriteLine(
                $"Short-circuit OR: {(a || b)}"); // Short-circuit OR
            Console.WriteLine(
                $"Null-coalescing: {(a ? b : true)}"); // Null-coalescing operator
            Console.WriteLine(
                $"Conditional null-coalescing: {(a ? b : null)}"); // Conditional null-coalescing operator
            Console.WriteLine(
                $"Conditional null-coalescing with assignment: {(a ? b : (b ?? true))}"); // Conditional null-coalescing with assignment

        }

        //  Increment x = 5 using ++ and print result.
        public static void IncrementedValue()
        {
            int x = 5; // Initialize x to 5
            Console.WriteLine($"Original value of x: {x}");
            x++; // Increment x by 1
            Console.WriteLine($"Value of x after incrementing: {x}"); // Print the incremented value
        }

        //  Use assignment operators to modify a variable.
        public static void AssignmentOperators()
        {
            int x = 10; // Initialize x to 10
            Console.WriteLine($"Original value of x: {x}");
            x += 5; // Add 5 to x (equivalent to x = x + 5)
            Console.WriteLine($"Value of x after += 5: {x}");
            x -= 3; // Subtract 3 from x (equivalent to x = x - 3)
            Console.WriteLine($"Value of x after -= 3: {x}");
            x *= 2; // Multiply x by 2 (equivalent to x = x * 2)
            Console.WriteLine($"Value of x after *= 2: {x}");
            if (x != 0)
            {
                x /= 4; // Divide x by 4 (equivalent to x = x / 4)
                Console.WriteLine($"Value of x after /= 4: {x}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }

        // Compare two strings and check if they are equal using ==.
        public static void CompareStrings()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }
        }



        // Use bitwise operators to demonstrate AND, OR, XOR, NOT, left shift, and right shift.
        public static void BitwiseOperators()
        {
            int a = 5; // Binary: 0101
            int b = 3; // Binary: 0011
            Console.WriteLine($"a = {a}, b = {b}");
            Console.WriteLine($"Bitwise AND: {a & b}"); // Bitwise AND
            Console.WriteLine($"Bitwise OR: {a | b}"); // Bitwise OR
            Console.WriteLine($"Bitwise XOR: {a ^ b}"); // Bitwise XOR
            Console.WriteLine($"Bitwise NOT a: {~a}"); // Bitwise NOT
            Console.WriteLine($"Left Shift a by 1: {a << 1}"); // Left shift
            Console.WriteLine($"Right Shift a by 1: {a >> 1}"); // Right shift
        }

        // ===================== Access Modifiers ========================
        public static void AccessModifiers()
        {
            Console.WriteLine("Access Modifiers Section");
    
        }

        // Create a class Person with private field name, public methods SetName and GetName.
        public class Person
        {
            private string name; // Private field
                                 // Public method to set the name
            public void SetName(string value)
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
            // Public method to get the name
            public string GetName()
            {
                return name;
            }
        }

        // Use a public method that calls a private method inside the class.
        public class Calculator
        {
            // Public method to add two numbers
            public int Add(int a, int b)
            {
                return AddNumbers(a, b); // Call the private method
            }
            // Private method to perform addition
            private int AddNumbers(int a, int b)
            {
                return a + b; // Return the sum of a and b
            }
        }
        // Use a public method that calls a private method inside the class.
        public class BankAccount
        {
            private decimal balance; // Private field to store the balance
            // Public method to deposit money
            public void Deposit(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
                balance += amount; // Call the private method to update the balance
            }
            // Public method to get the current balance
            public decimal GetBalance()
            {
                return GetCurrentBalance(); // Call the private method to retrieve the balance
            }
            // Private method to retrieve the current balance
            private decimal GetCurrentBalance()
            {
                return balance; // Return the current balance
            }
        }

        // Track method calls using static field.
        public class MethodTracker
        {
            private static int methodCallCount = 0; // Static field to track method calls
            // Public method to increment the call count
            public void IncrementCallCount()
            {
                methodCallCount++; // Increment the static field
            }
            // Public method to get the current call count
            public int GetCallCount()
            {
                return methodCallCount; // Return the current call count
            }
        }

        //  Use protected method in base class and call from derived class.
       
        //using System;

        public class BaseClass
        {
                // Protected method that can be accessed by derived classes
                protected void ProtectedMethod()
                {
                    Console.WriteLine("Protected method in BaseClass called.");
                }
        }

        // Derived class that inherits from BaseClass
        public class DerivedClass : BaseClass
        {
            public void CallProtectedMethod()
            {
                // Call the protected method from the base class
                ProtectedMethod();
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        DerivedClass obj = new DerivedClass();
        //        obj.CallProtectedMethod(); // Output: Protected method in BaseClass called.
        //    }
        //}

        // Demonstrate scope of a local variable inside a method.

       //using System;

        public class ScopeExample
        {
            public void ShowScope()
            {
                int localVariable = 10; // Local variable declared inside the method

                Console.WriteLine("Inside ShowScope method:");
                Console.WriteLine("localVariable = " + localVariable);
            }

            public void AnotherMethod()
            {
                // Uncommenting the below line would cause a compile-time error:
                // Console.WriteLine(localVariable); // Error: localVariable does not exist in this context
            }
        }

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        ScopeExample obj = new ScopeExample();
        //        obj.ShowScope();
        //        obj.AnotherMethod();
        //    }
        //}


        // ======================  Input/Output ========================

        public static void InputOutput()
        {
            Console.WriteLine("Hello,In Input/Output Section!");
            // Add input/output-related methods here
            Console.WriteLine("Choose an input/output operation to test:");
            Console.WriteLine("1. Read and Print User Input");
            Console.WriteLine("2. Read Two Numbers AndDisplay Sum");
            Console.WriteLine("3. Ask for Favorite Color");
            Console.WriteLine("4. Print Messages on Same Line");
            Console.WriteLine("5. Read Key and Display");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReadAndPrintUserInput();
                    break;
                case "2":
                    ReadTwoNumbersAndDisplaySum();
                    break;
                case "3":
                    AskForFavoriteColor();
                    break;
                case "4":
                    PrintMessagesOnSameLine();
                    break;
                case "5":
                    ReadKeyAndDisplay();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Read user name using Console.ReadLine() and greet them.
        public static void ReadAndPrintUserInput()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); // Read user input
            Console.WriteLine($"Hello, {name}!"); // Greet the user
        }

        // Read two numbers from user and display their sum.
        public static void ReadTwoNumbersAndDisplaySum()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine()); // Read first number
            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine()); // Read second number
            int sum = num1 + num2; // Calculate the sum
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}"); // Display the sum
        }

        // Ask for favorite color and print using string interpolation.
        public static void AskForFavoriteColor()
        {
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine(); // Read user input
            Console.WriteLine($"Your favorite color is {color}."); // Print using string interpolation
        }

        //  Print two messages on the same line using Console.Write().
        public static void PrintMessagesOnSameLine()
        {
            Console.Write("Hello, "); // Print first message without a newline
            Console.Write("World!"); // Print second message on the same line
            Console.WriteLine(); // Move to the next line after printing both messages
        }
        // Read a key using Console.ReadKey() and display it.
        public static void ReadKeyAndDisplay()
        {
            Console.WriteLine("Press any key to continue...");
            ConsoleKeyInfo keyInfo = Console.ReadKey(); // Read a key from the console
            Console.WriteLine(); // Move to the next line
            Console.WriteLine($"You pressed: {keyInfo.KeyChar}"); // Display the pressed key
        }

        // ======================  File Handling =======================
        public static void FileHandling()
        {
            Console.WriteLine("Hello,In File Handling Section!");
            // Add file handling-related methods here
            Console.WriteLine("Choose a file handling operation to test:");
            Console.WriteLine("1. Write to a File");
            Console.WriteLine("2. Check if File Exists");
            Console.WriteLine("3. Append to Log File");
            Console.WriteLine("4. Read Notes File");
            Console.WriteLine("5. Read Names from File");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteToFile();
                    break;
                case "2":
                    CheckFileExists();
                    break;
                case "3":
                    AppendToLogFile();
                    break;
                case "4":
                    ReadNotesFile();
                    break;
                case "5":
                    ReadNamesFromFile();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Create a text file and write a welcome message.
        public static void WriteToFile()
        {
            string filePath = "welcome.txt"; // Specify the file path
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(filePath))
                {
                    writer.WriteLine("Welcome to C# File Handling!"); // Write a welcome message to the file
                }
                Console.WriteLine($"Message written to {filePath} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }

        // Check if a file exists and print appropriate message.
        public static void CheckFileExists()
        {
            string filePath = "welcome.txt"; // Specify the file path
            if (System.IO.File.Exists(filePath))
            {
                Console.WriteLine($"The file {filePath} exists.");
            }
            else
            {
                Console.WriteLine($"The file {filePath} does not exist.");
            }
        }

        //  Append a line to log.txt, create if missing.
        public static void AppendToLogFile()
        {
            string logFilePath = "log.txt"; // Specify the log file path
            try
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logFilePath, true)) // Open in append mode
                {
                    writer.WriteLine("Log entry at " + DateTime.Now); // Write a log entry with the current timestamp
                }
                Console.WriteLine($"Log entry added to {logFilePath} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
        //  Read and print contents of notes.txt.
        public static void ReadNotesFile()
        {
            string notesFilePath = "notes.txt"; // Specify the notes file path
            try
            {
                if (System.IO.File.Exists(notesFilePath))
                {
                    string content = System.IO.File.ReadAllText(notesFilePath); // Read the entire file content
                    Console.WriteLine("Contents of notes.txt:");
                    Console.WriteLine(content); // Print the content to the console
                }
                else
                {
                    Console.WriteLine($"The file {notesFilePath} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading notes file: {ex.Message}");
            }
        }

        // Read names from file and print with line numbers.
        public static void ReadNamesFromFile()
        {
            string filePath = "names.txt"; // Specify the file path
            try
            {
                if (System.IO.File.Exists(filePath))
                {
                    string[] names = System.IO.File.ReadAllLines(filePath); // Read all lines from the file
                    Console.WriteLine("Names from the file:");
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]}"); // Print each name with its line number
                    }
                }
                else
                {
                    Console.WriteLine($"The file {filePath} does not exist.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading names file: {ex.Message}");
            }
        }

        //====================== Syntax ==================
        public static void Syntax()
        {
            Console.WriteLine("Hello,In Syntax Section!");
            // Add syntax-related methods here
            Console.WriteLine("Choose a syntax operation to test:");
            Console.WriteLine("1. Print Hello C#");
            Console.WriteLine("2. Declare and Print Variables");
            Console.WriteLine("3. Use For Loop to Print Numbers 1 to 5");
            Console.WriteLine("4. Check if Number is Positive, Negative or Zero");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PrintHelloCSharp();
                    break;
                case "2":
                    DeclareAndPrintVariables();
                    break;
                case "3":
                    PrintNumbersOneToFive();
                    break;
                case "4":
                    PrintNumbersTwoToFive();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        // Write Main() that prints 'Hello, C#'.
        public static void PrintHelloCSharp()
        {
            Console.WriteLine("Hello, C#"); // Print the message to the console
        }

        // Declare and print string, int, bool variables.
        public static void DeclareAndPrintVariables()
        {
            string message = "Hello, World!"; // Declare a string variable
            int number = 42; // Declare an integer variable
            bool isTrue = true; // Declare a boolean variable
            // Print the values of the variables
            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Number: {number}");
            Console.WriteLine($"Is True: {isTrue}");
        }

        //  Use a for loop to print numbers 1 to 5.
        public static void PrintNumbersOneToFive()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i); // Print each number from 1 to 5
            }
        }

        //  Check if number is positive, negative or zero using if-else.
        public static void PrintNumbersTwoToFive()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine()); // Read user input
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }

        //  Create class Car with Drive() method, call it from Main()
        public class Car
        {
            // Method to simulate driving the car
            public void Drive()
            {
                Console.WriteLine("The car is now driving.");
            }
        }


    }

}
