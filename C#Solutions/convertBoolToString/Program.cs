namespace convertBoolToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static string BoolToWord(bool word)
        {
            string msg = "No";

            if (word)
            {
                msg = "Yes";
                Console.WriteLine(msg);
                return msg;
            }
            Console.WriteLine(msg);
            return msg;
        }
    }
}