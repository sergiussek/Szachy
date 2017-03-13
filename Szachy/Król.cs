using System;

namespace Szachy {
	class Król : Figura {
		public Król(object x, int y, int kolor) : base(x, y, kolor) {
			nazwa = "Król";
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

			// one move horizontaly
			if (diffX == 1 && diffY == 0) {
				return true;
			}

			// one move verticaly
			if (diffY == 1 && diffX == 0) {
				return true;
			}

			// one move diagonaly
			if (diffX == 1 && diffY == 1) {
				return true;
			}

			return false;
		}
	}
}
