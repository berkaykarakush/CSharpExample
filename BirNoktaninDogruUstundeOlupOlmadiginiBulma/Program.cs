double a, b, c, x1, y1, uz;
Console.Write("ax + by + c = 0\na degerini giriniz: ");
a = Convert.ToDouble(Console.ReadLine());
Console.Write("b degerini giriniz: ");
b = Convert.ToDouble(Console.ReadLine());
Console.Write("c degerini giriniz: ");
c = Convert.ToDouble(Console.ReadLine());
Console.Write("x1 degerini giriniz: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1 degerini giriniz: ");
y1= Convert.ToDouble(Console.ReadLine());

if(a*x1+b*y1+c==0)
    Console.Write("Girilen nokta dogru uzerindedir.");
else{
    uz = (a*x1+b*y1+c)/Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));
    Console.Write("Girilen nokta dogur uzerinde degildir. Noktanin dogruya olan uzakligi {0} birimdir.", uz);
}