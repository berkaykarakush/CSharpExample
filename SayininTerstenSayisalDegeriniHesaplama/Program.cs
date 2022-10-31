int sayi, terstenToplam=0, kalan;

Console.Write("Tamsayi degerini giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

while(sayi!=0){
    kalan = sayi % 10;
    terstenToplam = terstenToplam*10+kalan;
    sayi = sayi/10;
}

Console.Write("Sayinin tersten toplami: {0}",terstenToplam);