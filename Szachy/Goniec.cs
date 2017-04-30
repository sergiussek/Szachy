using System;

namespace Szachy {
	class Goniec : Figura {
		public Goniec(char x, int y, Kolory kolor)
            : base(x, y, kolor)
        {
            Nazwa = "Goniec";
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

            // move diagonaly
            if (diffX == diffY) {
				return true;
			}

			return false;
		}
	}
}
