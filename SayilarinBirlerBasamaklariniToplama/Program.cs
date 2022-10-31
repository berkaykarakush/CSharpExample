int n, sayi, toplam=0, i=0;

Console.Write("Kac adet sayi degeri gireceksiniz: ");
n = Convert.ToInt32(Console.ReadLine());

while(i<n){
    Console.Write("Sayi degeri giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam = toplam + sayi % 10;
    i++;
}
Console.Write("\nToplam: {0}",toplam);
