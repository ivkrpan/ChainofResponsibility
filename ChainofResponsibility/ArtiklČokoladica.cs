using System;

namespace ChainofResponsibility
{
    public class artiklČokoladica : BazniArtikl
    {
        public override int Handle(Artikl artikl)
        {
            // Ispisuje cijenu artikla
            if (artikl.Sifra == 0 && artikl.Krediti == 0)
            {
                Console.WriteLine("2: Čokoladica, 5kn");
            }
            // Artikl je odabran
            if (artikl.Sifra == 2)
            {
                //Provjera kredita                
                if (artikl.Krediti >= 5)
                {
                    Console.WriteLine("Kupili ste čokoladicu!");
                    return artikl.Krediti - 5;
                }
                else
                {
                    Console.WriteLine("Nemate dovoljno kredita!");
                    return artikl.Krediti;
                }
            }
            // Poziv na sljedeći handler
            return NextHandler.Handle(artikl);
        }
    }

}
