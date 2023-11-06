namespace ReversedSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseSeq(5);
        }
    public static int[] ReverseSeq(int n)
    {
        int[] result = new int[n];
        int tam = result.Length;
        
        while(n > 0)
        {
                result[tam - n] = n;
                n--;
                
        }

        return result;
    }
    }
}

/* 
 Build a function that returns an array of integers from n to 1 where n>0.

Example : n=5 --> [5,4,3,2,1]
 */