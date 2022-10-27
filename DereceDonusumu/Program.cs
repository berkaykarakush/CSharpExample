double aciDerecesi, radyan, grad;
const double pi = 3.14;
Console.Write("Aci degerini giriniz (derece): ");
aciDerecesi = Convert.ToDouble(Console.ReadLine());
radyan = aciDerecesi*pi/180;
grad = aciDerecesi*200/180;
Console.WriteLine("Girilen derecenin Radyan degeri: {0}\nGirilen derecenin Gradyan degeri: {1}",radyan, grad);

