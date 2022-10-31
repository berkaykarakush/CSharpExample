int saat, dakika, ilerleme;

Console.Write("Saat (0-11): ");
saat = Convert.ToInt32(Console.ReadLine());
Console.Write("Dakika (0-59): ");
dakika = Convert.ToInt32(Console.ReadLine());

ilerleme = dakika/2;
saat *=30;
dakika *= 6;

Console.WriteLine("{0},{1}",saat+ilerleme,dakika);