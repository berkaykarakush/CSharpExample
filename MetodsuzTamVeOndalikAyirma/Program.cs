double sayi, ondalikliKisim;
int tamKisim;

Console.Write("Bir sayi degeri giriniz: ");
sayi = Convert.ToDouble(Console.ReadLine());

tamKisim = (int)sayi;
ondalikliKisim = sayi-tamKisim;

Console.Write("Girilen sayi degerinin tam kismi: {0}\nGirilen sayi degerinin ondalikli kismi: {1:F2}",tamKisim,ondalikliKisim);