using ConsoleApp1.Components.CsvReader;
using ConsoleApp1.Components.DataProviders;
using ConsoleApp1.Data.Entities;
using ConsoleApp1.Data.Repositories;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ConsoleApp1
{
    public class App : IApp
    {
        private readonly ICsvReader _csvReader;

        public App(ICsvReader csvReader)
        {
            _csvReader = csvReader;
        }
        public void Run()
        {
            CreateXml();
            QueryXml();
        }
        private static void QueryXml()
        {
            var document = XDocument.Load("fuel.xml");
            var names = document.Element("Cars")?.
                Elements("Car").
                Select(x => x.Attribute("Name")?.Value); 

            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }


        private void CreateXml()
        {
            var records = _csvReader.ProcessCars("Resources\\Files\\fuel.csv");

            var document = new XDocument();

            var cars = new XElement("Cars", records.Select(x => new XElement("Car",
                new XAttribute("Name", x.Name),
                new XAttribute("Combined",x.Combined),
                new XAttribute("Manufacturer", x.Manufacturer))));
            document.Add(cars);
            document.Save("fuel.xml");
        }
    }
}


/*
 * private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Car> _carsRepository;
        private readonly ICarsProvider _carsProvider;

        public App(IRepository<Employee> employeesRepository, IRepository<Car> carsRepository, ICarsProvider carsProvider)
        {
            _employeeRepository = employeesRepository;
            _carsRepository = carsRepository;
            _carsProvider = carsProvider;
        }
        public void Run()
        {
            Console.WriteLine("I'm here in Run() method");

            var employees = new[]
            {
                new Employee { FirstName = "Adam"},
                new Employee { FirstName = "Przemek"},
                new Employee { FirstName = "Patryk"}

            };
            foreach (var employee in employees)
            {
                _employeeRepository.Add(employee);
            }
            _employeeRepository.Save();
            //reading
            var items = _employeeRepository.GetAll();
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            //cars
            var cars = GenerateSampleCars();
            foreach(var car in cars)
            {
                _carsRepository.Add(car);
            }

            foreach(var car in _carsProvider.FilterCars(1000))
            {
                Console.WriteLine(car);
            }
            Console.WriteLine();
            Console.WriteLine("GetUniqueCarColors");
            foreach(var item in _carsProvider.GetUniqueCarColors())
            { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine("GetMinimumPriceOfAllCars");
            Console.WriteLine(_carsProvider.GetMinPrizeOfCar());
            Console.WriteLine();
            Console.WriteLine("GetSpecificColumns");
            foreach (var item in _carsProvider.GetSpecificColumns())
            { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("AnonymousClassInString");
            Console.WriteLine(_carsProvider.AnonymousClass());

            Console.WriteLine();
            Console.WriteLine("OrderByName");
            foreach(var item in _carsProvider.OrderByName()) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("OrderByNameDescending");
            foreach (var item in _carsProvider.OrderByNameDesc()) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("OrderByColorAndName");
            foreach (var item in _carsProvider.OrderByColorAndName()) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("WhereStartsWith A");
            foreach (var item in _carsProvider.WhereStartsWith("A")) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("WhereStartsWith A");
            Console.WriteLine(_carsProvider.FirstByColor("Red"));

            Console.WriteLine();
            Console.WriteLine("SingleById 10");
            Console.WriteLine(_carsProvider.SingleById(10));

            Console.WriteLine();
            Console.WriteLine("Takecars Range");
            foreach (var item in _carsProvider.TakeCars(3..4)) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("Skip Cars");
            foreach (var item in _carsProvider.SkipCars(3)) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("Dinsinct Colors");
            foreach (var item in _carsProvider.DistinctByColors()) { Console.WriteLine(item); }

            Console.WriteLine();
            Console.WriteLine("Chunk Cars");
            foreach (var item in _carsProvider.ChunkCars(3)) { 
                Console.WriteLine($"Chunk"); 
                foreach(var i in item) 
                {  
                   Console.WriteLine(i); 
                }
            }








        }
        public static List<Car> GenerateSampleCars()
        {
            return new List<Car>
            {
                new Car
                {
                    Id = 670,
                    Name = "Car 1",
                    Color = "Black",
                    Standardcost = 1047.31M,
                    ListPrice = 1545.50M,
                    Type = "60",

                },
                new Car
                {
                Id = 671,
                Name = "Car 2",
                Color = "Red",
                Standardcost = 1250.00M,
                ListPrice = 1875.00M,
                Type = "SUV",
                },

                new Car
                {
                Id = 672,
                Name = "Car 3",
                Color = "Blue",
                Standardcost = 980.75M,
                ListPrice = 1500.99M,
                Type = "Sedan",
                },

                new Car
                {
                Id = 673,
                Name = "Car 4",
                Color = "White",
                Standardcost = 1125.50M,
                ListPrice = 1690.00M,
                Type = "Convertible",
                },

                new Car
                {
                Id = 674,
                Name = "ACar 5",
                Color = "Green",
                Standardcost = 1400.00M,
                ListPrice = 2100.00M,
                Type = "Truck",
                },

                new Car
                {
                Id = 675,
                Name = "Car 6",
                Color = "Yellow",
                Standardcost = 1345.67M,
                ListPrice = 2025.00M,
                Type = "Hatchback",
                },

                new Car
                {
                Id = 676,
                Name = "Car 7",
                Color = "Gray",
                Standardcost = 1175.80M,
                ListPrice = 1760.50M,
                Type = "Coupe",
                },

                new Car
                {
                Id = 677,
                Name = "Car 8",
                Color = "Silver",
                Standardcost = 1600.20M,
                ListPrice = 2400.30M,
                Type = "Minivan",
                },

                new Car
                {
                Id = 678,
                Name = "Car 9",
                Color = "Orange",
                Standardcost = 1100.00M,
                ListPrice = 1650.00M,
                Type = "SUV",
                },

                new Car
                {
                Id = 679,
                Name = "Car 10",
                Color = "Brown",
                Standardcost = 975.45M,
                ListPrice = 1450.50M,
                Type = "Sedan",
                } };


            }
        }
*/