int sayi;
Console.Write("Sayi degerini giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());
Console.Write("1");
for(int i=2; i<=sayi/2; i++){
    if(sayi%i==0)
        Console.Write("\n{0}",i);
}
Console.Write("\nSayi: {0}",sayi);