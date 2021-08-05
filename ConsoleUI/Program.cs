using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        //Tüm CRUD operasyonlarını Car, Brand, Model nesneleri için test et.(Add, Update, Delete, Get, GetAll)
        //Car için + GetByCarId, GetCarsByBrandId, GetCarsByColorId, GetCarDetails

        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //GetCarDetailsTest();
            //AddCarTest();
            //AddBrandTest();
            ////GetAllCarTest();
            //UpdadeCarTest();
            //UpdadeBrandTest(brandManager);
            //GetAllBrandTest();
            //GetCarByIdTest();
            //GetCarsByBrandId();
            //DeleteBrandTest();
            GetCarDetailsTest();

        }

        //---------------------------------------------------
        //--------------------ADD----------------------------
        //---------------------------------------------------

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 9, ColorId = 6, DailyPrice = 288, Description = " 24 saat öncesine kadar ücretsiz iptal", Model = "XE", ModelYear = 2014 });
        }
        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "YYY" });
            //brandManager.Add(new Brand { BrandName="Suzuki" });

        }
        //private static void AddModelTest()



        //------------------------------------------------------
        //---------------------UPDATE---------------------------
        //------------------------------------------------------

        private static void UpdadeCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { CarId = 3003, BrandId = 5, ColorId = 7, ModelYear = 2020, DailyPrice = 150, Description="Manuel", Model="Civic" }); 
        }

        private static void UpdadeBrandTest(BrandManager brandManager)
        {
           brandManager.Update(new Brand { BrandId=1, BrandName="xxToyota" });  
        }

        //private static void AddModelTest()



        //------------------------------------------------------
        //---------------------DELETE---------------------------
        //------------------------------------------------------
        private static void DeleteCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { BrandId = 9 });
        }

         private static void DeleteBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandName = "Volvo"});  //  (((BrandId yapınca oluyo, Name yapınca olmuyo))) 
        }



        //------------------------------------------------------
        //------------------------GET---------------------------
        //------------------------------------------------------
        private static void GetCarByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            // Car car = carManager.GetCarById(2);
            // Console.WriteLine("CarId: " + car.CarId + " / DailyPrice: " + car.DailyPrice + "tl");

            //2.yol
            Console.WriteLine("Id'ye göre araba / günlük fiyatı");
            Console.WriteLine("CarId: " + carManager.GetCarById(2).CarId + " / DailyPrice: " + carManager.GetCarById(2).DailyPrice + "tl" );
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine("Girilen BrandId'ye göre araba fiyat listesi:");
            foreach (var c in carManager.GetCarsByBrandId(5))
            {
                Console.WriteLine(c.DailyPrice);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var cnt = 1;
            foreach (var c in carManager.GetCarDetails())
            {
                //Console.WriteLine( cnt + ". Araç : " + c.BrandName + " / " + c.Model + " / " + c.ColorName + " / " + c.DailyPrice);
                Console.WriteLine($" {cnt}. Araç : {c.BrandName} / {c.Model} / {c.ColorName} / {c.DailyPrice}");

                cnt++;
            }

        }


        //------------------------------------------------------
        //---------------------GETALL---------------------------
        //------------------------------------------------------

        private static void GetAllCarTest( )
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.CarId);
            }
        }

        private static void GetAllBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var b in brandManager.GetAll())
            {
                Console.WriteLine(b.BrandName);
            }
        }



    }
}





















