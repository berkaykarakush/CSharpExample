internal partial class Program
{
    public static void hanoi(int n, string k, string y, string h)
    {
        if(n == 1){
            Console.WriteLine("{0}.disk: {1} -> {2}",n,k,h);
        }
        else{
            hanoi(n-1,k,h,y);
            Console.WriteLine("{0}.disk: {1} -> {2}",n,k,h);
            hanoi(n-1,y,k,h);
        }
    }
    private static void Main(string[] args)
    {
        Console.Write("Disk sayisi: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        hanoi(sayi,"Kaynak","Yardimci","Hedef");
    }
}