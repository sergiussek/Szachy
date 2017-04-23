using System;

namespace Szachy {
    public enum Kolory
    {
        BIAŁY,
        CZARNY
    };

    abstract class Figura {
        private string nazwa;
        private char x;
        private int y;
        private Kolory kolor;

        public char X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Kolory Kolor
        {
            get { return kolor; }
            set { kolor = value; }
        }

        public string Nazwa
        {
            get { return nazwa; }
            set { nazwa = value; }
        }


        public Figura(char x, int y, Kolory kolor)
        {
            X = x;
            Y = y;
			Kolor = kolor;
		}

		public string GetPozycjaString() {
			return $"{X}{Y}";
		}

		public string GetKolorString() {
            return Enum.GetName(typeof(Kolory), Kolor);
        }

		public override string ToString() {
			return $"Figura: {Nazwa}, kolor: {GetKolorString()}, pozycja: {GetPozycjaString()}";
		}

		public virtual bool SprawdzRuch(char x, int y) {
			int intX = ConvertPosition(x);

			if ((intX > 8 || intX < 1) || (y > 8 || y < 1)) {
				return false;
			}

			if (IsEqualPosition(x, y)) {
				return false;
			}

			return true;
		}

        public int ConvertPosition(char pos)
        {
            return (int)Char.ToUpper(pos) - 64;
        }

        public bool IsEqualPosition(int x, int y) {
			return X == x && Y == y;
		}
	}
}
