double direnc, akim, gerilim;
Console.Write("Iletkenin direncini giriniz (R): ");
direnc = Convert.ToDouble(Console.ReadLine());
Console.Write("Iletkenin icinde akan akimi giriniz (I): ");
akim= Convert.ToDouble(Console.ReadLine());
gerilim = direnc*akim;
Console.Write("Iletkenin gerilim degeri: {0}",gerilim);