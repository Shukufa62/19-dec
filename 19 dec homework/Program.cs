using System;

namespace _19_dec_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook ntb1 = new Notebook
            {
                Name = "pro",
                BrandName = "Macbook",
                Price = 4500
            };
            Notebook ntb2 = new Notebook
            {
                Name = "air",
                BrandName = "Macbook",
                Price = 2700

            };
           
            Notebook[] notebooks = { ntb1, ntb2};
            
            ntb2.PriceCheck(1500,4000);

            ////////////////////////////////////////////////////////


            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                CurretnFuel = 150,
                CurrentFuelFor1Km = 5,
                
            };
            car1.Drive(12);

            



        }
    }
}

