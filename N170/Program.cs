namespace N170
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ups - fejl i input: {ex.Message}");
            }
           


        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }

    }
}
