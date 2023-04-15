namespace Fibonascci
{
    internal class Fibonacci_Series
    {
        public void Series()
        {
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            for (int i = 2; i <= n; i++)
            {
                int c;
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;

            }
        }
        public  static void Main() { Fibonacci_Series fibonacci_Series = new Fibonacci_Series(); fibonacci_Series.Series();}
    }
}