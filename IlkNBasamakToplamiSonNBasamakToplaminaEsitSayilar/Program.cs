//1000-9999 arasi
for(int i=1; i<10; i++){
    for(int j=0; j<10; j++){
        for(int k=0; k<10; k++){
            for(int m=0; m<10; m++){
                if(i+j == k+m){
                    Console.WriteLine(1000*i+100*j+10*k+m);
                }
            }
        }
    }
}