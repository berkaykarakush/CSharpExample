double kilo, boy, bazalMetabolizmaHizi=0;
int yas;
char cinsiyet;

Console.Write("Kilonuzu giriniz (kg): ");
kilo = Convert.ToDouble(Console.ReadLine());
Console.Write("Boyunuzu giriniz (cm): ");
boy = Convert.ToDouble(Console.ReadLine());
Console.Write("Yasinizi giriniz: ");
yas = Convert.ToInt32(Console.ReadLine());
Console.Write("Cinsiyet (e/h): ");
cinsiyet = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Hesaplamak istediginiz yontemi seciniz.\n1-Harris-Bennedict Denklemi\n2-Schofield Denklemi\n3-Owen Denklemi\n4-Mifflin-St Jeor Denklemi\n5-Dunya Saglik Orgutu Pratik Hesaplama Formulu\n6-Dunya Saglik Orgutu(WHOF/FAO/UNU)");
int sec = Convert.ToInt32(Console.ReadLine());

switch (sec)
{
    case 1: //Harris-Bennedict Denklemi
        if(cinsiyet == 'k'){
            bazalMetabolizmaHizi = 655.0955 + 9.5634*(kilo)+1.8496*boy-4.6756*yas;
        }
        else {
            bazalMetabolizmaHizi = 66.473 + 13.7516*kilo+5.0033*boy-6.775*yas;
        }
        break;
    case 2: //Schofield Denklemi
        if(cinsiyet == 'k'){
            if(yas>=10 && yas<18){
                bazalMetabolizmaHizi = 692.6 + 13.384*kilo;
            }
            else if(yas>=18 && yas<30){
                bazalMetabolizmaHizi = 486.6 + 14.818*kilo;

            }
            else if(yas>=30 && yas<60){
                bazalMetabolizmaHizi = 845.6 + 8.126*kilo;

            }
            else if(yas>=60){
                bazalMetabolizmaHizi = 658.5 + 9.082*kilo;
            }   
        }
        else{
            if(yas>=10 && yas<18){
                bazalMetabolizmaHizi = 658.2 + 17.686*kilo;
            }
            else if(yas>=18 && yas<30){
                bazalMetabolizmaHizi = 692.2 + 15.057*kilo;

            }
            else if(yas>=30 && yas<60){
                bazalMetabolizmaHizi = 873.1 + 11.472*kilo;

            }
            else if(yas>=60){
                bazalMetabolizmaHizi = 587.7 + 11.711*kilo;
            }
        }
        break;
    case 3: //Owen Denklemi
        if(cinsiyet == 'k'){
            bazalMetabolizmaHizi = 795 + 7.18*kilo;
        }
        else{
            bazalMetabolizmaHizi = 879 + 10.2*kilo;
        }
        break;
    case 4: //Mifflin-St Jeor Denklemi
        if(cinsiyet == 'k'){
            bazalMetabolizmaHizi = 9.99*kilo + 6.25*boy-4.92*yas-161;
        }
        else{
            bazalMetabolizmaHizi = 9.99*kilo + 6.25*boy-4.92*yas+5;
        }
        break;
    case 5: //Dunya Saglik Orgutu Pratik Hesaplama Formulu
        if(cinsiyet == 'k'){
            bazalMetabolizmaHizi = 22.8 *kilo;
        }
        else{
            bazalMetabolizmaHizi = 24*kilo;
        }
        break;
    case 6: //Dunya Saglik Orgutu(WHOF/FAO/UNU)
        if(cinsiyet == 'k'){
            if(yas>= 18 && yas<30){
                bazalMetabolizmaHizi = 496 + 14.7*kilo;
            }
            else if(yas>=30 && yas<60){
                bazalMetabolizmaHizi = 829 + 8.7*kilo;
            }
            else if(yas>=60){
                bazalMetabolizmaHizi = 596 + 10.5*kilo;
            }
        }
        else{
            if(yas>= 18 && yas<30){
                bazalMetabolizmaHizi = 679 + 15.3*kilo;
            }
            else if(yas>=30 && yas<60){
                bazalMetabolizmaHizi = 879 + 11.6*kilo;
            }
            else if(yas>=60){
                bazalMetabolizmaHizi = 487 + 13.5*kilo;
            }
        }
        break;
    
    default:
        Console.Write("Yanlis secim yaptiniz.");
        break;

}
Console.WriteLine("Bazal Metabolizma Hizi: {0:F2} kcal/gun",bazalMetabolizmaHizi); //{0:F2} .'dan sonra iki basamak goster
