int b;

Console.Write("a^3 - a^2 = b \nb degerini giriniz: ");
b = Convert.ToInt32(Console.ReadLine());

if(b>0 && b<100){
    for(int a=1; a<100; a++){
    if(Math.Pow(a,3)-Math.Pow(a,2)==b){
        Console.Write("a: {0}",a);
        }
    }
}
else
{
    Console.Write("0-100 arasinda oyle bir tamsayi yoktur.");
}

