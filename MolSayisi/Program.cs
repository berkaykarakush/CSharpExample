double kutle, molekulAgirligi, mol;
Console.Write("Maddenin Kutlesini giriniz (m): ");
kutle = Convert.ToDouble(Console.ReadLine());
Console.Write("Maddenin Molekul Agirligini giriniz (ma): ");
molekulAgirligi= Convert.ToDouble(Console.ReadLine());
mol = kutle/molekulAgirligi;
Console.Write("Mol Sayisi: {0}",mol);