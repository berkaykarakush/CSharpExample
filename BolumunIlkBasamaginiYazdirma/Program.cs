int sayi1, sayi2, kalan=0, r=1;

Console.Write("Ilk sayi degerini giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci sayi degerini giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

Console.Write("\n0.");
while(kalan != sayi2){
    Console.Write((10*r)/sayi1);
    r = 10*r%sayi1;
    kalan+=1;
}

