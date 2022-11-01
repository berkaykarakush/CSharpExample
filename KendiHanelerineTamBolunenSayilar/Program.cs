int baslangic, bitis, toplamSayi;

Console.Write("Baslangic degerini giriniz: ");
baslangic = Convert.ToInt32(Console.ReadLine());
Console.Write("Bitis degerini giriniz: ");
bitis = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<baslangic; i++){
    for(int j=1; j<baslangic; j++){
        toplamSayi = baslangic*i+j;
        if((toplamSayi%i==0) && (toplamSayi%j==0)){
            Console.WriteLine(toplamSayi);
        }
    }
}

