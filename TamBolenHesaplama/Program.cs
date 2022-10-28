int sayi;
Console.Write("Sayi degerini giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());
for(int i=1; i<=sayi; i++){
    if(sayi%i==0)
        Console.Write("\n{0}",i);        
}