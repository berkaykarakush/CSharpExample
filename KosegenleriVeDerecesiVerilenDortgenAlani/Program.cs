
double birinciKosegen, ikinciKosegen, aciDegeri, alan;
const float pi = 3.14f;
Console.Write("Birinci kosegen degerini giriniz (cm): ");
birinciKosegen = Convert.ToDouble(Console.ReadLine());
Console.Write("Ikinci kosegen degerini giriniz (cm): ");
ikinciKosegen = Convert.ToDouble(Console.ReadLine());
Console.Write("Aradaki aci degerini giriniz (derece): ");
aciDegeri = Convert.ToDouble(Console.ReadLine());
alan = birinciKosegen*ikinciKosegen*(Math.Sin(aciDegeri*pi/180))/2;
Console.Write("\nDortgenin Alani: {0}",alan);
