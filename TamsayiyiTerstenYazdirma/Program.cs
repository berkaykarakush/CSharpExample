int sayi, kalan;

Console.Write("Tamsayi giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

kalan = sayi;
Console.Write("Tamsayinin tersten yazilmis hali: ");
while(kalan!=0){
     Console.Write(kalan%10);
     kalan /=10;
}
