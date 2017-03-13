using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy {
	abstract class Figura {
		public enum Kolory : int {
			BIAŁY = 0,
			CZARNY = 1
		};

		public string nazwa;
		public int x;
		public int y;
		public int kolor;

		public Figura(object _x, int y, int kolor) {
			int x = ConvertPosition(_x);

			SetPozycja(x, y);
			SetKolor(kolor);
		}

		public string GetNazwa() {
			return nazwa;
		}

		public int GetX() {
			return x;
		}

		public int GetY() {
			return y;
		}

		public string GetPozycjaString() {
			// ASCII char
			int x = GetX() + 64;
			int y = GetY();

			return String.Format("{0}{1}", Convert.ToChar(x), y);
		}

		public int getKolor() {
			return kolor;
		}

		public string GetKolorString() {
			switch (getKolor()) {
				case (int) Kolory.BIAŁY:
					return "biały";
				case (int) Kolory.CZARNY:
					return "czarny";
			}

			return "";
		}

		public void SetPozycja(int x, int y) {
			this.x = x;
			this.y = y;
		}

		public void SetKolor(int kolor) {
			this.kolor = kolor;
		}

		public override string ToString() {
			return String.Format("Figura: {0}, kolor: {1}, pozycja: {2}", GetNazwa(), GetKolorString(), GetPozycjaString());
		}

		public virtual bool WykonajRuch(object _x, int y) {
			int x = ConvertPosition(_x);

			if (x > 8 || x < 1 || y > 8 || y < 1) {
				return false;
			}

			if (IsEqualPosition(x, y)) {
				return false;
			}

			return true;
		}

		public int ConvertPosition(object pos) {
			if (pos is char) {
				return (int) Char.ToUpper(Convert.ToChar(pos)) - 64;
			}
			
			return Convert.ToInt32(pos);
		}

		public bool IsEqualPosition(int x, int y) {
			return GetX() == x && GetY() == y;
		}
	}
}
