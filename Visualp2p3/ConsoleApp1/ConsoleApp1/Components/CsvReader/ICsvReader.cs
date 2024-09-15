
using ConsoleApp1.Components.CsvReader.Models;

namespace ConsoleApp1.Components.CsvReader
{
    public interface ICsvReader
    {
        List<Car> ProcessCars(string filepath);
        List<Manufacturers> ProcessManufacturers(string filepath);
    }
}
