using System;
namespace _19_dec_classwork
{
	public class Car
	{

        public string Brand;
        public string Model;
        public double Price;
        public int Year;
        public int Millage;
        public int GlobalMillage;

        public void Drive(int km)
        {
            Millage += km;
            GlobalMillage += km;
        }

        public void ResetMillage()
        {
            Millage = 0;
        }

        public string GetInfo()
        {
            return $"Brand: {Brand} - Model: {Model} - Year: {Year} - Price:{Price} - GM: {GlobalMillage} - M:{Millage}";
        }
    }
}

