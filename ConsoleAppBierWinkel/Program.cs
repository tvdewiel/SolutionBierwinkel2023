// See https://aka.ms/new-console-template for more information
using BierWinkel;

Console.WriteLine("Hello, World!");
//Bier b1 = new Bier("palm", 1.05, Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.zes);
//Inventaris inventaris = new Inventaris();
//inventaris.VoegBierToe("palm", 1.05, Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, Setgrootte.zes);
//inventaris.VoegBierToe("rodenbach classic", 1.25, Bierkleur.Bruin, "palm", Biervolume.cl25, 5.2, Setgrootte.zes);
//inventaris.VoegBierToe("leffe bruin", 1.6, Bierkleur.Bruin, "leffe", Biervolume.cl33, 6.2, Setgrootte.zes);
//inventaris.VoegBierToe("duvel", 1.8, Bierkleur.Blond, "duvel moortgat", Biervolume.cl33, 8.5, Setgrootte.vier);
//Bier x = inventaris.SelecteerBier("palm");
//Console.WriteLine($"Bier:{x}");
//foreach(Bier y in inventaris.ZoekBier(b1)) Console.WriteLine($"Bier:{y}");
//Bier b1 = new Bier(1.05, "palm", Bierkleur.Amber, "palm", Biervolume.cl25, 5.2, 6);
//Bier b2 = new Bier(1.25, "rodenbach classic", "bruin", "palm", 25, 5.2, 6);
//Bier b3 = new Bier(1.6, "leffe bruin", Bierkleur.Bruin, "", null, null, 6);
//Bier b4 = new Bier(1.8, "duvel", "blond", "duvel moortgat", 33, 8.5, 4);
Bierspecificatie b1 = new Bierspecificatie(Bierkleur.Amber, "palm", Drankvolume.cl25, 5.2, "België");
Bierspecificatie b2 = new Bierspecificatie(Bierkleur.Bruin, "palm", Drankvolume.cl25, 5.2, "België");
Bierspecificatie b3 = new Bierspecificatie(Bierkleur.Bruin, "leffe", Drankvolume.cl33, 6.2, "België");
Bierspecificatie b4 = new Bierspecificatie(Bierkleur.Blond, "duvel moortgat", Drankvolume.cl33, 8.5, "België");
Wijnspecificatie w1 = new Wijnspecificatie(Wijnkleur.Rood, "Gato Negro", Drankvolume.cl75, 12.5, "Chili");
Inventaris inventaris = new Inventaris();
inventaris.VoegDrankToe( "palm",1.05, b1, Setgrootte.zes);
inventaris.VoegDrankToe("rodenbach classic",1.25, b2, Setgrootte.zes) ;
inventaris.VoegDrankToe("leffe bruin",1.6, b3, Setgrootte.zes);
inventaris.VoegDrankToe("duvel",1.8, b4, Setgrootte.vier);
inventaris.VoegDrankToe("Gato Negro - merlot",5.8, w1, Setgrootte.een);
//Drank x = inventaris.SelecteerDrank("palm");
//Console.WriteLine($"Drank:{x}");
//x = inventaris.SelecteerDrank("Gato Negro - merlot");
//Console.WriteLine($"Drank:{x}");
Bierspecificatie bierspec = new Bierspecificatie(Bierkleur.Bruin, "palm", null, null, "België");
List<Drank> ly = inventaris.ZoekDrank(bierspec);
foreach (Drank y in ly)
    Console.WriteLine($"Drank:{y}");
Console.WriteLine("------");
Wijnspecificatie wijnspec = new Wijnspecificatie(Wijnkleur.Rood, "Gato Negro", null, null, "Chili");
List<Drank> lz = inventaris.ZoekDrank(wijnspec);
foreach (Drank y in lz)
    Console.WriteLine($"Drank:{y}");
        