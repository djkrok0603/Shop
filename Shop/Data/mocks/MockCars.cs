using Shop.Data.interfaces;
using Shop.Data.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars    
    {
         private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car{ 
                        name = "Tesla",
                        shortDesc="Стиль и экологичность",
                        longDesc="Красивый автомобиль, полная экологичность, скорость, проходимость",
                        img="/img/tesla.jpg",
                        price=45000, 
                        isFavourite=true,
                        avaibale=true, 
                        Category= _categoryCars.AllCategories.First() },
                     new Car{
                        name = "BMW",
                        shortDesc="классика и скорость",
                        longDesc="Стиль, современность, проходимость, скорость",
                        img="/img/bmv.jpg",
                        price=10000,
                        isFavourite=false,
                        avaibale=true,
                        Category= _categoryCars.AllCategories.Last() },
                      new Car{
                        name = "Mercedes S",
                        shortDesc="Классика улучшенная временем",
                        longDesc="Стиль, современность, проходимость, скорость",
                        img="/img/mercedes.jpg",
                        price=37700,
                        isFavourite=true,
                        avaibale=true,
                        Category= _categoryCars.AllCategories.First() },
                       new Car{
                        name = "VW",
                        shortDesc="Безопастность и своременность",
                        longDesc="Конкурентный автомобиль, безопастность привыше всего...",
                        img="/img/VW.jpeg",
                        price=15000,
                        isFavourite=false,
                        avaibale=true,
                        Category= _categoryCars.AllCategories.Last() },
                };
            }
        }
        
                
        public IEnumerable<Car> getFavCars { get ; set ; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
