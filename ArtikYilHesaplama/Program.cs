int yil;

Console.Write("Yil degerini giriniz: ");
yil = Convert.ToInt32(Console.ReadLine());

if((yil % 4 ==0) && ((yil % 100 != 0) || (yil % 400 == 0))){
    Console.Write("{0} degeri bir artik yildir.",yil);
}
else{
    Console.Write("{0} degeri bir artik yil degildir.",yil);
}