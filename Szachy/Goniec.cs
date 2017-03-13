using System;

namespace Szachy {
	class Goniec : Figura {
		public Goniec(object x, int y, int kolor) : base(x, y, kolor) {
			nazwa = "Goniec";
		}

		public override bool WykonajRuch(object _x, int y) {
			int x = ConvertPosition(_x);

			if (!base.WykonajRuch(x, y)) {
				return false;
			}

			int posX = GetX();
			int posY = GetY();

			int diffY = Math.Abs(y - posY);
			int diffX = Math.Abs(x - posX);

			// move diagonaly
			if (diffX == diffY) {
				return true;
			}

			return false;
		}
	}
}
