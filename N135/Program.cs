namespace N135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);

                if (i == 15)
                    break;
            }
        }
    }
}
