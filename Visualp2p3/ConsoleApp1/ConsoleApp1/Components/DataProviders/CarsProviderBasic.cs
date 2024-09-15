using ConsoleApp1.Data.Entities;
using ConsoleApp1.Data.Repositories;

namespace ConsoleApp1.Components.DataProviders
{
    public class CarsProviderBasic : ICarsProvider
    {
        private IRepository<Car> _carsRepository;

        public CarsProviderBasic(IRepository<Car> carsRepository)

        {
            _carsRepository = carsRepository;
        }

        public string AnonymousClass()
        {
            throw new NotImplementedException();
        }

        public List<string> DistinctAllColors()
        {
            throw new NotImplementedException();
        }

        public List<string> DistinctByColors()
        {
            throw new NotImplementedException();
        }

        public List<Car> FilterCars(decimal minPrize)
        {
            var cars = _carsRepository.GetAll();
            var list = new List<Car>();
            foreach (var car in cars)
            {
                if (car.ListPrice > minPrize)
                {
                    list.Add(car);
                }
            }
            return list;
        }

        public Car FirstByColor(string color)
        {
            throw new NotImplementedException();
        }

        public Car FirstOrDefaultByColor(string city)
        {
            throw new NotImplementedException();
        }

        public Car FirstOrDefaultByColorWithDefault(string city)
        {
            throw new NotImplementedException();
        }

        public decimal GetMinPrizeOfCar()
        {
            var cars = _carsRepository.GetAll();
            decimal ret = decimal.MaxValue;
            foreach (var car in cars)
            {
                if (car.ListPrice < ret)
                {
                    ret = car.ListPrice;
                }
            }
            return ret;
        }

        public List<Car> GetSpecificColumns()
        {
            throw new NotImplementedException();
        }

        public List<string> GetUniqueCarColors()
        {
            var cars = _carsRepository.GetAll();
            List<string> list = new();
            foreach (var car in cars)
            {
                if (!list.Contains(car.Color))
                {
                    list.Add(car.Color);
                }
            }
            return list;
        }

        public Car LastByColor(string color)
        {
            throw new NotImplementedException();
        }

        public List<Car> OrderByColorAndName()
        {
            throw new NotImplementedException();
        }

        public List<Car> OrderByColorAndNameDesc()
        {
            throw new NotImplementedException();
        }

        public List<Car> OrderByName()
        {
            throw new NotImplementedException();
        }

        public List<Car> OrderByNameDesc()
        {
            throw new NotImplementedException();
        }

        public Car SingleById(string id)
        {
            throw new NotImplementedException();
        }

        public Car SingleById(int id)
        {
            throw new NotImplementedException();
        }

        public Car SingleOrDefaultById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> SkipCars(int howaMany)
        {
            throw new NotImplementedException();
        }

        public List<Car> SkipCarsWhileNameStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        public List<Car> TakeCars(int howaMany)
        {
            throw new NotImplementedException();
        }

        public List<Car> TakeCars(Range range)
        {
            throw new NotImplementedException();
        }

        public List<Car> TakeCarsWhileNameStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        public List<Car> WhereColorIs(string color)
        {
            throw new NotImplementedException();
        }

        public List<Car> WhereStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        public List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost)
        {
            throw new NotImplementedException();
        }

        string ICarsProvider.AnonymousClass()
        {
            throw new NotImplementedException();
        }

        List<Car[]> ICarsProvider.ChunkCars(int size)
        {
            throw new NotImplementedException();
        }

        List<string> ICarsProvider.DistinctAllColors()
        {
            throw new NotImplementedException();
        }

        List<string> ICarsProvider.DistinctByColors()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.FilterCars(decimal minPrize)
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.FirstByColor(string color)
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.FirstOrDefaultByColor(string color)
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.FirstOrDefaultByColorWithDefault(string color)
        {
            throw new NotImplementedException();
        }

        decimal ICarsProvider.GetMinPrizeOfCar()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.GetSpecificColumns()
        {
            throw new NotImplementedException();
        }

        List<string> ICarsProvider.GetUniqueCarColors()
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.LastByColor(string color)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.OrderByColorAndName()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.OrderByColorAndNameDesc()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.OrderByName()
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.OrderByNameDesc()
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.SingleById(int id)
        {
            throw new NotImplementedException();
        }

        Car ICarsProvider.SingleOrDefaultById(int id)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.SkipCars(int howaMany)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.SkipCarsWhileNameStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.TakeCars(int howaMany)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.TakeCars(Range range)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.TakeCarsWhileNameStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.WhereColorIs(string color)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.WhereStartsWith(string prefix)
        {
            throw new NotImplementedException();
        }

        List<Car> ICarsProvider.WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost)
        {
            throw new NotImplementedException();
        }
    }
}
