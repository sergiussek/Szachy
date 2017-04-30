using System;

namespace Szachy {
	class Król : Figura {
		public Król(char x, int y, Kolory kolor) 
            : base(x, y, kolor)
        {
            Nazwa = "Król";
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
