namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
<<<<<<< Updated upstream
    }
=======

        // The main part of the code from the image
        public class Program
        {
            public static void Main(string[] args)
            {
                #region Example 03 [Enhanced Property Matching]
                // Comments from the code explaining the logic:
                /// Person is Samy and His Age is Greater Than 10
                /// Person is Omar and His Age is between 20 and 24
                /// Person's Age is between 50 and 60
                /// Any One Else [Sorry But We Don't Know You]

                Person person = new Person()
                {
                    Id = 1,
                    Name = "Ahmed",
                    Age = 20
                };

                string message = person switch
                {
                    // if person's Name is "Samy" AND Age is > 10
                    { Name: "Samy", Age: > 10 } => person.Print(),

                    // if person's Name is "Omar" AND Age is between 20 and 24
                    { Name: "Omar", Age: >= 20 and <= 24 } => "Hello Omar",

                    // if person's Age is between 50 and 60
                    { Age: > 50 and < 60 } => "Hello Old Man",

                    // Default case for any other person
                    _ => "We Don't Know You"
                };

                Console.WriteLine(message);
                
            }
        }
        #endregion

        #region  Sritng
        // Example 02
        //string name01 = "Amr";
        //string name02 = "May";

        //Console.WriteLine($"Name01 => {name01}");
        //    Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");

        //    Console.WriteLine($"Name02 => {name02}");
        //    Console.WriteLine($"HashCode Of Name02 => {name02.GetHashCode()}");

        //    name02 = name01;
        //    Console.WriteLine("========== After Assign ==========");
        //    Console.WriteLine($"Name01 => {name01}");
        //    Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");

        //    Console.WriteLine($"Name02 => {name02}");
        //    Console.WriteLine($"HashCode Of Name02 => {name02.GetHashCode()}");

        //    name01 = "Omar";
        //    Console.WriteLine("========== After Changing Value Of Name01 ==========");
        //    Console.WriteLine($"Name01 => {name01}");
        //    Console.WriteLine($"HashCode Of Name01 => {name01.GetHashCode()}");
        #endregion

        
        #region while - do while

        #region do-while
        /// Let User Enter an Even Number
        /// if value is an odd number -> Enter value again
        /// if it's not a number -> Enter value again
        /// if value is an even number -> Print number
//        int number;
//        bool isParsed;
//do
//{
//    Console.WriteLine("Please Enter An Even Number : ");
//    isParsed = int.TryParse(Console.ReadLine(), out number);
//    }
//while (number % 2 == 1 || !isParsed);

//Console.WriteLine($"{number} Is Even Number");
//#endregion

//#region while

#endregion

        
    }


}
>>>>>>> Stashed changes
}
