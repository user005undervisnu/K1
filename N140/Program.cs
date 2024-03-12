namespace N140
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53
            double res3 = BeregnBeløbEfterMoms(100, .25);
            Console.WriteLine(res3); // 125
            Udskriv("Dette er en test"); // Dette er en test

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * Math.PI;
        }

        static double BeregnBeløbEfterMoms(double beløb, double momsPct)
        {
            return (1 + momsPct) * beløb;
        }


        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
