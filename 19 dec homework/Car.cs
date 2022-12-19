using System;
using System.Diagnostics;

namespace _19_dec_homework
{
	public class Car
	{
		public string Brand;
		public string Model;
		public int CurretnFuel;
		public int CurrentFuelFor1Km;
		public int Millage;
        public void Drive(int km)
        {
			int TotalFuelInneed = km * CurrentFuelFor1Km;
			if (TotalFuelInneed <= CurretnFuel)
			{
               
                    Millage += km;
                CurretnFuel -= TotalFuelInneed;
                Console.WriteLine(GetInfo());
            }
            else
            {
                Console.WriteLine("error");
            }
           

           
        }
        public string GetInfo()
        {
            return $"Brand: {Brand} - Model: {Model} - Currentfuel;{CurretnFuel} - CurrentFuelFor1Km:{CurrentFuelFor1Km} - M:{Millage}";
        }

    }
}

