using System;

namespace Szachy {
    public enum Kolory
    {
        BIAŁY,
        CZARNY
<<<<<<< HEAD
    }

    public enum TypFigury
    {
        GONIEC,
        HETMAN,
        KRÓL,
        WIEŻA
    }

    public abstract class Figura {

        public delegate void Delegat();
        public event Delegat Event;

        private Kolory kolor;
        private string nazwa;
        private char x;
        private int y;

        public char X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                if (Event != null) Event();
            }
=======
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
>>>>>>> origin/master
        }

        public int Y
        {
<<<<<<< HEAD
            get
            {
                return y;
            }
            set
            {
                y = value;
                if (Event != null) Event();
            }
=======
            get { return y; }
            set { y = value; }
>>>>>>> origin/master
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
<<<<<<< HEAD
            Event += OnEvent;
=======
>>>>>>> origin/master
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

        private void OnEvent()
        {
            Console.WriteLine($"{Nazwa} został/a przesunięty/a");
        }
	}
}
