namespace N120
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine($"Underviserens søn hedder:\n{samletNavn}");

            string navnStort = samletNavn.ToUpper();
            Console.WriteLine($"Her råber jeg navnet:\t{navnStort}");

            string navnLille = samletNavn.ToLower();
            Console.WriteLine($"og nu hvisker jeg det:\t{navnLille}");

            string delNavn = samletNavn.Substring(7, 4);
            Console.WriteLine(delNavn);

            File.WriteAllText("C:\\kode\\Kursus\\N120\\out.txt", delNavn);
        }
    }
}
