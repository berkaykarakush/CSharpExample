int sayi, b, s=0;

Console.Write("Sayi degerini giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

b = sayi - 3;

for(int i=1; i<b; i++){
    for(int j=i; j<b; j++){
        for(int k=j; k<b; k++){
            for(int l=k; l<b; l++){
                if(sayi == i+j+k+l){
                    s+=1;
                    Console.WriteLine("{0},{1},{2},{3}",i,j,k,l);
                }
            }
        }
    }
}

