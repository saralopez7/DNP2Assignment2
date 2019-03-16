using System;


namespace Assignment2
{
    class Program
    {
        private static int _count;

        static void Main(string[] args)
        {
            var xs = new IntList(1, 2, 3, 4, 500, 100);

            #region IntList

            Console.WriteLine("\n------------ IntList ------------");

            Console.WriteLine("\nPrint all elements");
            xs.Act(Console.WriteLine);
            Console.WriteLine("\nCustom print all elements");
            xs.Act(CustomWriteLine);

            Console.WriteLine("\nPrint all even elements");
            xs.Filter(x => x % 2 == 0).Act(Console.WriteLine);

            Console.WriteLine("\nPrint all even elements that are greater than or equal to 25");
            xs.Filter(x=> x >= 25).Act(Console.WriteLine);

            xs.Act(AddElements);
            Console.WriteLine($"\nSum of {xs.ToString<int>()} is {_count}");

            #endregion

            #region Generic List

            Console.WriteLine("\n------------ Generic List ------------");

            var stringList = new MyList<string>("Sara", "Jonh", "Maria");

            Console.WriteLine("\nPrint all elements");
            stringList.Act(Console.WriteLine);

            Console.WriteLine("\nCustom print all elements");
            stringList.Act(CustomWriteLine);

            Console.WriteLine("\nPrint all elements with more than 4 leters");
            stringList.Filter(x => x.Length > 4).Act(Console.WriteLine);

            #endregion

            Console.ReadLine();
        }

        #region IntList anonymous delegate expressions

         public static void CustomWriteLine<T>(T number)
        {
            Console.WriteLine($"Item: {number}");
        }

        public static void AddElements(int number)
        {
            _count += number;
        }
        #endregion
    }

    
}
