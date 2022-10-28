int a, b, c, x;
Console.Write("ax+b=x\na degerini giriniz: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("b degerini giriniz: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("c degerini giriniz: ");
c = Convert.ToInt32(Console.ReadLine());
x = (c-b)/a;
Console.Write("\n Birinci dereceden denklemin koku: {0}",x);