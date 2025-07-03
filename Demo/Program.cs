namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  Video_1
            // Example 01 [pattern matching on types]
            switch (obj)
            {
                case int value: // Unboxing
                    Console.WriteLine("Integer");
                    break;
                case decimal value:
                    Console.WriteLine("Decimal");
                    break;
                case double value:
                    Console.WriteLine("Double");
                    break;
                default:
                    Console.WriteLine("No Match");
                    break;
            }
           

            // Evolution of switch in C#
            object obj = 10; // Boxing

            // C# 7.0 [pattern matching - Case Guards (When)]

            // Example 01 is collapsed in the image

           //Example 02 [Case Guards (When)]
            switch (obj)
            {
                case int value when value < 10:
                    Console.WriteLine("Integer Is Less Than 10");
                    break;
                case int value when value > 10:
                    Console.WriteLine("Integer Is Greater Than 10");
                    break;
                case decimal value:
                    Console.WriteLine("Decimal");
                    break;
                case double value when value > 5.6 && value < 10.7:
                    Console.WriteLine("Double Between 5.6 & 10.7");
                    break;
            }
            #endregion

            #region  Video_2
         //Switch Case Before Switch Expression
            // Example 01 - Pattern matching without alias name

            string option = Console.ReadLine();
            string message;

            switch (option)
            {
                case "1":
                    message = "Option 01";
                    break;
                case "2":
                    message = "Option 02";
                    break;
                case "3":
                    message = "Option 03";
                    break;
                default:
                    message = "Invalid Option";
                    break;
            }

            Console.WriteLine(message);


           // Example 04 [Nullable Type - Relational Patterns]

            int? X = 10;
            X = null;

            string message = X switch
            {
                null => "Null Value",
                int number when number > 0 => "Positive Number",
                int number when number < 0 => "Negative Number",
                0 => "Zero",
                // The default case isn't required here if all possibilities of int? are handled
            };

            Console.WriteLine(message);

            
            #endregion
        }
    }
}
