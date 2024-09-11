using ConsoleApp1.Components.DataProviders.Extensions;
using ConsoleApp1.Data.Entities;
using ConsoleApp1.Data.Repositories;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.Components.DataProviders
{
    public class CarsProvider : ICarsProvider
    {
        private readonly IRepository<Car> _carsRepository;

        public CarsProvider(IRepository<Car> carsRepository)
        {
            _carsRepository = carsRepository;


        }
        public string AnonymousClass()
        {
            var cars = _carsRepository.GetAll();
            var columns = cars.Select(car => new
            {
                Ident = car.Id,
                ProdName = car.Name,
                SizeType = car.Type,
            });
            StringBuilder sb = new(1024);
            foreach (var car in columns)
            {

                sb.AppendLine($"{car.Ident} ");

                sb.AppendLine($" Color: {car.ProdName}");

                sb.AppendLine($"Cost: {car.SizeType}");
            }

            return sb.ToString();

        }

        public List<Car[]> ChunkCars(int size)
        {
            var cars = _carsRepository.GetAll();
            return cars.Chunk(size).ToList();
        }

        public List<string> DistinctAllColors()
        {
            var cars = _carsRepository.GetAll();
            return cars.Select(x => x.Color).Distinct().OrderBy(x => x).ToList();
        }

        public List<string> DistinctByColors()
        {
            var cars = _carsRepository.GetAll();
            return cars.Select(x => x.Color).OrderBy(x => x).ToList();
        }

        public List<Car> FilterCars(decimal minPrize)
        {
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
        }

        public Car FirstByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.First(x => x.Color == color);

        }

        public Car? FirstOrDefaultByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.FirstOrDefault(x => x.Color == color);
        }

        public Car FirstOrDefaultByColorWithDefault(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.FirstOrDefault(x => x.Color == color, new Car { Id = -1, Name = "NOT FOUND" });
        }

        public decimal GetMinPrizeOfCar()
        {
            var cars = _carsRepository.GetAll();
            var minprize = cars.Select(x => x.ListPrice).Min();
            return minprize;
        }

        public List<Car> GetSpecificColumns()
        {
            var cars = _carsRepository.GetAll();
            var columns = cars.Select(car => new Car
            {
                Id = car.Id,
                Name = car.Name,
                Type = car.Type,
            }).ToList();
            return columns;
        }

        public List<string> GetUniqueCarColors()
        {
            var cars = _carsRepository.GetAll();
            var colors = cars.Select(x => x.Color).Distinct().ToList();
            return colors;
        }

        public Car LastByColor(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.Last(x => x.Color == color);
        }

        public List<Car> OrderByColorAndName()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderByDescending(x => x.Color).ThenBy(x => x.Name).ToList();
        }

        public List<Car> OrderByColorAndNameDesc()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Color).ThenBy(x => x.Name).ToList();
        }

        public List<Car> OrderByName()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).ToList();
        }

        public List<Car> OrderByNameDesc()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderByDescending(x => x.Name).ToList();
        }

        public Car SingleById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.Single(x => x.Id == id);
        }

        public Car? SingleOrDefaultById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.SingleOrDefault(x => x.Id == id);
        }

        public List<Car> SkipCars(int howaMany)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).Skip(howaMany).ToList();

        }

        public List<Car> SkipCarsWhileNameStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).SkipWhile(x => x.Name.StartsWith(prefix)).ToList();
        }

        public List<Car> TakeCars(int howaMany)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).Take(howaMany).ToList();
        }

        public List<Car> TakeCars(Range range)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).Take(2..7).ToList();
        }

        public List<Car> TakeCarsWhileNameStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Name).TakeWhile(x => x.Name.StartsWith(prefix)).ToList();
        }

        public List<Car> WhereColorIs(string color)
        {
            var cars = _carsRepository.GetAll();
            return cars.ByColor("Red").ToList();
        }

        public List<Car> WhereStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars.Where(x => x.Name.StartsWith(prefix)).ToList();

        }

        public List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost)
        {
            var cars = _carsRepository.GetAll();
            return cars.Where(x => x.Name.StartsWith(prefix) && x.Standardcost > cost).ToList();
        }
    }
}
