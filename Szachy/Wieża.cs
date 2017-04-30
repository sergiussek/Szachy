using System;

namespace Szachy {
	class Wieża : Figura {
		public Wieża(char x, int y, Kolory kolor)
            : base(x, y, kolor)
        {
			Nazwa = "Wieża";
		}

		public override bool SprawdzRuch(char x, int y) {
			int intX = ConvertPosition(x);

			if (!base.SprawdzRuch(x, y)) {
				return false;
			}

			int posX = intX;
			int posY = y;

			int diffY = Math.Abs(y - posY);
			int diffX = Math.Abs(ConvertPosition(X) - posX);

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
