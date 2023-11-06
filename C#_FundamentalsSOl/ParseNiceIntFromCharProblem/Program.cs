namespace ParseNiceIntFromCharProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parse nice int from char problem");
        }
        public static int GetAge(string inputString)
        {
            return int.Parse(inputString.Substring(0, 1));
        }
    }
}
/*
 You ask a small girl,"How old are you?" She always says, "x years old", where x is a random number between 0 and 9.

Write a program that returns the girl's age (0-9) as an integer.

Assume the test input string is always a valid string. For example, the test input may be "1 year old" or "5 years old". The first character in the string is always a number.
 */

/*
 public class Kata
{
  public static int GetAge(string inputString)
  {
    return inputString[0] - '0';
  }
}
El valor ASCII de un carácter es un número que representa el carácter en la computadora. El valor ASCII del carácter '0' es 48. Por lo tanto, el código inputString[0] - '0' restará 48 del valor ASCII del primer carácter de la cadena de entrada. Esto devolverá la edad como un número entero.

Por ejemplo, si la cadena de entrada es "25", la función GetAge() devolverá el número entero 25. Esto se debe a que el valor ASCII del carácter '2' es 50, y el valor ASCII del carácter '0' es 48. Por lo tanto, la expresión inputString[0] - '0' devolverá el número 25.
 
 */