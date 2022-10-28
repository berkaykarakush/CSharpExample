int sayi, sayilarToplami=0, tekSayilarToplami=0, ciftsayilarToplami=0;
Console.Write("Sayi Degerini Giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());
for(int i=0; i<=sayi; i++){
    sayilarToplami+=i;
    if(i % 2 == 0)
        ciftsayilarToplami+=i;
    else 
        tekSayilarToplami+=i;
}
Console.Write("\nSayilar Toplami: {0}\ntek Sayilar Toplami: {1}\nCift Sayilar Toplami: {2}",sayilarToplami,tekSayilarToplami,ciftsayilarToplami);