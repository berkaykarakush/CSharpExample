int n, enb=-1, sayi;

Console.Write("Kac adet sayi gireceksiniz ?: ");
n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n;){
    Console.Write("Sayi degerini giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if((sayi%2==0) && (sayi>enb)){
        enb = sayi;
    }
    i++;
}

if(enb == -1){
    Console.Write("Cift tamsayi yok.");
}
else{
    Console.Write("\n En buyuk cift tamsayi: {0}",enb);
}
