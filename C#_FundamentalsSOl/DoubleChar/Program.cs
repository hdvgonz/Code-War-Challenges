namespace DoubleChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("String"));
        }

        public static string DoubleChar(string s)
        {
            string msg = "";
            for (int i = 0; i < s.Length; i++)
            {
                msg += s[i].ToString() + s[i].ToString(); 
            }

            return msg;
        }
    }
}

/*
 Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

Examples (Input -> Output):
* "String"      -> "SSttrriinngg"
* "Hello World" -> "HHeelllloo  WWoorrlldd"
* "1234!_ "     -> "11223344!!__  "
Good Luck!
 */