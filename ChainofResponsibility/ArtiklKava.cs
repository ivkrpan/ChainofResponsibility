using System;

namespace ChainofResponsibility
{
    public class artiklKava : BazniArtikl
    {
        public override int Handle(Artikl artikl)
        {
            // Ispisuje cijenu artikla
            if (artikl.Sifra == 0 && artikl.Krediti == 0)
            {
                Console.WriteLine("10: Kava, 3kn");
            }
            // Artikl je odabran
            if (artikl.Sifra == 10)
            {
                //Provjera kredita                
                if (artikl.Krediti >= 3)
                {
                    Console.WriteLine("Kupili ste kavu!");
                    return artikl.Krediti - 3;
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
