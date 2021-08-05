using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfCarDal : EfEntityRepositoryBase<Car, RentCarDBContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentCarDBContext context = new RentCarDBContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join cl in context.Colors on c.ColorId equals cl.ColorId

                             select new CarDetailDto
                             {
                                 //CarName, BrandName, ColorName, DailyPrice.
                                 Model = c.Model,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
