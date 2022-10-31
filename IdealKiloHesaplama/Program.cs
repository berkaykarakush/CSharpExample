double boy, kilo, bedenYuzeyAlani, bedenKutleIndeksi, idealKilo, yagsizBedenAgirligi;
char cinsiyet;
int yas;

Console.Write("Bilgilerinizi giriniz.\nBoy (cm): ");
boy = Convert.ToDouble(Console.ReadLine());
Console.Write("Kilo (kg): ");
kilo = Convert.ToDouble(Console.ReadLine());
Console.Write("Yas : ");
yas = Convert.ToInt32(Console.ReadLine());
Console.Write("Cinsiyet (e/k): ");
cinsiyet = Convert.ToChar(Console.ReadLine());

bedenYuzeyAlani = 0.20247*Math.Pow(boy,0.725)*Math.Pow(kilo,0.425);
bedenKutleIndeksi = kilo/Math.Pow(boy,2);

Console.WriteLine("Ideal Kilo hesaplama Yontemini seciniz.\n1-Yontem 1\n2-Yontem 2\n3-Yontem 3\n4-Yontem 4\n");
int sec = Convert.ToInt32(Console.ReadLine());

switch(sec){
    case 1:
        // method 1
        if(cinsiyet == 'k'){
            idealKilo = 45.5 + 2.3 *((boy*0.394)-60) ; //1 cm = 0.394 inch 
            Console.WriteLine("Ideal Kilo: {0}",idealKilo);
        }
        else{
            idealKilo = 50 + 2.3 * ((boy*0.394)-boy);
            Console.WriteLine("Ideal Kilo: {0}",idealKilo);
            
        }
        break;

    case 2:
        // method 2
        if(cinsiyet =='k'){     
            idealKilo = (boy - 100 +((double)yas/10))*0.8;
            Console.WriteLine("Ideal Kilo: {0}",idealKilo);
        }
        else{
            idealKilo = (boy-100+((double)yas/10))*0.9;
            Console.WriteLine("Ideal Kilo: {0}",idealKilo);
        }
        break;
    case 3:
        // method 3
        if(cinsiyet == 'k'){
            if(bedenKutleIndeksi<17.5){
                Console.WriteLine("Anoreksi, Asiri zayif, Yuksek risk");
            }
            else if(bedenKutleIndeksi>=17.5 && bedenKutleIndeksi<19.1){
                Console.WriteLine("Zayif");
            }
            
            else if(bedenKutleIndeksi>=19.1 && bedenKutleIndeksi<25.8){
                Console.WriteLine("Normal Kilolu");
            }
            
            else if(bedenKutleIndeksi>=25.9 && bedenKutleIndeksi<27.3){
                Console.WriteLine("Biraz fazla kilolu");
            }
            
            else if(bedenKutleIndeksi>=27.3 && bedenKutleIndeksi<32.3){
                Console.WriteLine("Fazla kilolu");
            }
            
            else if(bedenKutleIndeksi>=32.3 && bedenKutleIndeksi<34.9){
                Console.WriteLine("Cok fazla kilolu");
            }
            
            else if(bedenKutleIndeksi>=34.9 && bedenKutleIndeksi<40){
                Console.WriteLine("Saglik acisindan yuksek riskli kilolu");
            }
            
            else if(bedenKutleIndeksi>=40 && bedenKutleIndeksi<50){
                Console.WriteLine("Hastalikli bir sekilde asiri kilolu");
            }
            
            else if(bedenKutleIndeksi>=50 && bedenKutleIndeksi<60){
                Console.WriteLine("Super asiri kilolu");
            }
        }
        else{
            if(bedenKutleIndeksi<17.5){
                Console.WriteLine("Anoreksi, Asiri zayif, Yuksek risk");
            }
            else if(bedenKutleIndeksi>=17.5 && bedenKutleIndeksi<19.1){
                Console.WriteLine("Zayif");
            }
            else if(bedenKutleIndeksi>=19.1 && bedenKutleIndeksi<25.8){
                Console.WriteLine("Normal Kilolu");
            }
            else if(bedenKutleIndeksi>=25.9 && bedenKutleIndeksi<27.3){
                Console.WriteLine("Biraz fazla kilolu");
            }
            else if(bedenKutleIndeksi>=27.3 && bedenKutleIndeksi<32.3){
                Console.WriteLine("Fazla kilolu");
            }
            else if(bedenKutleIndeksi>=32.3 && bedenKutleIndeksi<34.9){
                Console.WriteLine("Cok fazla kilolu");
            }
            else if(bedenKutleIndeksi>=34.9 && bedenKutleIndeksi<40){
                Console.WriteLine("Saglik acisindan yuksek riskli kilolu");
            }
            else if(bedenKutleIndeksi>=40 && bedenKutleIndeksi<50){
                Console.WriteLine("Hastalikli bir sekilde asiri kilolu");
            }
            else if(bedenKutleIndeksi>=50 && bedenKutleIndeksi<60){
                Console.WriteLine("Super asiri kilolu");
            }
        }
        break;

    case 4:
        // method 4
        if(bedenKutleIndeksi <18.5){
            Console.WriteLine("Zayif");
        }
        else if(bedenKutleIndeksi>=18.5 && bedenKutleIndeksi<24.9){
            Console.WriteLine("Normal");
        }
        else if(bedenKutleIndeksi>=24.9 && bedenKutleIndeksi<29.9){
            Console.WriteLine("Fazla Kilolu");
        }
        else if(bedenKutleIndeksi>=29.9 && bedenKutleIndeksi<34.9){
            Console.WriteLine("I. Derece Obez");
        }
        else if(bedenKutleIndeksi>=34.9 && bedenKutleIndeksi<39.9){
            Console.WriteLine("II. Derece Obez");
        }
        else if(bedenKutleIndeksi>=39.9){
            Console.WriteLine("III. Derece Obez");
        }
        break;

    default: 
        Console.Write("Yanlis deger girdiniz.");
        break;
}

//yagsiz beden agirligi
if(cinsiyet == 'k'){
    yagsizBedenAgirligi = (0.65*boy)-50.74;
}
else{
    yagsizBedenAgirligi = (0.73*boy)-59.42;
}

//output
Console.WriteLine("Yagsiz Beden Agirligi: {0}",yagsizBedenAgirligi);
