double yaricap, alan, hacim;
const float pi = 3.14f;
Console.Write("Kurenin yaricapi degerini giriniz (cm): ");
yaricap = Convert.ToDouble(Console.ReadLine());
alan = 4*pi*Math.Pow(yaricap,2);
hacim = (4*pi*Math.Pow(yaricap,3))/3;
Console.Write("\nKurenin Alani : {0}\nKurenin Hacmi : {1}",alan,hacim);
