using System;

namespace Szachy {
	class Szachy {
		static void Main(string[] args) {
            Szachownica szachownica = Szachownica.SzachownicaObject;

            Figura król = WykonajFigure.Instancja(TypFigury.KRÓL, 'B', 2, Kolory.BIAŁY);
            Figura hetman = WykonajFigure.Instancja(TypFigury.HETMAN, 'D', 4, Kolory.BIAŁY);
            Figura goniec = WykonajFigure.Instancja(TypFigury.GONIEC, 'A', 1, Kolory.BIAŁY);
            Figura wieża = WykonajFigure.Instancja(TypFigury.WIEŻA, 'H', 1, Kolory.BIAŁY);

            szachownica[król, 'B', 1] = król.ToString();
            szachownica.WyswietlSzachownice();
            Console.WriteLine("Są " + szachownica.IlośćFigur() + " figury/a na szachownicy");

			Console.ReadKey();
		}
	}
}
