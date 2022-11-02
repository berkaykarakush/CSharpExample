int x, n, t=1;

Console.Write("X degerini giriniz: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("N degerini giriniz: ");
n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<n-1; i++){
    int f=1;
    for(int j=1; j<2*i; j++){
        f*=j;
    }
    t = t + (Math.Pow(-1,i)*Math.Pow(x,2*i))/f;
}

Console.Write("T: {0}",t);