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
            #region  Q-3
            Console.Write("Enter 3 numbers separated by space: ");
            string[] inputs = Console.ReadLine()?.Split();
            if (inputs?.Length == 3 && int.TryParse(inputs[0], out int a) && int.TryParse(inputs[1], out int b) && int.TryParse(inputs[2], out int c))
            {
                int max = Math.Max(a, Math.Max(b, c));
                int min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"Max element = {max}");
                Console.WriteLine($"Min element = {min}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter exactly 3 integers.");
            }

            #endregion
            #region  Q-4
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num4))
            {
                Console.WriteLine(num4 % 2 == 0 ? "Even" : "Odd");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            #endregion
        }
    }
}
