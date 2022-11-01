internal partial class Program
{
    public static int McCarthy91(int k){
        if(k>100){
            return k-10;
        }
        else{
            return McCarthy91(McCarthy91(k+11));
        }
    }

    private static void Main(string[] args){
        int n;
        Console.Write("Deger: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nMcCarthy 91 Fonksiyon degeri: {0}",McCarthy91(n));
    }
}