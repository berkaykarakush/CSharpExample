//100-999 arasi
 
 for(int i=1; i<10; i++){
    for(int j=0; j<10; j++){
        for(int k=0; k<10; k++){
            if(i+j+k == 3){
                Console.WriteLine(100*i+10*j+k);
            }
        }
    }
 }