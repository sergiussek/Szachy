using System;

namespace Szachy {
	class Wieża : Figura {
		public Wieża(object x, int y, int kolor) : base(x, y, kolor) {
			nazwa = "Wieża";
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

			// move horizontaly
			if (diffX == 0 && diffY != 0) {
				return true;
			}

			// move verticaly
			if (diffY == 0 && diffX != 0) {
				return true;
			}

			return false;
		}
	}
}
