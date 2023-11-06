namespace LoveDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The love Program!");
        }
    public static bool Lovefunc(int flower1, int flower2)
    {
        bool inLove = (flower1 % 2 == 0 && flower2 % 2 != 0) || (flower2 % 2 == 0 &&  flower1 % 2 != 0) ? true : false;

        return inLove;
    }
    }

}

/*
 Timmy & Sarah think they are in love, but around where they live, they will only know once they pick a flower each. If one of the flowers has an even number of petals and the other has an odd number of petals it means they are in love.

Write a function that will take the number of petals of each flower and return true if they are in love and false if they aren't.
 */