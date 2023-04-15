namespace Day6Random
{
    internal class Coupon
    {
        public void randomly()
        {
            Console.WriteLine("enter a required number of random values");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Random random = new Random();
            arr[0] = random.Next();
            for (int i = 1; i < num; i++)
            {
                int temp = random.Next();

                foreach (int j in arr)
                {

                    if (j == temp)
                    {

                        --i;
                        break;
                    }
                    else
                    {
                        arr[i] = temp;
                        break;
                    }
                }

            }
            for (int i = 1; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main() { Coupon coupon = new Coupon(); coupon.randomly();}
    }
}