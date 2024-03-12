namespace N165
{
    using Humanizer;
    using Humanizer.Configuration;
    using System.Globalization;

    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("da-DK");
            string danishHumanizedDate = DateTime.UtcNow.Humanize(culture: new CultureInfo("da-DK"));
            Console.WriteLine(danishHumanizedDate);
            int tal = 147_311;
            Console.WriteLine(tal.ToWords());

            DateTime d1 = new DateTime(2020, 12, 24);
            Console.WriteLine(d1.Humanize(culture: new CultureInfo("da-DK")));

            // Eksempel på nummer til ord
            int number = 123;
            string numberToWords = number.ToWords(culture: new CultureInfo("da-DK"));
            Console.WriteLine($"Number to words: {numberToWords}");

            // Eksempel på datohumanisering
            DateTime futureDate = DateTime.Now.AddDays(5);
            string humanizedDate = futureDate.Humanize();
            Console.WriteLine($"Humanized future date: {humanizedDate}");

            // Eksempel på camelCase til sætning
            string camelCaseString = "camelCaseString";
            string sentence = camelCaseString.Humanize(LetterCasing.Sentence);
            Console.WriteLine($"Camel case to sentence: {sentence}");
        }
    }
}
