internal class Program
{
    public static float faktoriyel(int x)
        {
            float z = 1;
            for (int y = 1; y <= x; y++)
                z *= y;
            return z;

        }
    static void Main(string[] args)
    {
        int n, r;
        float f1, f2, f3, k;
        Console.Write("Kombinasyon(n,r)");
        Console.Write("\nn degerini giriniz :");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("r degerini giriniz :");
        r = Convert.ToInt32(Console.ReadLine());
        f1 = faktoriyel(n);
        f2 = faktoriyel(r);
        f3 = faktoriyel(n-r);
        k = f1/(f2*f3);
        Console.Write("Kombinasyon({0},{1}): {2}",n,r,k);
    }
}