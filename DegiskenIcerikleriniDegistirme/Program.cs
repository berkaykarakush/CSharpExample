int sayi1, sayi2, tutucu;

Console.Write("Ilk sayi degerini giriniz: ");
sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ikinci sayi degerini giriniz: ");
sayi2 = Convert.ToInt32(Console.ReadLine());

tutucu = sayi1;
sayi1 = sayi2;
sayi2 = tutucu;

Console.Write("\nSayi 1: {0}\nSayi 2: {1}",sayi1,sayi2);