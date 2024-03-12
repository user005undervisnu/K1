namespace N122
{
    using Konstanter;
    internal class Program
    {
        static void Main(string[] args)
        {

            KortVærdi kort1Værdi = KortVærdi.To;
            KortKulør kort1Kulør = KortKulør.Hjerter;

            Console.WriteLine($"Det første kort er {kort1Kulør} {kort1Værdi}");

            KortVærdi kort2Værdi = KortVærdi.To;
            KortKulør kort2Kulør = KortKulør.Ruder;

            Console.WriteLine($"Det andet kort er {kort2Kulør} {kort2Værdi}");
        }
    }
}

