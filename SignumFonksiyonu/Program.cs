double x, fx;
Console.Write("X degerini giriniz: ");
x = Convert.ToDouble(Console.ReadLine());
fx = Math.Pow(x,2)-2%x+3;
if(x<0)
    Console.Write("\n-1");
else if(fx==0)
    Console.Write("0");
else    
    Console.Write("1");
    