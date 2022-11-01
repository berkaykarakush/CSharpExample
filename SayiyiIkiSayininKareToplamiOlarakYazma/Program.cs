int sayi;

Console.Write("Sayi degerini giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<=sayi; i++){
    for(int j=0; j<=sayi; j++){
        if(i*i+j*j == sayi){
            Console.Write("{0}-{1}\n",i,j);
        }
    }
}