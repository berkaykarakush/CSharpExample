int a, b, c;
double d, x1, x2;
Console.Write("Ax^2 + Bx + C = 0\nD=B^2-4AC\nA degerini giriniz: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("B degerini giriniz: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("C degerini giriniz: ");
c = Convert.ToInt32(Console.ReadLine());
d = Math.Pow(b,2)-4*a*c;
if(d>0){
    x1 = (-b-Math.Sqrt(d))/(2*a);
    x2 = (-b+Math.Sqrt(d))/(2*a);
    Console.Write("x1: {0}\nx2:{1}",x1,x2);
}
else if(d==0){
    x1=-b/(2*a);
    Console.Write("x1: {0}",x1);
}
else 
    Console.Write("sanal kokler");