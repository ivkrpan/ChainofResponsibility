using System;

namespace ChainofResponsibility
{
    public class artiklSokić : BazniArtikl
    {
        public override int Handle(Artikl artikl)
        {

            // Ispisuje cijenu artikla
            if (artikl.Sifra == 0 && artikl.Krediti == 0)
            {
                Console.WriteLine("1: Sok, 4kn");
            }
            // Artikl je odabran
            if (artikl.Sifra == 1)
            {
                //Provjera kredita                
                if (artikl.Krediti >= 4)
                {
                    Console.WriteLine("Kupili ste sok!");
                    return artikl.Krediti - 4;
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
