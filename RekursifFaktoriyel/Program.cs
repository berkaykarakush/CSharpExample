internal class Program
{   public static int faktoriyel(int k)
    {
        if(k<=1){
            return 1;
        }
        else{
            return k*faktoriyel(k-1);
        }
    }
    private static void Main(string[] args)
    {
        int sayi;
        Console.Write("Pozitif tamsayi degeri giriniz: ");
        sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("\n{0}!={1}",sayi,faktoriyel(sayi));
    }
}