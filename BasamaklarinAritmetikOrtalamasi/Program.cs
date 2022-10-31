int sayi, birBasamagi, onBasamagi, yuzBasamagi, ort=0;

do
{
    Console.Write("3 basamakli pozitif bir tamsayi giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    birBasamagi = sayi%10;
    onBasamagi = (sayi/10)%10;
    yuzBasamagi = sayi/100;
    ort = (birBasamagi+onBasamagi+yuzBasamagi)/3;

} while ((sayi<=100)||(sayi>999));

Console.Write("Ortalama: {0}",(double)ort);



