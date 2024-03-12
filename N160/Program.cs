namespace N160
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Beregn(1, 2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 4, 5));

        }


        static int Beregn(int a, int b, int c = 0, int d = 0)
        {
            return a + b + c + d;
        }
    }
}
