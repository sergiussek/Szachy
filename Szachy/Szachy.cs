using System;

namespace Szachy {
	class Szachy {
		static void Main(string[] args) {
            Szachownica szachownica = new Szachownica();

            Figura król = new Król('B', 2, Kolory.BIAŁY);
			Figura hetman = new Hetman('D', 4, Kolory.BIAŁY);
			Figura goniec = new Goniec('A', 1, Kolory.BIAŁY);
			Figura wieża = new Wieża('H', 1, Kolory.BIAŁY);

            szachownica['B', 1] = król.ToString();
            szachownica.PrintSzachownica();

			// testy
			Console.WriteLine(król.SprawdzRuch('B', 1)); // pion
			Console.WriteLine(król.SprawdzRuch('A', 1)); // poziom
			Console.WriteLine(król.SprawdzRuch('A', 1)); // ukos
			Console.WriteLine(król.SprawdzRuch('G', 1)); // zły ruch

			Console.WriteLine(hetman.SprawdzRuch('D', 8)); // pion
			Console.WriteLine(hetman.SprawdzRuch('A', 4)); // poziom
			Console.WriteLine(hetman.SprawdzRuch('F', 6)); // ukos
			Console.WriteLine(hetman.SprawdzRuch('A', 8)); // zły ruch

			Console.ReadKey();
		}
	}
}
