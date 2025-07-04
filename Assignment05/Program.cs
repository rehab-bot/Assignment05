using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment05
{
    internal class Program
    {
        #region EX01
        //public static void SimpleOperation(int x, int y)
        //{
        //    x += 1;
        //    y -= 1;
        //}
        //static void Main(string[] args)
        //{
        //    int a = 5, b = 7;
        //    SimpleOperation(a, b);
        //    Console.WriteLine($"a = {a}, b = {b}");
        //}
        #endregion
        #region EX02
        //public static void SimpleOperation(ref int x, ref int y)
        //{
        //    x += 1;
        //    y -= 1;
        //}
        //static void Main(string[] args)
        //{
        //    int a = 5, b = 7;
        //    SimpleOperation(ref a, ref b);
        //    Console.WriteLine($"a = {a}, b = {b}");
        //}
        #endregion
        #region EX03
        //public static void SimpleOperation(int x, int y, out int sum, out int sub)
        // {
        //     sum = x + y;
        //     sub = x - y;
        // }
        // static void Main(string[] args)
        // {
        //     int a = 5, b = 7;
        //     SimpleOperation(a, b, out int sum, out int sub);
        //     Console.WriteLine($"a = {a}, b = {b}, sum = {sum}, product = {sub}");
        // }  
        #endregion
        public static int Summation(int number)
        {

            int dividor = number / 10;
            int minder = number % 10;
            int sum = dividor + minder;
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int.TryParse(Console.ReadLine(), out int number);
            int result = Summation(number);
            Console.WriteLine($"The sum of the digits is : {result}");
        }
    }
}
