﻿double volt, amper, fazAcisi, aktifGuc, reaktifGuc, gorunurGuc, gucFaktoru;
const float pi = 3.14f;
Console.Write("Volt cinsinden genlik degerini giriniz: ");
volt = Convert.ToDouble(Console.ReadLine());
Console.Write("Amper cinsinden genlik degerini giriniz: ");
amper = Convert.ToDouble(Console.ReadLine());
Console.Write("Derece cinsinden faz acisi degerini giriniz: ");
fazAcisi = Convert.ToDouble(Console.ReadLine());
fazAcisi = fazAcisi*pi/180;
gorunurGuc = volt * amper;
gucFaktoru = Math.Cos(fazAcisi);
aktifGuc = gorunurGuc * gucFaktoru;
reaktifGuc = gorunurGuc * Math.Sin(fazAcisi);
Console.Write("\nAktif Guc: {0}\nReaktif Guc: {1}\nGorunur Guc: {2}\nGuc Faktoru: {3}",aktifGuc, reaktifGuc, gorunurGuc,gucFaktoru);