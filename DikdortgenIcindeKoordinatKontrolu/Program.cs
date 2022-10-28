double x1, y1, x2, y2, x3, y3;
Console.Write("Sol alt - x1 degerini giriniz: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sol alt - y1 degerini giriniz: ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sag ust - x2 degerini giriniz: ");
x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Sag ust - y2 degerini giriniz: ");
y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("x3 degerini giriniz: ");
x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("y3 degerini giriniz: ");
y3 = Convert.ToDouble(Console.ReadLine());
if((x3>x1)&&(y3>y1)&&(x3<x2)&&(y3<y2))
Console.Write("Girilen koordinatlar dikdortgenin icinde ");
else 
Console.Write("Girilen koordinatlar dikdortgenin icinde degildir. ");
    