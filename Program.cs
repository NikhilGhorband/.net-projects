namespace Day8Four
{
    public class Length : IComparable<Length>
    {

        private int value;

        // Constructor
        public Length(int value)
        {
            this.value = value;
        }

        // CompareTo method to compare two lengths
        public int CompareTo(Length other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            if (value < other.value)
            {
                return -1;
            }
            else if (value == other.value)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Length length1 = new Length(5);
            Length length2 = new Length(10);

            int result = length1.CompareTo(length2);

            if (result < 0)
            {
                Console.WriteLine("Length1 is smaller than Length2");
            }
            else if (result == 0)
            {
                Console.WriteLine("Length1 is equal to Length2");
            }
            else
            {
                Console.WriteLine("Length1 is larger than Length2");
            }
        }
    }
}