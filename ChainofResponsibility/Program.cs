using System;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main()
        {
            int sifra = 0, krediti = 0;

            //Inicijalizacija objekata 
            var čokoladica = new artiklČokoladica();
            var sokić = new artiklSokić();
            var kava = new artiklKava();
            var kraj = new krajLanca();

            //Definiranje lanca odgovornosti
            čokoladica.PostaviHendler(sokić);
            sokić.PostaviHendler(kava);
            kava.PostaviHendler(kraj);

            do { //Glavni loop
                sifra = 0;
                Console.WriteLine("Za izlaz unesite 0!\n-------------");
                Artikl mojArtikl = new Artikl();
                mojArtikl.Sifra = 0;    //Za ispis cjenika sifra=0
                čokoladica.Handle(mojArtikl); // Ispis cjenika
                Console.WriteLine("-------------");

                do { 
                Console.WriteLine("Unesite kredite:");
                } while (!int.TryParse(Console.ReadLine(), out krediti));

                while (krediti > 0) //Loop za artikle
                    {
                        mojArtikl.Krediti = krediti;
                        do {
                            Console.WriteLine("Unesite šifru artikla:");
                        } while (!int.TryParse(Console.ReadLine(), out sifra));

                        mojArtikl.Sifra = sifra;

                        krediti = čokoladica.Handle(mojArtikl);
                        Console.WriteLine("Preostalo kredita: " + krediti);
                       }
                  } while (sifra > 0 );
        }
    }
}