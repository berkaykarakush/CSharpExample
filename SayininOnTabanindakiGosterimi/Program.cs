int sayi, kalan, onTabanindakiSayi=0;

Console.Write("Sayi degeri giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

kalan = sayi;
while(kalan!=0){
    Console.Write(kalan%10 + ".10^" + onTabanindakiSayi + " + ");
    kalan = kalan/10;
    onTabanindakiSayi+=1;
}