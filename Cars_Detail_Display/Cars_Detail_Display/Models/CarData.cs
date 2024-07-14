using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cars_Detail_Display.Models
{
    public class CarData
    {
        private static List<Car> cars = new List<Car>();
        private static int nextId = 1;

        public static List<Car> GetAll()
        {
            return cars;
        }

        public static Car Get(int id)
        {
            return cars.FirstOrDefault(c => c.Id == id);
        }

        public static void Add(Car car)
        {
            car.Id = nextId++;
            cars.Add(car);
        }

        public static void Delete(int id)
        {
            var car = Get(id);
            if (car != null)
            {
                cars.Remove(car);
            }
        }
    }
}