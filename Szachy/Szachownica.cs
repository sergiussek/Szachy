using System;

namespace Szachy {
    sealed class Szachownica
    {
        private string[,] szachownica;

        public Szachownica()
        {
            szachownica = new string[8, 8];
		}

        public string this[char x, int y]
        {
            get
            {
                return szachownica[x - 65, y];
            }
            set
            {
                szachownica[x - 65, y] = value;
            }
        }

        public void PrintSzachownica()
        {
            int limit = (int) Math.Sqrt(szachownica.Length);

            for (int i = 0; i < limit ; i++)
            {
                for(int j = 0; j < limit; j++)
                {
                    if (!string.IsNullOrEmpty(szachownica[i, j]))
                    {
                        Console.WriteLine(szachownica[i, j] + "\n");
                    }
                }
            }
        }
	}
}
