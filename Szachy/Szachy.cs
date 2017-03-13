using System;

namespace Szachy {
	class Szachy {
		static void Main(string[] args) {
			Figura król = new Król('B', 2, 0);
			Figura hetman = new Hetman('D', 4, 0);
			Figura goniec = new Goniec('A', 1, 0);
			Figura wieża = new Wieża('H', 1, 0);

			// testy
			Console.WriteLine(król.WykonajRuch('B', 1)); // pion
			Console.WriteLine(król.WykonajRuch('A', 2)); // poziom
			Console.WriteLine(król.WykonajRuch('A', 1)); // ukos
			Console.WriteLine(król.WykonajRuch('G', 1)); // zły ruch


			Console.WriteLine(hetman.WykonajRuch('D', 8)); // pion
			Console.WriteLine(hetman.WykonajRuch('A', 4)); // poziom
			Console.WriteLine(hetman.WykonajRuch('F', 6)); // ukos
			Console.WriteLine(hetman.WykonajRuch('A', 8)); // zły ruch

			Console.ReadKey();
		}
	}
}
