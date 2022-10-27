double birinciDikKenar, ikinciDikKenar, hipotenus;
Console.Write("Birinci dik kenari giriniz(cm):");
birinciDikKenar = Convert.ToDouble(Console.ReadLine());
Console.Write("Ikinci dik kenari giriniz(cm):");
ikinciDikKenar = Convert.ToDouble(Console.ReadLine());
hipotenus = Math.Sqrt((Math.Pow(birinciDikKenar,2)+Math.Pow(ikinciDikKenar,2)));
Console.Write("\nHipotenus : {0}",hipotenus);