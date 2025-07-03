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
            #region  Q-5
            Console.Write("Enter a character: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if ("aeiou".Contains(ch))
                Console.WriteLine("Vowel");  
            else
                Console.WriteLine("Consonant");

            #endregion
            #region  Q-6
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num6))
            {
                for (int i = 1; i <= num6; i++)
                    Console.Write(i + (i == num6 ? "\n" : ", "));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            #endregion
            #region  Q-7
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num7))
            {
                for (int i = 1; i <= 12; i++)
                    Console.Write((num7 * i) + (i == 12 ? "\n" : " "));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            #endregion

            #region  Q-8
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int num8))
            {
                for (int i = 2; i <= num8; i += 2)
                    Console.Write(i + (i + 2 > num8 ? "\n" : " "));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }




            #endregion

            #region  Q-9
            Console.Write("Enter base and exponent: ");
            string[] powerInput = Console.ReadLine()?.Split();
            if (powerInput?.Length == 2 && int.TryParse(powerInput[0], out int baseNum) && int.TryParse(powerInput[1], out int exponent))
            {
                Console.WriteLine(Math.Pow(baseNum, exponent));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }





            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion

            #region  Q-7

            #endregion
        }
    }
}
