double x, y;
Console.Write("y=f(x)\nX degerini giriniz: ");
x = Convert.ToDouble(Console.ReadLine());
if(x<0)
    y=1;
else if(0<=x && x<=2)
    y=x;
else if(2<x && x<=4)
    y=3;
else 
    y=4-x;
Console.Write("Fonksiyonun x={0} noktasindaki y degeri: {1}",x,y);