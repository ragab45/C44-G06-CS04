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
        }
    }
}
