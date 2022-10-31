int sayi1, sayi2;
double bolum=0, kalan;

Console.Write("Ilk sayi degerini giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci sayi degerini giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

kalan = sayi1;

while(kalan >= sayi2){
    kalan-=sayi2;
    bolum+=1;
}
Console.WriteLine("Bolum: {0}\nKalan:{1}",bolum,kalan);


