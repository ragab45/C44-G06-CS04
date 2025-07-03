namespace Assemente_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q-1
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine((number % 3 == 0 && number % 4 == 0) ? "Yes" : "No");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            #endregion
            #region Q-2
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine(num2 < 0 ? "negative" : "positive");
            }
            else
            {
                Console.WriteLine("Invalid input."); 
            }
            #endregion
        }
    }
}
