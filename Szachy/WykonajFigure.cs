using System;

namespace Szachy
{
    public static class WykonajFigure
    {
        public static Figura Instancja(TypFigury figura, char X, int Y, Kolory kolor)
        {
            Figura f = null;

            switch (figura)
            {
                case TypFigury.GONIEC:
                    {
                        f = new Goniec(X, Y, kolor);
                        break;
                    }
                case TypFigury.HETMAN:
                    {
                        f = new Hetman(X, Y, kolor);
                        break;
                    }
                case TypFigury.KRÓL:
                    {
                        f = new Król(X, Y, kolor);
                        break;
                    }
                case TypFigury.WIEŻA:
                    {
                        f = new Wieża(X, Y, kolor);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("figura", "Nie ma takiego typu figury :(");
                    }
            }

            return f;
        }
    }
}
