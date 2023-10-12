using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Dvd : IKolcsonozheto, IComparable<Dvd>
	{
		private string cim;
		private int hosszPerc;

		public Dvd(string cim, int hosszPerc)
		{
			this.cim = cim;
			this.hosszPerc = hosszPerc;
		}

		public string MegjelenitendoNev { get => $"{this.cim} ({this.hosszPerc} perc)"; set => throw new NotImplementedException(); }
		public int MeddigKolcsonozheto { get => 7; set => throw new NotImplementedException(); }

		public int CompareTo(Dvd other)
		{
			return this.hosszPerc - other.hosszPerc;
		}
	}
}
