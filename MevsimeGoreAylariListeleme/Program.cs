int mevsim;
Console.Write("1-Ilkbahar\n2-Yaz\n3-Sonbahar\n4-Kis\nSecimizin: ");
mevsim = Convert.ToInt32(Console.ReadLine());
switch(mevsim)
{
    case 1:
        Console.Write("Mart, Nisan, Mayis");
        break;
    case 2:
        Console.Write("Haziran, Temmuz, Agustos");
        break;
    case 3:
        Console.Write("Eylul, Ekim, Kasim");
        break;
    case 4:
        Console.Write("Aralik, Ocak, Subat");
        break;
    default: 
        Console.Write("Gecersiz secim");
        break;
}