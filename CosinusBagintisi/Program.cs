const float pi = 3.14f;
double birinciKenar, ikinciKenar, aciDegeri, ucuncuKenar;
Console.Write("Birinci kenar degerini giriniz (cm):");
birinciKenar = Convert.ToDouble(Console.ReadLine());
Console.Write("Ikinci kenar degerini giriniz (cm):");
ikinciKenar= Convert.ToDouble(Console.ReadLine());
Console.Write("Aradaki aci degerini giriniz (derece):");
aciDegeri = Convert.ToDouble(Console.ReadLine());
ucuncuKenar = Math.Sqrt(Math.Pow(birinciKenar,2)+Math.Pow(ikinciKenar,2)-2*birinciKenar*ikinciKenar*Math.Cos(aciDegeri*pi/180));
Console.Write("\nUcuncu Kenar Degeri: {0}",ucuncuKenar);