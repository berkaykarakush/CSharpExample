int a, b ,c ,d ,e, f, x, y;
Console.Write("ax+by=c\ndx+ey=f\na degerini giriniz: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("b degerini giriniz: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("c degerini giriniz: ");
c = Convert.ToInt32(Console.ReadLine());

Console.Write("d degerini giriniz: ");
d = Convert.ToInt32(Console.ReadLine());

Console.Write("e degerini giriniz: ");
e = Convert.ToInt32(Console.ReadLine());

Console.Write("f degerini giriniz: ");
f = Convert.ToInt32(Console.ReadLine());
x = (c-b*f/e)/(a=b*d/e);
y = (c-a*x)/b;
Console.Write("\nX degeri: {0}\nY degeri: {1}",x,y);