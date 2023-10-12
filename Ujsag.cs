using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Ujsag : IKolcsonozheto
	{
		private string cim;
		private int kiadasEv;
		private int kiadasHet;

		public Ujsag(string cim, int kiadasEv, int kiadasHet)
		{
			this.cim = cim;
			this.kiadasEv = kiadasEv;
			this.kiadasHet = kiadasHet;
		}

		public string MegjelenitendoNev { get => $"{this.cim} {this.kiadasEv}/{this.kiadasHet}."; set => throw new NotImplementedException(); }
		public int MeddigKolcsonozheto { get => 0; set => throw new NotImplementedException(); }
	}
}
