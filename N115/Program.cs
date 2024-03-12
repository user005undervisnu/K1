System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("da-DK");

Console.WriteLine("Indtast tal 1");
string tal1 = Console.ReadLine();

Console.WriteLine("Indtast tal 2");
string tal2 = Console.ReadLine();

double t1 = System.Convert.ToDouble(tal1);
double t2 = System.Convert.ToDouble(tal2);

double sum = t1 + t2;

Console.WriteLine("Resultatet er: " + sum.ToString("N2"));
