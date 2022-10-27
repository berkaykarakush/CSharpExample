double yaricap, aciDegeri, alan;
const float pi = 3.14f;
Console.Write("Yaricap degerini giriniz(cm): ");
yaricap = Convert.ToDouble(Console.ReadLine());
Console.Write("Aci degerini giriniz (derece) :");
aciDegeri = Convert.ToDouble(Console.ReadLine());
alan = (aciDegeri*pi*Math.Pow(yaricap,2))/360;
Console.Write("Alan degeri : {0}",alan);