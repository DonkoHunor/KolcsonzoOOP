using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolcsonzoOOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ujsag ujsag = new Ujsag("Menő újság",2023,11);
			Dvd dvd = new Dvd("Hiper menő dvd",420);
			Konyv konyv = new Konyv("Giga szuper könyv","Szer Zoltán", "81-7525-766-0");
			List<IKolcsonozheto> katalogus = new List<IKolcsonozheto>();
			katalogus.Add(ujsag);
			katalogus.Add(dvd);
			katalogus.Add(konyv);

			foreach (var k in katalogus)
			{
                Console.WriteLine(k.MegjelenitendoNev+"\n");
            }

            Console.WriteLine("------------------------------");


            List<Dvd> list = new List<Dvd>();
			Random rnd = new Random();
			for (int i = 0; i < 10; i++) 
			{
				list.Add(new Dvd("Legjobb film" + i, rnd.Next(90,151)));
			}

			list.Sort();

			foreach (Dvd d in list) 
			{
                Console.WriteLine(d.MegjelenitendoNev);
            }
			Console.ReadKey();
		}
	}
}
