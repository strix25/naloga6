using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga2
{

    public enum Spol { moški, ženski };
    public enum Prednosti { wifi, TV, klima, parkirišče, bazen };
    public enum Kajenje { da, ne };
    public enum BBalkon { da, ne};

    class Program
    {

        static void Main(string[] args)
        {
            //Prednosti[] polje = {Prednosti.wifi, Prednosti.klima,Prednosti.TV };

            //Apartma potato2 = new Apartma()
            //{
            //    Naziv = "ppotato",
            //    Destinacija = new Destinacija{ Kraj = "potato", Drzava = "Slovenija" },
            //    Cena = 10m,
            //    SteviloProstihMest = 1,
            //    SteviloPostelj = 1,
            //    DovoljenoKajenje = false,
            //    Prednosti = polje
            //};
            //Console.WriteLine(potato2.Prednosti);
            //potato2.izpis();

            //Apartma delo = new Apartma(naziv: "nekaj",destinacija:new Destinacija { Drzava = "Slovenija" }, cena:10m, steviloProstihMest:1, steviloPostelj:1, dovoljenoKajenje:true, elements:polje);
            //Console.WriteLine(delo.Cena);
            //Console.WriteLine(delo.SteviloPostelj);

            //delo.IzpisPolja();
            //Console.WriteLine(delo.vrniCenoZDoplacili());

            //Krizarjenje pot2 = new Krizarjenje(naziv: "krizarjenje 123", destinacija: new Destinacija { Drzava = "Slovenija" }, cena: 1022m, steviloProstihMest: 1,balkon: true, dodatnoLezisce: 1, steviloKabin:10 );
            //Console.WriteLine(pot2.vrniCenoZDoplacili());
            //pot2.izpis();

            //Popotnik janez = new Popotnik()
            //{
            //    Ime = "Nejc",
            //    Priimek = "Novak",
            //    Spol = Spol.moški,
            //    RojstniDatum = DateTime.Today,
            //    ElektronskiNaslov = "mail"
            //};
            //janez.izpis();

            //Vodic vodic1 = new Vodic()
            //{
            //    Ime = "Joze",
            //    Priimek = "Novak",
            //    Spol = Spol.moški,
            //    RojstniDatum = DateTime.Today,
            //    KontaktnaStevilka="12.123-123",
            //    StevilkaLicence=1234212
            //};
            //vodic1.RojstniDatum = DateTime.Now;
            //vodic1.izpis();

            //Izlet izlet1= new Izlet()
            //{
            //    Naziv = "ppotato",
            //    Destinacija = new Destinacija { Kraj = "potato", Drzava = "Slovenija" },
            //    Cena = 10m,
            //    SteviloProstihMest = 1,
            //    ZbirnoMesto="nekje",
            //    Vodic="Nekdo"
            //};
            //izlet1.izpis();

            // Create your ship with x number of rooms
            //var ladja = new Krizarjenje(naziv: "krizarjenje 123", destinacija: new Destinacija { Drzava = "Slovenija" }, cena: 1022m, steviloProstihMest: 1, balkon: true, dodatnoLezisce: 1, steviloKabin: 10, odhodi:new Termin[5]);

            //// Now you can create your trip using Ship's number of rooms
            //var izlet = new Termin(datumOdhoda:DateTime.Now, steviloKabin:ladja.SteviloKabin, trajanje:99);

            //ladja.DodajTerminZaOdhod(izlet);


            //////Oseba oseba1 = new Oseba("Damjan", "Oslaj", Spol.moški, DateTime.Today);
            //////Oseba oseba2 = new Oseba("Joze", "Neka", Spol.moški, DateTime.Today);
            //////Console.WriteLine("Sta osebi enaki ? : " + oseba1.Equals(oseba2));

            //////Popotnik popotnik1 = new Popotnik("nekaj@mail.com", "ime", "priimek");
            //////Popotnik popotnik2 = new Popotnik("nekaj@mail.com", "ime", "priimek");
            //////Popotnik popotnik3 = new Popotnik("nekaj@mail.com", "ime", "priimek");

            //////Krizarjenje krizarjenje1 = new Krizarjenje(true, 1, 10);
            //////Termin termin1 = new Termin(DateTime.Now, 5, 5);
            //////krizarjenje1.DodajTerminZaOdhod(termin1);

            //////krizarjenje1.dodajPopotnika(krizarjenje1.Odhodi[0], popotnik1);
            //////krizarjenje1.dodajPopotnika(krizarjenje1.Odhodi[0], popotnik2);
            //////krizarjenje1.dodajPopotnika(krizarjenje1.Odhodi[0], popotnik3);

            //////krizarjenje1.odstraniPopotnika(krizarjenje1.Odhodi[0], popotnik3);

            //////Console.WriteLine("Odhod krizarjenja bo: " + krizarjenje1.VrniOdhod(0).DatumOdhoda);
            //////Console.WriteLine("Trenutno število odhodov je: " + krizarjenje1.VrniSteviloOdhodov());

            //##############################################################
            ////#################### naloga 5 ##############################
            //##############################################################

            ////Destinacija destinacija1 = new Destinacija("Stockholm", "Švedska");
            ////Popotnik popotnikDamjan = new Popotnik("Damjan", "Oslaj", "nekaj4@mail.com");
            ////Krizarjenje OnlyWest = new Krizarjenje(true, 1, 10);
            ////Console.WriteLine("Krizarka :{0},Popotnik: {1},destinacija: {2}-{3}", OnlyWest.Naziv, popotnikDamjan.Ime, destinacija1.Drzava, destinacija1.Kraj);

            //////Nekaj popotnikov
            ////Popotnik popotnikJoze = new Popotnik("Joze@mail.com", "Priimek1", "Joze");
            ////Popotnik popotnikFranc = new Popotnik("Franc@mail.com", "Priimek2", "Franc");
            ////Popotnik popotnikJanez = new Popotnik("Janez@mail.com","Priimek3" , "Janez");

            //////Termin križarke Only-West
            ////DateTime datumOdhoda = new DateTime(2017, 6, 12);
            ////List<Termin> Termini = new List<Termin>();
            ////Termini.Add(new Termin(datumOdhoda, 12, OnlyWest.SteviloKabin));
            ////Termini.Add(new Termin(datumOdhoda, 12, OnlyWest.SteviloKabin));


            //////Dodali smo 2 odhoda na križarko "Only-West"
            ////OnlyWest.Odhodi.Add(Termini[0]);
            ////OnlyWest.DodajTerminZaOdhod(Termini[1]);  //OnlyWest.odhodi.Add(termin2);

            //////Izpis število odhodov na križarki "Only-West"
            ////Console.WriteLine("Na križarki {0} je {1} število odhodov ", OnlyWest.Naziv, OnlyWest.VrniSteviloOdhodov());

            //////Dodamo potnika na dolocen termin
            ////OnlyWest.dodajPopotnika(OnlyWest.VrniOdhod(1), popotnikFranc);
            ////OnlyWest.dodajPopotnika(OnlyWest.VrniOdhod(1), popotnikJanez);
            //////Izpis potnikov v odhodu št.1
            ////Console.WriteLine("Na odhodu {0}, so popotniki:", OnlyWest.VrniOdhod(1).DatumOdhoda);
            ////foreach (var popotniki in OnlyWest.Odhodi[1].SeznamPrijavljenihOseb)
            ////{
            ////    Console.WriteLine(popotniki.Key);
            ////}
            ////Console.WriteLine();

            ////Console.WriteLine("Število terminov, na katerih ni potnikov:{0}", OnlyWest.VrniTermineBrezPotnikov().Count);

            //////Odstranimo termin[0] v odhodih
            ////OnlyWest.OdstraniTermin(Termini[0]);
            ////Console.WriteLine("Odstranili smo termin {0}, število trenutnih terminov je: {1}", Termini[0].DatumOdhoda, OnlyWest.VrniSteviloOdhodov());

            //////dodali smo 2 termina
            ////Termini.Add(new Termin(new DateTime(2017, 5, 30), 12, OnlyWest.SteviloKabin));
            ////OnlyWest.DodajTerminZaOdhod(Termini[0]);
            ////OnlyWest.DodajTerminZaOdhod(Termini[2]);

            ////Console.WriteLine("Najkasnejsi termin:{0}", OnlyWest.VrniNajkasnejsiTermin().DatumOdhoda);


            ////Dictionary<string, Popotnik> openWith = new Dictionary<string, Popotnik>();


            ////Console.WriteLine("##############################");
            //////seznam oseb v katerega shranimo 4 random popotnike, 
            //////izpis vse osebe ki so zenske, osebo ki ima dolocen email, osebe rojene med dvema datumoma
            ////Seznam nekaj = new Seznam();

            ////nekaj.Popotniki = new List<Popotnik>();

            ////Popotnik p1 = new Popotnik("Joze", "Priimek1", "Joze@mail.com");
            ////Popotnik p2 = new Popotnik("Franc", "Priimek2", "Franc@mail.com");
            ////Popotnik p3 = new Popotnik("Janez", "Priimek3", "Janez@mail.com");
            ////Popotnik p4 = new Popotnik("Nekdo", "Priimek3", "nekdo@mail.com");

            ////nekaj.Popotniki.Add(p1);
            ////nekaj.Popotniki.Add(p2);
            ////nekaj.Popotniki.Add(p3);
            ////nekaj.Popotniki.Add(p4);

            ////nekaj.osebaZMailom("Janez@mail.com");

            //##############################################################
            //#################### naloga 6 ################################
            //##############################################################
            
            Ponudba.readfromfile();



           

            List<Oddih> itemToRemove = Ponudba.itemlist.FindAll(x => x.Destinacija.Drzava.Contains("Slovenija"));
            

            foreach (object o in itemToRemove)
            {
                Console.WriteLine(o);
            }

            Ponudba.itemlist.RemoveAll(x => x.Destinacija.Drzava.Contains("Slovenija"));
            

            //samo izpise vse z lista 
            foreach (object os in Ponudba.itemlist)
            {
                Console.WriteLine(os);
            }

            Console.WriteLine("##############");

            //Med Oddihi poiščite tistega z najdražjo ceno in ga odstranite. Za iskanje uporabite lambda izraz. Najden objekt pri tem tudi izpišite.
            var maxObject = Ponudba.itemlist.OrderByDescending(item => item.Cena).First();
            Console.WriteLine(maxObject);
            Ponudba.itemlist.Remove(maxObject);

            //samo izpise vse z lista 
            foreach (object os in Ponudba.itemlist)
            {
                Console.WriteLine(os);
            }

            Console.WriteLine("#############");

            //dodajte nov apartma
            Apartma delo = new Apartma(naziv: "nekaj", destinacija: new Destinacija { Drzava = "Slovenija" }, cena: 10, steviloProstihMest: 1, steviloPostelj: 1, dovoljenoKajenje: Kajenje.da);
            Ponudba.itemlist.Add(delo);

            foreach (object os in Ponudba.itemlist)
            {
                Console.WriteLine(os);
            }

            Console.WriteLine("#######vsaj eno prosto mesto ######");

            //Prebrano ponudbo ustrezno razporedite v dva podseznama. Eden naj vsebuje vse ponudbe, ki imajo na voljo
            //še vsaj eno prosto mesto, drug pa ostale, ki jih več nimajo. Oba podseznama tudi sortirajte po ceni.
            List<Oddih> vsajEnoMesto = new List<Oddih>();
            List<Oddih> nicProstihMest = new List<Oddih>();

            vsajEnoMesto = Ponudba.itemlist.Where(x => x.SteviloProstihMest > 0)
                         .ToList();

            foreach (object os in vsajEnoMesto)
            {
                Console.WriteLine(os);
            }

            Console.WriteLine("######Nic prostih mest#######");

            nicProstihMest = Ponudba.itemlist.Where(x => x.SteviloProstihMest == 0)
                         .ToList();

            foreach (object os in nicProstihMest)
            {
                Console.WriteLine(os);
            }

            Console.WriteLine("#############");
            //Ustvarite novo datoteko seznamPonudbeIzhod.csv, v katero zapišete samo ponudbe, katerih cena je nižja od 1500€.

            using (var file = File.CreateText("izhod.csv"))
            {
                file.WriteLine("Naziv, Destinacija, cena");
                foreach (var arr in Ponudba.itemlist)
                {
                    file.WriteLine(string.Join(",", arr));
                }
            }
            //linq File.WriteAllLines("text.txt", Ponudba.itemlist.Select(x => string.Join(",", x)));

            Console.WriteLine("#############");
            //S pomočjo lambda izraza izračunajte povprečno ceno Oddihov, ter ga izpišite v glavnem programu.
            var potat = Ponudba.itemlist.Average(item => item.Cena);
            Console.WriteLine(potat);

            Console.ReadLine();
        }
    }
}
