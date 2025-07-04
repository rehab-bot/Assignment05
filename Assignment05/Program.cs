using System.Globalization;
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
        #region EX04
        //public static int Summation(int number)
        //{

        //    int dividor = number / 10;
        //    int minder = number % 10;
        //    int sum = dividor + minder;
        //    return sum;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Enter the number : ");
        //    int.TryParse(Console.ReadLine(), out int number);
        //    int result = Summation(number);
        //    Console.WriteLine($"The sum of the digits is : {result}");
        //} 
        #endregion
        #region EX05
        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1)
        //        return false;
        //    else if (number == 2)
        //        return true;
        //    else if (number % 2 == 1)
        //    {
        //        for (int i = 2; i <= Math.Sqrt(number); i++)
        //        {
        //            if (number % i == 0)

        //                return false;
        //        }
        //        return true;
        //    }
        //    else
        //        return false;

        //}
        //static void Main(string[] args)
        //{    
        //    int number;
        //    bool isparsed;
        //    do

        //    {
        //        Console.Write("Enter a number to check if it is prime: ");
        //      isparsed =  int.TryParse(Console.ReadLine(), out  number);
        //    } while (!isparsed);
        //    bool result = IsPrime(number);
        //    Console.WriteLine($"Is the number {number} prime? {result}");
        //} 
        #endregion
        public static int[] MaxMinArray(ref int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
               
            }
            for (int i = 1; i < arr.Length; i++)

            {    if (arr[i] > max)
                {
                    max = arr[i];
                }
           
            }

            return new int[] { min, max };

        }
        static void Main(string[] args)
        { int i = 0;
            int[] numbers = new int[5];
            do
            {
                Console.Write($"Enter the number of elements in the array #{i + 1} : ");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            } while (i < numbers.Length);
          int[] result = MaxMinArray(ref numbers);
                Console.WriteLine($"Minimum  is {result[0]}  , Maximum is  {result[1]}");
            }

        }
    }

