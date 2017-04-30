using System;

namespace Szachy {
	class Hetman : Figura {
		public Hetman(char x, int y, Kolory kolor)
            : base(x, y, kolor)
        {
            Nazwa = "Hetman";
		}

		public override bool SprawdzRuch(char x, int y) {
			int intX = ConvertPosition(x);

			if (!base.SprawdzRuch(x, y)) {
				return false;
			}

            int posX = intX;
            int posY = y;

            int diffY = Math.Abs(Y - posY);
            int diffX = Math.Abs(ConvertPosition(X) - posX);

            // move horizontaly
            if (diffX == 0 && diffY != 0) {
				return true;
			}

			// move verticaly
			if (diffY == 0 && diffX != 0) {
				return true;
			}

			// move diagonaly
			if (diffX == diffY) {
				return true;
			}

			return false;
		}
	}
}
