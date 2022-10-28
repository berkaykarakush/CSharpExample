int sayi, sayilatToplami=0, tekSayilarToplami=0, ciftSayilarToplami=0;
Console.Write("sayi degerini Giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());
for(int i=0; i<=sayi; i++){
    sayilatToplami+=i;
}
for(int i=1; i<=sayi; i+=2){
    tekSayilarToplami+=i;
}
for(int i=2; i<=sayi; i+=2){
    ciftSayilarToplami+=i;
}
Console.Write("\nSayilar Toplami: {0}\nTek Sayilar Toplami: {1}\nCift Sayilar Toplami: {2}",sayilatToplami,tekSayilarToplami,ciftSayilarToplami);