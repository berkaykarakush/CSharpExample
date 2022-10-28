int n, r, k, f1=1, f2=1, f3=1;
Console.Write("n degerini giriniz: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("r degerini giriniz: ");
r = Convert.ToInt16(Console.ReadLine());
for(int i=1; i<=n; i++){
    f1*=i;
}
for(int i=1; i<=r; i++){
    f2*=i;
}
for(int i=1; i<=n-r; i++){
    f3*=i;
}
k = f1/(f2*f3);
Console.Write("K degeri: {0}", k);
