int sayi;
Console.Write("Bir sayi degeri giriniz: ");
sayi = Convert.ToInt16(Console.ReadLine());
if(sayi % 2 == 0)
    Console.Write("\nGirilen sayi cifttir.");
else 
    Console.Write("\nGirilen sayi tektir.");