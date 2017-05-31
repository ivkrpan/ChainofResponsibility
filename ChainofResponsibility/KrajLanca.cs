using System;

namespace ChainofResponsibility
{
    public class krajLanca : BazniArtikl
    {
        public override int Handle(Artikl artikl)
        {
            if (artikl.Sifra == 0)
            {
                return 0; // Zavrsi cjenik bez exceptiona
            }
            else
            {
                Console.WriteLine("Artikl ne postoji!");
                return artikl.Krediti;
            }

        }
    }
}
