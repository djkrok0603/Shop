using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Shop.Сontrolers
{
    public class CarController : System.Web.Mvc.Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;


        }
        public System.Web.Mvc.ViewResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);

        }




    
    
    
    }
}
