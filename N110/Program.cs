DateTime d1 = DateTime.Now;

d1 = d1.AddDays(10);
Console.WriteLine(d1);

d1 = d1.AddMinutes(20);
Console.WriteLine(d1);

d1 = d1.AddMonths(-1);
Console.WriteLine(d1);

DateTime d2 = new DateTime(2024, 3, 1);
DateTime d3 = new DateTime(2023, 3, 1);

TimeSpan t1 = d2 - d3;
Console.WriteLine(t1.Days);

TimeSpan t2 = TimeSpan.FromHours(16);
Console.WriteLine(t2);

TimeSpan t3 = TimeSpan.FromMinutes(30);
Console.WriteLine(t3);

TimeSpan t4 = t2 - t3;
Console.WriteLine(t4);

TimeSpan t5 = t2 + t3;
Console.WriteLine(t5);