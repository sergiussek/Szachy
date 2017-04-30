using System;

namespace Szachy {
    public sealed class Szachownica
    {
        private static Szachownica szachownica = new Szachownica();

        public static Szachownica SzachownicaObject
        {
            get
            {
                return szachownica;
            }
        }

        private const int rozmiarSzachownicy = 8;

        private string[,] szachownicaArray;

        public string[,] SzachownicaArray
        {
            get
            {
                return szachownicaArray;
            }
        }

        static Szachownica() { }

        private Szachownica()
        {
            szachownicaArray = new string[rozmiarSzachownicy, rozmiarSzachownicy];
		}

        public string this[Figura f, char x, int y]
        {
            get
            {
                return SzachownicaArray[x - 65, y];
            }
            set
            {
                SzachownicaArray[x - 65, y] = value;
                f.X = x;
                f.Y = y;
            }
        }

        public void WyswietlSzachownice()
        {
            int limit = rozmiarSzachownicy;

            for (int i = 0; i < limit ; i++)
            {
                for(int j = 0; j < limit; j++)
                {
                    if (!string.IsNullOrEmpty(szachownicaArray[i, j]))
                    {
                        Console.WriteLine(szachownicaArray[i, j] + "\n");
                    }
                }
            }
        }
	}

    public static class SzachownicaRozszerzenie
    {
        public static int IlośćFigur(this Szachownica sz)
        {
            string[,] array = sz.SzachownicaArray;
            int count = 0;
            foreach(var s in array)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
