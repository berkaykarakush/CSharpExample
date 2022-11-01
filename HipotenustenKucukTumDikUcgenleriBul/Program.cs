int hipotenus;

Console.Write("Hipotenus: ");
hipotenus = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=hipotenus; i++){
    for(int j=i; j<=hipotenus; j++){
        double c = Math.Sqrt(Math.Pow(i,2)+Math.Pow(j,2));
        if((c<hipotenus) && (c == (int)c)){
            Console.Write("a: {0}, b:{1}, c:{2}\n",i,j,c);
        }
    }
}