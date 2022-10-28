internal partial class Program
{
    private static void Main(string[] args)
    {
        double sayi,sonuc;
        Console.Write("Donusturmek istediginiz sayi degerini giriniz(m): ");
        sayi = Convert.ToDouble(Console.ReadLine());
        Console.Write("Donusturme secenekleri\n1-mm\n2-cm\n3-dm\n4-km\nSeciminiz: ");
        int sec = Convert.ToInt16(Console.ReadLine());
        switch(sec)
        {
            case 1:
                sonuc=1000*sayi;
                break;
            case 2:
                sonuc=100*sayi;
                break;
            case 3:
                sonuc=10*sayi;
                break;
            case 4:
                sonuc=sayi/1000;
                break;
            default:
                sonuc=0;
                break;
        }
        Console.Write("\nDonusum degeri: {0}",sonuc);
    }
}