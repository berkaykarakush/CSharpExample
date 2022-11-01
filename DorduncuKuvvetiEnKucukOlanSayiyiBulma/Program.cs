int n;
double sayi, aranan;

Console.Write("Basamak sayisi: ");
n = Convert.ToInt32(Console.ReadLine());

sayi = Math.Pow(Math.Pow((Math.Pow(10,n-1)),(0.25)),4);
aranan = Math.Pow(sayi,(0.25));

Console.Write("a: {0:F2}\ns:{1:F2}",aranan, sayi);