double x1, x2, ktop, kcarp;
Console.Write("x1 degerini giriniz: ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("x2 degerini giriniz: ");
x2 = Convert.ToDouble(Console.ReadLine());

ktop = x1+x2;
kcarp= x1*x2;

if(ktop<0){
    Console.Write("x^2+"+(-1)*ktop+"x");
}
else{
    Console.Write("x^2+"+ktop+"x");
}

if(kcarp<0){
    Console.Write(kcarp);
}
else {
    Console.Write("+"+kcarp);
}