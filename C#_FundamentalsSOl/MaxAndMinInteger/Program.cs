namespace MaxAndMinInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Max(new[] {384014813}));
        }

        public static int Min(int[] list)
        {
            int min = list[0];

            foreach (int item in list)
            {
                if (item < min)
                {
                    min = item;
                }

            }
            return min;
            //return list.Min(); short option by using Min method
        }

        public static int Max(int[] list)
        {
            int max = list[0];
            
            foreach (int item in list)
            {
                if (item > max)
                {
                    max = item;
                }

            }
            return max;
            //return list.Max(); short option by using Max method
        }
    }
}

/*
 Your task is to make two functions ( max and min, or maximum and minimum, etc., depending on the language ) that receive a list of integers as input, and return the largest and lowest number in that list, respectively.

Examples (Input -> Output)
* [4,6,2,1,9,63,-134,566]         -> max = 566, min = -134
* [-52, 56, 30, 29, -54, 0, -110] -> min = -110, max = 56
* [42, 54, 65, 87, 0]             -> min = 0, max = 87
* [5]                             -> min = 5, max = 5
Notes
You may consider that there will not be any empty arrays/vectors.
 */