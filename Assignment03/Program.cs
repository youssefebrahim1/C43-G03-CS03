namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q.1 Write a program that allows the user to enter a number then print it
            Console.Write("Please enter a number to print it");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number you have entered is {Number}");
            #endregion

            #region Q.2Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            /*
            String UserInput = "Test125";
            Console.WriteLine(int.Parse(UserInput)); //The input string 'Test125' was not in a correct format.'
            */
            #endregion

            #region Q3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            #endregion



        }
    }
}
