namespace Day6Perfect
{
    internal class Perfect_NUmbers
    {
        public void perfect_Num()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int res = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    res += i;
                }
            }
            Console.WriteLine(res);
            if (res == num)
                Console.WriteLine("prefect number");
            else
                Console.WriteLine("Non perfect number");
        }
        static void Main() { Perfect_NUmbers perfect = new Perfect_NUmbers(); perfect.perfect_Num(); }

    }
}