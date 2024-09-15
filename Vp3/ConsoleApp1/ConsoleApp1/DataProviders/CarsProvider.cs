
using ConsoleApp1.DataProviders;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositories;
using System.Drawing;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApp1.DataProviders
{
    public class CarsProvider : ICarsProvider
    {
        private readonly IRepository<Cars> _carsRepository;

        public CarsProvider(IRepository<Cars> carsRepository)
        {
            _carsRepository = carsRepository;


        }

        public decimal GetMinPrizeOfCar()
        {
            var cars = _carsRepository.GetAll();
            var minprize = cars.Select(x => x.Price).Min();
            return minprize;
        }


        public List<Cars> OrderByName()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Model).ToList();
        }

        public List<Cars> OrderByNameDesc()
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderByDescending(x => x.Model).ToList();
        }

        public Cars SingleById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.Single(x => x.Id == id);
        }

        public Cars? SingleOrDefaultById(int id)
        {
            var cars = _carsRepository.GetAll();
            return cars.SingleOrDefault(x => x.Id == id);
        }

        public List<Cars> SkipCars(int howaMany)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Model).Skip(howaMany).ToList();

        }

        public List<Cars> TakeCars(Range range)
        {
            var cars = _carsRepository.GetAll();
            return cars.OrderBy(x => x.Model).Take(2..7).ToList();
        }
        public List<Cars> WhereStartsWith(string prefix)
        {
            var cars = _carsRepository.GetAll();
            return cars.Where(x => x.Model.StartsWith(prefix)).ToList();

        }



    }
}
