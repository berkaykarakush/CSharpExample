int sayi1, sayi2;
Console.Write("Ilk sayi degerini giriniz: ");
sayi1 = Convert.ToInt16(Console.ReadLine());
Console.Write("Ikinci sayi degerini giriniz: ");
sayi2 = Convert.ToInt16(Console.ReadLine());
if(sayi1 % sayi2 == 0)
    Console.Write("\n{0} sayisi {1} sayisina tam bolunuyor.",sayi1,sayi2);
else 
    Console.Write("\n{0} sayisi {1} sayisina tam bolunmuyor.",sayi1, sayi2);