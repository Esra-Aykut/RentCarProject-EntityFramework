using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car entity);
        void Update(Car entity);
        void Delete(Car entity);

        List<Car> GetAll();
        Car GetCarById(int id); 
        List<Car> GetCarsByBrandId(int Brandid);
        List<Car> GetCarsByColorId(int Colorid);

        List<CarDetailDto> GetCarDetails();

        
      
         


    }
}
