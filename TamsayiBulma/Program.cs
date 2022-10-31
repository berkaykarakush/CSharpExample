double sayi;

Console.Write("Bir sayi degerini giriniz: ");
sayi =Convert.ToDouble(Console.ReadLine());

if(sayi == Math.Round(sayi)){
    Console.Write("Tam sayidir.");
}
else{
    Console.Write("Tam sayi degildir.");
}