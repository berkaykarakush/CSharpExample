double a, h, alan;
Console.Write("Kenar uzunlugunu giriniz (cm): ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("Yuksekligi giriniz (cm): ");
h = Convert.ToDouble(Console.ReadLine());
alan = a*h/2;
Console.WriteLine("\nUcgenin Alani (cm2): {0}",alan);