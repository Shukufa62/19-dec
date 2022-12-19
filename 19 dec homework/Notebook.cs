using System;
namespace _19_dec_homework
{
	public class Notebook
	{
		public string Name;
		public string BrandName;
		public int Price;
		public void PriceCheck( int minprice, int maxprice)
		{
			

			
			if(Price > minprice && Price < maxprice)
			{
				Console.WriteLine(Name);
			}
			else
			{
				Console.WriteLine("qiymetlere uygun notebook tapilmadi ");
			}
			
			
		}
	}
}

