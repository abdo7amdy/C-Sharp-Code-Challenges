namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1.Write a program that allows the user to enter a number then print it.
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {num}");
            #endregion

            #region Question 2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            Console.Write("Enter a string with non-numeric characters: ");
            string input2 = Console.ReadLine();
            try
            {
                int result2 = int.Parse(input2);
                Console.WriteLine($"Converted number: {result2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("The string contains non-numeric characters and cannot be converted.");
            }
            // without the try catch there is ( run time error )
            #endregion

            #region Question 3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            Console.WriteLine("plz enter 1th num :");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("plz enter 2th num :");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Sum: {num1 + num2}");
            Console.WriteLine($"Sub: {num2 - num1}");
            Console.WriteLine($"Mul: {num1 * num2}");
            Console.WriteLine($"Div: {num2 / num1}");
            #endregion

            #region Question 4.Write C# program that Extract a substring from a given string.
            string str4 = "Hello World";
            Console.WriteLine($"Substring: {str4.Substring(0, 5)}");
            #endregion

            #region Question 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int val1 = 5;
            // CLR allocate 4 byte in stack called val1 with value 5
            int val2 = val1;
            // CLR allocate 4 byte in stack called val2 with value equal to val1 as a copy 
            val1 = 10;
            // CLR allocate new 4 byte in stack called val1 with new value 10 
            Console.WriteLine($"val1: {val1}, val2: {val2}"); // val1 = 10 , val2 still have the copy from the frist value of val1 which was = 5
            #endregion

            #region Question 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            string str1 = "Abdo_7amdy";
            // CLR allocate 4 byte ref in stack called str1 then allocate string "Abdo_7amdy" in heap with their byte count 
            // str1 in stack is ref to  "Abdo_7amdy" in heap
            String Str2 = str1;
            // CLR allocate 4 byte ref in stack called str2 and assign the reference to where str1 reference which is "Abdo_7amdy"
            // str2 in stack is also ref to  "Abdo_7amdy" in heap
            str1 = "Hello , Abdo";
            // CLR allocate new string "Hello , Abdo" in heap then assign str1 ref to it 
            // Now , str1 references to "Hello , Abdo" in heap 
            //       str2 still references to  "Abdo_7amdy" in heap 
            Console.WriteLine($"string 1: {str1} \n String 2: {Str2}");
            #endregion

            #region Question 7.Write C# program that take two string variables and print them as one variable 
            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();
            Console.WriteLine($"Combined: {string1} {string2}");
            #endregion

            #region Question 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time ) /100.
            float principal, rate, time;
            Console.WriteLine("Plz enter principal amount :");
            principal = float.Parse(Console.ReadLine());

            Console.WriteLine("Plz enter rate :");
            rate = float.Parse(Console.ReadLine());

            Console.WriteLine("Plz enter time :");
            time = float.Parse(Console.ReadLine());

            float interest = (principal * rate * time) / 100;
            Console.WriteLine($"Simple Interest: {interest}");
            #endregion

            #region Question 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight)/(Height*Height)
            // Input weight and height
            Console.Write("Enter weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Ensure height is not zero or negative
            if (height <= 0)
            {
                Console.WriteLine("Height must be greater than zero.");
                return;
            }

            // Calculate BMI
            double BMI = (weight) / (height * height);

            // Display BMI
            Console.WriteLine($"Your Body Mass Index (BMI) is: {BMI:F2}");
            #endregion

            #region Question 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            Console.WriteLine("Plz enter the Temperature :");
            int temp = int.Parse(Console.ReadLine());
            string result10 = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(result10);
            #endregion

            #region Question 11.Write a program that takes the date from the user and displays it in various formats using string interpolation.
            // Input date components
            Console.Write("Enter the day: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the month: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Display date in various formats
            Console.WriteLine($"Today’s date: {day} , {month} , {year}");
            Console.WriteLine($"Today’s date: {day} / {month} / {year}");
            Console.WriteLine($"Today’s date: {day} – {month} – {year}");
            #endregion

            #region Question 12.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.Write("Enter a number: ");
            int num12 = int.Parse(Console.ReadLine());
            Console.WriteLine(num12 % 3 == 0 && num12 % 4 == 0 ? "Yes" : "No");
            #endregion

            #region Question 13.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.Write("Enter a number: ");
            int num13 = int.Parse(Console.ReadLine());
            Console.WriteLine(num13 < 0 ? "Negative" : "Positive");
            #endregion

            #region Question 14.Write a program that takes 3 integers from the user then prints the max element and the min element.
            int n1, n2, n3;
            Console.WriteLine("plz enter frist num :");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("plz enter second num :");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("plz enter third num :");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max: {Math.Max(n1, Math.Max(n2, n3))}, Min: {Math.Min(n1, Math.Min(n2, n3))}");
            #endregion

            #region Question 14.Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.WriteLine("Please insert a number to check even or odd:");
            int CheckNum = int.Parse(Console.ReadLine());
            Console.WriteLine((CheckNum % 2 == 0) ? "Even" : (CheckNum % 2 == 1) ? "Odd" : "neither even or odd");

            #endregion

            #region Question 15.Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Enter only one character: ");
            //char ch = char.Parse(Console.ReadLine()); // unsafe casting
            string ch = Console.ReadLine();
            Console.WriteLine("aeiouAEIOU".Contains(ch) ? "Vowel" : "Consonant");
            #endregion

            #region Question 16.Write a program to input the month number and print the number of days in that month.
            Console.Write("Enter month number: ");
            int Checkmonth = int.Parse(Console.ReadLine());
            Console.WriteLine($"Number of Days in month number {Checkmonth} is : {DateTime.DaysInMonth(DateTime.Now.Year, month)}");
            #endregion

            #region Question 17.Write a program to create a Simple Calculator.

            // Display menu and get user inputs
            Console.WriteLine("Simple Calculator");
            Console.Write("Enter the first number: ");
            double Frist_num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];

            Console.Write("Enter the second number: ");
            double Second_num = Convert.ToDouble(Console.ReadLine());

            // Perform calculation based on operator
            double result;
            switch (op)
            {
                case '+':
                    result = Frist_num + Second_num;
                    break;
                case '-':
                    result = Frist_num - Second_num;
                    break;
                case '*':
                    result = Frist_num * Second_num;
                    break;
                case '/':
                    if (Second_num == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                        return;
                    }
                    result = Frist_num / Second_num;
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    return;
            }

            // Display result
            Console.WriteLine($"Result: {Frist_num} {op} {Second_num} = {result}");
            #endregion

            #region Question 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Enter a number: ");
            int limit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= limit; i++)
                Console.Write(i + " ");

            #endregion

            #region Question 19.Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            Console.Write("Enter a number: ");
            int num19 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
                Console.WriteLine($"{num19} x {i} = {num19 * i}");
            #endregion

            #region Question 20.Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.Write("Enter a number: ");
            int num20 = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num20; i += 2)
                Console.Write(i + " ");

            #endregion


            #region Question 21.Write a program that takes two integers then prints the power.
            Console.Write("Enter base and power: ");
            int baseNum = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(baseNum, power));
            #endregion

            #region Question 22.Write a program to allow the user to enter int and print the REVERSED of it.
            Console.Write("Enter a number: ");
            int num22 = int.Parse(Console.ReadLine());
            char[] reversed = num22.ToString().ToCharArray();
            Array.Reverse(reversed);
            Console.WriteLine(new string(reversed));
            #endregion

            #region Question 23.Write a program in C# Sharp to find prime numbers within a range of numbers.
            Console.Write("Enter start and end of range: ");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0) { isPrime = false; break; }
                }
                if (isPrime && i > 1) Console.Write(i + " ");
            }
            Console.WriteLine();
            #endregion

            #region Question 24.Write a program in C# Sharp to convert a decimal number into binary without using an array.
            Console.Write("Enter a number: ");
            int num24 = int.Parse(Console.ReadLine());
            string binary = "";
            while (num24 > 0)
            {
                binary = (num24 % 2) + binary;
                num24 /= 2;
            }
            Console.WriteLine(binary);
            #endregion

            #region Question 25.Write a program in C# Sharp to find the sum of all elements of the array.
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter {i + 1}th element: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum: {arr.Sum()}");
            #endregion



        }
    }
}
