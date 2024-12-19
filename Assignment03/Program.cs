namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1 Write a program that allows the user to enter a number then print it
            /*
            Console.Write("Please enter a number to print it");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you have entered is {Number}");
            */
            #endregion

            #region Q.2Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            /*
            String UserInput = "Test125";
            Console.WriteLine(int.Parse(UserInput)); //The input string 'Test125' was not in a correct format.'
            */
            #endregion

            #region Q3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            /*
            float Number01 = 13.3f;
            float Number02 = 25.24f;
            float Sum = Number01 + Number02;
            float Subtract = Number01 - Number02;
            Console.WriteLine($"Sum two floating numbers result as follows {Number01} + {Number02} = {Sum}");
            Console.WriteLine($"Sum two floating numbers result as follows {Number01} + {Number02} = {Subtract}");
            */
            #endregion

            #region Q4. Write C# program that Extract a substring from a given string.
            /* Console.Write("please neter string");
             String str = Console.ReadLine();
             Console.WriteLine("Sub String1: " + str.Substring(5));
             Console.WriteLine("Sub String2: " + str.Substring(8));
            */
            #endregion

            #region Q.5Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /*  int FirstVariable = 20;
              int SecondVariable = FirstVariable;

              Console.WriteLine($"Initial value of firstValue: {FirstVariable}");
              Console.WriteLine($"Initial value of secondValue: {SecondVariable}");

              FirstVariable = 30;

              Console.WriteLine($"Value of the FirstVariable after modification: {FirstVariable}");
              Console.WriteLine($"Value of the SecondVariable remains the same: {SecondVariable}");
            */
            #endregion

            #region Q.6 Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            /* RefernceClass firstObject = new RefernceClass();
              firstObject.Value = 20;

             RefernceClass secondObject = firstObject; 

             Console.WriteLine($"Initial value of firstObject.Value: {firstObject.Value}");
             Console.WriteLine($"Initial value of secondObject.Value: {secondObject.Value}");

            firstObject.Value = 40;

            Console.WriteLine($"Value of firstObject.Value after modification: {firstObject.Value}");
            Console.WriteLine($"Value of secondObject.Value after modification: {secondObject.Value}");
            */
            #endregion

            #region Q7.Write C# program that take two string variables and print them as one variable 
            /* string Str1 = "Youssef ";
             string Str2 = "Ibrahim ";
             string CombinedString = Str1 + Str2;

             Console.WriteLine(CombinedString);
            */
            #endregion

            #region Q8. Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            /*
            Console.Write("Enter the principal amount: ");
            decimal Principal = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the rate of interest: ");
            decimal Rate = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the time in terms of years: ");
            decimal Time = Convert.ToDecimal(Console.ReadLine());

            decimal Interest = (Principal * Rate * Time) / 100;

            Console.WriteLine($"The simple interest is: {Interest}");

            */
            #endregion

            #region Q9. Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is
            /*
                        Console.Write("Enter your weight in kilograms: ");
                        double Weight = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Enter your height in meters: ");
                        double Height = Convert.ToDouble(Console.ReadLine());

                        double BMI = Weight / (Height * Height);

                        Console.WriteLine($"Your BMI is: {BMI}");
            */
            #endregion

            #region Q10. Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            /*
            Console.Write("Enter the temperature: ");
            int Temp = int.Parse(Console.ReadLine());

            string TempDesc = Temp < 10 ? "Just Cold" :
                (Temp > 30 ? "Just Hot" : "Just Good");
            Console.WriteLine($"The temperature is: {TempDesc}");

            */
            #endregion

            #region Q11. .Write a program that takes the date from the user and displays it in various formats using string interpolation.
            /*
            Console.Write("Enter the day: ");
            int Day = int.Parse(Console.ReadLine());

            Console.Write("Enter the month: ");
            int Month = int.Parse(Console.ReadLine());

            Console.Write("Enter the year: ");
            int Year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today's date: {Day}, {Month}, {Year}");
            Console.WriteLine($"Today's date: {Day} / {Month} / {Year}");
            Console.WriteLine($"Today's date: {Day} – {Month} – {Year}");
            */
            #endregion

            #region Q12.- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            string Result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";

            Console.WriteLine(Result);

            */
            #endregion

            #region Q13.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*
            Console.Write("Please Enter integer: ");
            int number2 = int.Parse(Console.ReadLine());

            string result = number2 < 0 ? "negative" : "positive";

            Console.WriteLine(result);
            */
            #endregion

            #region Q14.- Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
             Console.Write("Please Enter the first integer: ");
             int FirstNumber = int.Parse(Console.ReadLine());

             Console.Write("Please Enter the second integer: ");
             int SecondNumber = int.Parse(Console.ReadLine());

             Console.Write("Please Enter the third integer: ");
             int ThirdNumber = int.Parse(Console.ReadLine());

             int MaxNumber = FirstNumber;
             if (SecondNumber > MaxNumber) MaxNumber = SecondNumber;
             if (ThirdNumber > MaxNumber) MaxNumber = ThirdNumber;

             int MinNumber = FirstNumber;
             if (SecondNumber < MinNumber) MinNumber = SecondNumber;
             if (ThirdNumber < MinNumber) MinNumber = ThirdNumber;

             Console.WriteLine($"Max element = {MaxNumber}");
             Console.WriteLine($"Min element = {MinNumber}");

             */
            #endregion

            #region Q15.Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
              Console.Write("Enter an integer number: ");
              int number3 = int.Parse(Console.ReadLine());

              string result = (number3 % 2 == 0) ? "even" : "odd";

              Console.WriteLine($"The number is {result}.");
            */
            #endregion


            #region Q16.Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /*
            Console.Write("Enter a character: ");
            char inputChar = char.Parse(Console.ReadLine());

            string result = (inputChar == 'a' || inputChar == 'e' || inputChar == 'i' || inputChar == 'o' || inputChar == 'u') ? "vowel" : "consonant";

            Console.WriteLine(result);
            */

            #endregion


            #region Q17.Write a program to input the month number and print the number of days in that month.
            /*
            Console.Write("Please Enter the month number From 1 To 12 ");
            int MonthNumber = int.Parse(Console.ReadLine());

            int[] DaysInMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; //1 to 12

            if (MonthNumber < 1 || MonthNumber > 12)
            {
                Console.WriteLine("Invalid month number nter the month number From 1 To 12 ");
            }
            else
            {
                Console.WriteLine($"Days in Month: {DaysInMonths[MonthNumber - 1]}");//0 index
            }
            */
            #endregion


            #region Q18. Write a program to create a Simple Calculator.
            /*
            Console.Write("Please Enter the first number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please Enter an operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

            double result;

            if (op == '+')
            {
                result = Num1 + Num2;
            }
            else if (op == '-')
            {
                result = Num1 - Num2;
            }
            else if (op == '*')
            {
                result = Num1 * Num2;
            }
            else if (op == '/')
            {
                result = Num1 / Num2;
            }
            else
            {
                Console.WriteLine("Invalid operator.");
                return;
            }

            Console.WriteLine($"The result is: {result}");
            */
            #endregion


            #region Q19. Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*
            Console.Write("Please Enter an integer ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i < number)
                {
                    Console.Write(", ");
                }
            }
            */
            #endregion


            #region Q20. Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*
            Console.Write("Please Enter an integer ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                int result = number * i;
                Console.Write($"{result} ");
            }
            Console.WriteLine();
            */
            #endregion

            #region Q21. Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
             Console.Write("Please Enter an integer: ");
             int number = int.Parse(Console.ReadLine());

             for (int i = 2; i <= number; i += 2)
             {
                 Console.Write($"{i} ");
             }
             Console.WriteLine();
            */
            #endregion


            #region Q22. Write a program that takes two integers then prints the power.
            /*
            Console.Write("PLease Enter the number: ");
            int BaseNumber = int.Parse(Console.ReadLine());

            Console.Write("Please Enter the exponent: ");
            int exponent = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= BaseNumber;
            }

            Console.WriteLine($"The result of {BaseNumber} raised to the power of {exponent} is: {result}");

            */
            #endregion


            #region Q23. RWrite a program to allow the user to enter int and print the REVERSED of it
            /*
            Console.Write("Please Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            int ReversedNumber = 0;

            while (number != 0)
            {
                int remainder = number % 10;
                ReversedNumber = ReversedNumber * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($"Reversed number: {ReversedNumber}");
            */
            #endregion


            #region Q24. Write a program in C# Sharp to find prime numbers within a range of numbers.

            #endregion


            #region Q25. Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
            Console.Write("Please Enter number to convert: ");
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number; 
            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number /= 2;
            }

            Console.WriteLine($"The Binary of {originalNumber} is {binary}");
            */
            #endregion


            #region Q26. Write a program in C# Sharp to find the sum of all elements of the array.
/*
            int[] numbers = { 1, 2, 3, 4, 5 ,6 ,7 ,8 ,9 ,10};
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of all elements in the array is: {sum}");
*/
            #endregion



        }
    }
}


