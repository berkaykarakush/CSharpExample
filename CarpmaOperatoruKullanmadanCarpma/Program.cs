int sayi1, sayi2, sonuc=0;

Console.Write("Ilk sayi degerini giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci sayi degerini giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=sayi2; i++){
    sonuc+=sayi1;
}

Console.Write("{0} x {1} = {2}",sayi1,sayi2,sonuc);




