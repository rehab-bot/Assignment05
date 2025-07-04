namespace Assignment05
{
    internal class Program
    {
        public static void SimpleOperation(int x, int y)
        {
            x += 1;
            y -= 1;
        }
        static void Main(string[] args)
        {
            int a = 5, b = 7;
            SimpleOperation(a, b);
            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
