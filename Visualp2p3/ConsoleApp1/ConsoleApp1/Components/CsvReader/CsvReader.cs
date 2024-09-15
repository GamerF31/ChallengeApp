
using ConsoleApp1.Components.CsvReader.Models;
using ConsoleApp1.Components.CsvReader.Extensions;
namespace ConsoleApp1.Components.CsvReader
{
    public class CsvReader : ICsvReader
    {
        public List<Car> ProcessCars(string filepath)
        {
            if (!File.Exists(filepath)) 
            { 
                return new List<Car>();
            }
            var cars = File.ReadAllLines(filepath).Skip(1).Where(x => x.Length > 0).ToCar();

            return cars.ToList();
        }

        public List<Manufacturers> ProcessManufacturers(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Manufacturers>();
            }
            var manufacturers = File.ReadAllLines(filepath).Where(x => x.Length > 1).Select(x => {
                var columns = x.Split(',');
                return new Manufacturers()
                {
                    Name = columns[0],
                    Country = columns[1],
                    Year = int.Parse(columns[2])
                };
            });
            return manufacturers.ToList();
        }
    }
}
