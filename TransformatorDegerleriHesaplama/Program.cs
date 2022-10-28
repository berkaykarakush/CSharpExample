double Vp, Ip, Np, Ns, Vs, Is, Ps;
Console.Write("Vp degerini giriniz: ");
Vp = Convert.ToDouble(Console.ReadLine());
Console.Write("Ip degerini giriniz: ");
Ip = Convert.ToDouble(Console.ReadLine());
Console.Write("Np degerini giriniz: ");
Np= Convert.ToDouble(Console.ReadLine());
Console.Write("Ns degerini giriniz: ");
Ns = Convert.ToDouble(Console.ReadLine());
Vs = Vp*Ns/Np;
Is = Ip*Np/Ns;
Ps = Vs*Is;
Console.Write("\nVs degeri: {0}\nIs degeri: {1}\nPs degeri: {2}",Vs, Is, Ps);
if (Vs>Vp)
    Console.Write("\nYukseltici");
else 
    Console.Write("\nDusurucu");