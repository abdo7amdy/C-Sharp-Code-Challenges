using System;

namespace Assignment_04
{
    class Person
    {
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            //    // Define two sorted arrays
            //    int[] array1 = { 1, 3, 5, 7, 9 };
            //    int[] array2 = { 2, 4, 6, 8, 10 };

            //    // Define an array to hold the merged result
            //    int[] mergedArray = new int[array1.Length + array2.Length];

            //    // Call the MergeArrays function
            //    MergeArrays(array1, array2, mergedArray);

            //    // Print the merged array
            //    Console.WriteLine("Merged Array:");
            //    foreach (var item in mergedArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

            //static void MergeArrays(int[] array1, int[] array2, int[] mergedArray)
            //{
            //    int i = 0, j = 0, k = 0;

            //    // Merge the two arrays while comparing their elements
            //    while (i < array1.Length && j < array2.Length)
            //    {
            //        if (array1[i] < array2[j])
            //        {
            //            mergedArray[k] = array1[i];
            //            i++;
            //        }
            //        else
            //        {
            //            mergedArray[k] = array2[j];
            //            j++;
            //        }
            //        k++;
            //    }

            //    // If any elements remain in array1, add them
            //    while (i < array1.Length)
            //    {
            //        mergedArray[k] = array1[i];
            //        i++;
            //        k++;
            //    }

            //    // If any elements remain in array2, add them
            //    while (j < array2.Length)
            //    {
            //        mergedArray[k] = array2[j];
            //        j++;
            //        k++;
            //    }
            #endregion

            #region Q2
            //// Sample array
            //int[] arr = { 1, 2, 2, 3, 3, 3, 4, 5 };

            //// To count frequencies
            //int n = arr.Length;

            //// Loop through each element in the array
            //for (int i = 0; i < n; i++)
            //{
            //    // Skip the element if it's already counted
            //    bool isCounted = false;

            //    // Check if the element is already counted
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            isCounted = true;
            //            break;
            //        }
            //    }

            //    // If the element is not counted, count its frequency
            //    if (!isCounted)
            //    {
            //        int count = 1; // The element itself counts as 1
            //        for (int k = i + 1; k < n; k++)
            //        {
            //            if (arr[i] == arr[k])
            //            {
            //                count++;
            //            }
            //        }

            //        // Print the element and its frequency
            //        Console.WriteLine("Element " + arr[i] + " occurs " + count + " times.");
            //    }
            //}
            #endregion

            #region Q3
            //// Example array
            //int[] arr = { 12, 34, 5, 67, 89, 2, 43, 78 };

            //// Initializing maximum and minimum with the first element of the array
            //int max = arr[0];
            //int min = arr[0];

            //// Traverse the array to find the maximum and minimum elements
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i]; // Update max if a larger element is found
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i]; // Update min if a smaller element is found
            //    }
            //}

            //// Output the results
            //Console.WriteLine("Maximum element: " + max);
            //Console.WriteLine("Minimum element: " + min);
            #endregion

            #region Q4
            //// Input array
            //int[] myarr = { 12, 35, 1, 10, 34, 1 };

            //// Check if the array has enough elements
            //if (myarr.Length < 2)
            //{
            //    Console.WriteLine("Array should have at least two elements.");
            //    return;
            //}

            //// Variables to store the largest and second largest elements
            //int largest, secondLargest;

            //// Initialize largest and second largest with the first two elements
            //if (myarr[0] > myarr[1])
            //{
            //    largest = myarr[0];
            //    secondLargest = myarr[1];
            //}
            //else
            //{
            //    largest = myarr[1];
            //    secondLargest = myarr[0];
            //}

            //// Iterate through the array to find the second largest element
            //for (int i = 2; i < myarr.Length; i++)
            //{
            //    if (myarr[i] > largest)
            //    {
            //        secondLargest = largest;
            //        largest = myarr[i];
            //    }
            //    else if (myarr[i] > secondLargest && myarr[i] != largest)
            //    {
            //        secondLargest = myarr[i];
            //    }
            //}

            //// Output the result
            //Console.WriteLine("The second largest element is: " + secondLargest);

            #endregion

            #region Q5
            //// Ask the user to input the size of the array
            //Console.Write("Enter the size of the array: ");
            //int N = int.Parse(Console.ReadLine());

            //// Declare and input the array values
            //int[] arr = new int[N];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < N; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Variable to store the maximum distance
            //int maxDistance = -1;

            //// Iterate through the array to find the longest distance
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; // The distance between the elements
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //// Output the result
            //if (maxDistance != -1)
            //{
            //    Console.WriteLine("The longest distance between two equal elements is: " + maxDistance);
            //}
            //else
            //{
            //    Console.WriteLine("No two equal elements found.");
            //}
            #endregion

            #region Q6

            //// Input: space-separated words
            //Console.WriteLine("Enter a list of space-separated words:");
            //string input = Console.ReadLine();

            //// Create an array to hold the words
            //string[] words = new string[100]; // Assumes no more than 100 words
            //int wordCount = 0;

            //// Temporary variable to store each word
            //string word = "";

            //// Iterate through the input string to manually split the words
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] != ' ')  // If the character is not a space, add it to the current word
            //    {
            //        word += input[i];
            //    }
            //    else
            //    {
            //        if (word != "")  // If we have a non-empty word, store it in the array
            //        {
            //            words[wordCount++] = word;
            //            word = "";  // Reset for the next word
            //        }
            //    }
            //}

            //// If the last word is not followed by a space, add it as well
            //if (word != "")
            //{
            //    words[wordCount++] = word;
            //}

            //// Output the words in reverse order
            //Console.Write("Reversed Order: ");
            //for (int i = wordCount - 1; i >= 0; i--)
            //{
            //    Console.Write(words[i] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q7
            //// Input the dimensions of the array
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of columns:");
            //int cols = int.Parse(Console.ReadLine());

            //// Declare two multidimensional arrays with the same size
            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //// Accept values from the user and store them in the first array
            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter value for element [{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Copy all elements from the first array to the second array
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //// Print the second array
            //Console.WriteLine("\nSecond Array after copying elements:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(secondArray[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q8
            //// Input: the size of the array
            //Console.Write("Enter the size of the array: ");
            //int size = int.Parse(Console.ReadLine());

            //// Declare the array
            //int[] arr = new int[size];

            //// Input: the elements of the array
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// Output: the array in reverse order
            //Console.WriteLine("Array in reverse order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q9
            /*1. Passing By Value:
            When you pass a parameter by value the method gets a copy of the original data
            Changes made to the parameter inside the method do not affect the original variable
            This is the default behavior for value types ( int, float, struct)
            The method works with a copy of the value and any modifications to this copy don't affect the original value
            Applicable Types Value types ( int, double, char, struct)

            2. Passing By Reference:
            When you pass a parameter by reference the method gets a reference to the original data
            Changes made to the parameter inside the method do affect the original variable
            This is done using the ref or out keyword in C#
            The method works directly with the original data so any changes made inside the method
            are reflected outside the method 
            Applicable Types Reference types ( class, array, string) but it can also be used with value types using ref or out.*/
            //{
            //    int num = 5;
            //    Console.WriteLine("Before method call (Pass by Value): " + num);
            //    ModifyValue(num);  // Pass by value
            //    Console.WriteLine("After method call (Pass by Value): " + num);  // Original variable remains unchanged
            //}

            //static void ModifyValue(int value)
            //{
            //    value = 10;  // Change only the copy
            //    Console.WriteLine("Inside method (Pass by Value): " + value);
            //}
            //{
            //    int num = 5;
            //    Console.WriteLine("Before method call (Pass by Reference): " + num);
            //    ModifyReference(ref num);  // Pass by reference using the ref keyword
            //    Console.WriteLine("After method call (Pass by Reference): " + num);  // Original variable is modified
            //}

            //static void ModifyReference(ref int value)
            //{
            //    value = 10;  // Modify the original value
            //    Console.WriteLine("Inside method (Pass by Reference): " + value);
            //}
            #endregion

            #region Q10
            /*1. Passing Reference Type Parameters by Value:
            When you pass a reference type parameter by value the reference to the object is copied
            but the object itself remains the same
            This means: The method can access and modify the object's data 
            (because it holds a reference to the same object) However if you change the reference itself 
            ( reassign the object inside the method) it does not affect the original reference outside the method
            This is the default behavior when passing reference types (like class, array)

            2. Passing Reference Type Parameters by Reference:
            When you pass a reference type parameter by reference
            the method receives a reference to the reference itself (using the ref or out keyword)
            The method can modify both the object data and the reference itself 
            ( reassigning the reference to a different object)
            This allows both the reference and the object it refers to to be modified inside the method
            */
            // Create an object of Person
            //Person person = new Person { Name = "Alice" };

            //Console.WriteLine("Before method call: " + person.Name);

            //// Pass by value (default behavior for reference types)
            //ModifyPerson(person);

            //// Output after calling the method
            //Console.WriteLine("After method call: " + person.Name);


            //static void ModifyPerson(Person p)
            //{
            //    p.Name = "Bob";  // Modify the object data
            //    p = new Person { Name = "Charlie" };  // Reassign the reference, but it won't affect the original reference
            //    Console.WriteLine("Inside method: " + p.Name);
            //}
            ///////////////////////////////////
            // Create an object of Person
            //Person person = new Person { Name = "Alice" };

            //Console.WriteLine("Before method call: " + person.Name);

            //// Pass by reference using the 'ref' keyword
            //ModifyPerson(ref person);

            //// Output after calling the method
            //Console.WriteLine("After method call: " + person.Name);

            //static void ModifyPerson(ref Person p)
            //{
            //    p.Name = "Bob";  // Modify the object data
            //    p = new Person { Name = "Charlie" };  // Reassign the reference, which will affect the original reference
            //    Console.WriteLine("Inside method: " + p.Name);
            //}
            #endregion

            #region Q11
            //    // Accept four numbers from the user
            //    Console.WriteLine("Enter the first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the third number: ");
            //    int num3 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the fourth number: ");
            //    int num4 = int.Parse(Console.ReadLine());

            //    // Call the function with the four parameters
            //    (int summation, int subtraction) = Calculate(num1, num2, num3, num4);

            //    // Display the results
            //    Console.WriteLine($"Summation of the first two numbers: {summation}");
            //    Console.WriteLine($"Subtraction of the last two numbers: {subtraction}");
            //}

            //// Function that accepts 4 parameters and returns the summation and subtraction results
            //static (int, int) Calculate(int a, int b, int c, int d)
            //{
            //    // Calculate the summation of the first two numbers
            //    int summation = a + b;

            //    // Calculate the subtraction of the last two numbers
            //    int subtraction = c - d;

            //    // Return both results as a tuple
            //    return (summation, subtraction); 
            #endregion

            #region Q12
            //    // Accept the number from the user
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    // Call the function to calculate the sum of the digits
            //    int sum = SumOfDigits(number);

            //    // Display the result
            //    Console.WriteLine($"The sum of the digits of the number {number} is: {sum}");
            //}

            //// Function to calculate the sum of digits of a given number
            //static int SumOfDigits(int num)
            //{
            //    int sum = 0;

            //    // Loop through each digit of the number
            //    while (num > 0)
            //    {
            //        // Add the last digit to the sum
            //        sum += num % 10;

            //        // Remove the last digit from the number
            //        num /= 10;
            //    }

            //    return sum;


            #endregion

            #region Q13
            //    // Accept a number from the user
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    // Call the IsPrime function
            //    bool result = IsPrime(number);

            //    // Display the result
            //    if (result)
            //    {
            //        Console.WriteLine($"{number} is a prime number.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{number} is not a prime number.");
            //    }
            //}

            //// Function to check if a number is prime
            //static bool IsPrime(int num)
            //{
            //    // A prime number is greater than 1
            //    if (num <= 1)
            //    {
            //        return false;
            //    }

            //    // Check divisibility from 2 to the square root of num
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            return false; // If divisible by any number, it's not prime
            //        }
            //    }

            //    return true;
            #endregion

            #region Q14
            //    // Accept the size of the array from the user
            //    Console.Write("Enter the size of the array: ");
            //    int size = int.Parse(Console.ReadLine());

            //    int[] array = new int[size];

            //    // Accept array elements from the user
            //    Console.WriteLine("Enter the elements of the array:");
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.Write($"Element {i + 1}: ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }

            //    // Declare variables to hold the minimum and maximum values
            //    int min = 0, max = 0;

            //    // Call the MinMaxArray function
            //    MinMaxArray(array, ref min, ref max);

            //    // Display the minimum and maximum values
            //    Console.WriteLine($"Minimum value in the array: {min}");
            //    Console.WriteLine($"Maximum value in the array: {max}");
            //}

            //// Function to find the minimum and maximum values in an array using reference parameters
            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    // Initialize min and max with the first element of the array
            //    min = arr[0];
            //    max = arr[0];

            //    // Iterate through the array to find min and max
            //    foreach (int num in arr)
            //    {
            //        if (num < min)
            //        {
            //            min = num;
            //        }

            //        if (num > max)
            //        {
            //            max = num;
            //        }
            //    }
            #endregion

            #region Q15
            //    // Accept a number from the user
            //    Console.Write("Enter a number to calculate its factorial: ");
            //    int number = int.Parse(Console.ReadLine());

            //    // Call the iterative factorial function
            //    long result = CalculateFactorial(number);

            //    // Display the result
            //    Console.WriteLine($"The factorial of {number} is: {result}");
            //}

            //// Iterative function to calculate the factorial of a number
            //static long CalculateFactorial(int num)
            //{
            //    // Factorial of 0 or 1 is 1
            //    if (num == 0 || num == 1)
            //    {
            //        return 1;
            //    }

            //    long factorial = 1;

            //    // Multiply numbers from 1 to num
            //    for (int i = 2; i <= num; i++)
            //    {
            //        factorial *= i;
            //    }

            //    return factorial;
            #endregion

            #region Q16
        //    // Accept the original string from the user
        //    Console.Write("Enter the original string: ");
        //    string originalString = Console.ReadLine();

        //    // Accept the position to modify
        //    Console.Write("Enter the position of the character to change (0-based index): ");
        //    int position = int.Parse(Console.ReadLine());

        //    // Accept the new character
        //    Console.Write("Enter the new character: ");
        //    char newChar = Console.ReadLine()[0];

        //    // Call the ChangeChar function
        //    string modifiedString = ChangeChar(originalString, position, newChar);

        //    // Display the modified string
        //    Console.WriteLine($"Modified string: {modifiedString}");
        //}

        //// Function to modify a letter in a specific position of a string
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    // Check if the position is valid
        //    if (position < 0 || position >= input.Length)
        //    {
        //        throw new ArgumentOutOfRangeException("Position is out of range of the string length.");
        //    }

        //    // Convert the string to a char array for modification
        //    char[] charArray = input.ToCharArray();

        //    // Replace the character at the specified position
        //    charArray[position] = newChar;

        //    // Convert the char array back to a string
        //    return new string(charArray);
            #endregion

        }
}
}
