namespace Day6StopWatch
{
        internal class StopWatch
        {
            public void watch()
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                for (int i = 1; i <= 20; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("hy everyone");
                }
                stopwatch.Stop();
                Console.WriteLine("Time elapsed" + stopwatch.Elapsed);
            }
            public static void Main() { Stopwatch stop=new Stopwatch(); stop.watch(); }
        }
    }