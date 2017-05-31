
namespace ChainofResponsibility
{
    public abstract class BazniArtikl
    {
        protected BazniArtikl NextHandler;

        public abstract int Handle(Artikl artikl);

        public void PostaviHendler(BazniArtikl nextHandler)
        {
            NextHandler = nextHandler;
        }
    }
}
