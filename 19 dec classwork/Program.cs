using System;
using System.Runtime.ConstrainedExecution;

namespace _19_dec_classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hmn11 = new Human
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                
            };

            Console.WriteLine(hmn11.GetFullname());



            Car car1 = new Car
            {
                Brand = "Toyota",
                Model = "Prius",
                Price = 50000,
                Year = 2010
            };

            car1.Drive(30);
            car1.Drive(15);
            car1.ResetMillage();

            Console.WriteLine(car1.GetInfo());
            
        static double CalcAvg(Car[] arr)
        {
            double sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Price;
            }

            return sum / arr.Length;
        }

        }
    }
}

