int pay, payda, n, basamakDegeri=0;

Console.Write("Pay: ");
pay = Convert.ToInt32(Console.ReadLine());
Console.Write("Payda: ");
payda = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
n = Convert.ToInt32(Console.ReadLine());


for(int i=0; i<n; i++){
    basamakDegeri = pay/payda;
    pay %= payda;
}

Console.Write("Basamak degeri: {0}",basamakDegeri);