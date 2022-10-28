internal class Program
{
    private static void Main(string[] args)
    {
        double x, fx;
        Console.Write("x degerini giriniz: ");
        x = Convert.ToDouble(Console.ReadLine());
        fx = Math.Pow(x,2)-5*x+3;
        Console.Write(Math.Abs(fx)/fx);
    }
}