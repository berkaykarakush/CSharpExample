int n, r, f1=1, f2=1, f3=1,k;
Console.Write("n degerini giriniz: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("r degerini giriniz: ");
r = Convert.ToInt16(Console.ReadLine());
for(int i=1; i<=n; i++){
    f1*=i;
    if(i<=r){
        f2*=i;
        if(i<=n-r)
            f3*=i;
    }
        
}
k = f1/(f2*f3);
Console.Write("k degeri: {0}",k );