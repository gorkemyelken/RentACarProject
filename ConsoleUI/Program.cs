using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
            //BrandTest();
            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
            Console.WriteLine(brandManager.GetById(1).Name);
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
            Console.WriteLine(colorManager.GetById(1).Name);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Description: " + car.CarName);
                Console.WriteLine("Brand: " + car.BrandName);
                Console.WriteLine("Color: " + car.ColorName);
                Console.WriteLine("Daily Price: " + car.DailyPrice);
                Console.WriteLine("-------------");
            }
            Console.WriteLine(carManager.GetById(1).Description);
        }
    }
}
