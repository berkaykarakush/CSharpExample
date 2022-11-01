int s;

Console.Write("3i + 5j = S\nS degerini giriniz: ");
s = Convert.ToInt32(Console.ReadLine());

for(int i=0; i<=s/3; i++){
    for(int j=0; j<=s/5; j++){
        if(s == 3*i+5*j){
            Console.Write("{0},{1}\n",i,j);
        }
    }
}