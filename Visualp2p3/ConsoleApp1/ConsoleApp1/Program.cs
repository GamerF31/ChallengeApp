using Microsoft.Extensions.DependencyInjection;
using ConsoleApp1;
using ConsoleApp1.Components.DataProviders;
using ConsoleApp1.Data.Entities;
using ConsoleApp1.Data.Repositories;
using ConsoleApp1.Components.CsvReader;
var services = new ServiceCollection();
services.AddSingleton<IApp, App>();
//services.AddSingleton<IRepository<Employee>, ListRepository<Employee>>();
//services.AddSingleton<IRepository<Car>, ListRepository<Car>>();
//services.AddSingleton<ICarsProvider, CarsProvider>();
services.AddSingleton<ICsvReader, CsvReader>();
var serviceProvider = services.BuildServiceProvider();
var app = serviceProvider.GetService<IApp>()!;

app.Run();



























//using ConsoleApp1;
//using ConsoleApp1.Entities;
//using ConsoleApp1.Repositories;
//using ConsoleApp1.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.VisualBasic;
//using ConsoleApp1.Repositories.Extensions;

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), EmployeeAdded);
//employeeRepository.ItemAdded += EmployeeRepositoryOnItemAdded;

//void EmployeeRepositoryOnItemAdded(object? sender, Employee e)
//{

//    Console.WriteLine($"Employe added => {e.FirstName} from {sender?.GetType().Name}");
//}

//AddEmployees(employeeRepository);
//WriteAllToConsole(employeeRepository);


//static void EmployeeAdded(object item)
//{
//    var employee = (Employee)item;
//    Console.WriteLine($"{employee.FirstName} added");
//}

//static void AddEmployees(IRepository<Employee> repository)
//{
//    var employees = new[]
//    {
//        new Employee { FirstName = "Adam"},
//        new Employee { FirstName = "Patryk" },
//        new Employee { FirstName = "Paweł" }
//    };
//    repository.AddBatch(employees);
//    "string".AddBatch(employees);

//    //AddBatch(employeeRepository, employees);
//    //employeeRepository.Add(new Employee { FirstName = "Przemek" });
//    //employeeRepository.Add(new Employee { FirstName = "Patryk" });
//    //employeeRepository.Add(new Employee { FirstName = "Paweł" });
//    //employeeRepository.Save();
//}


//static void WriteAllToConsole(IReadRepository<Employee> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);

//    }
//}
































//class Program
//{
//    static void Main(string[] args)
//    {


//        var carsRepository = new SqlRepository<Cars>(new MotoAppDbContext());
//        var customerRepository = new SqlRepository<Customer>(new MotoAppDbContext());
//        DefaultCars(carsRepository);
//        string input;
//        do
//        {

//            Console.WriteLine("\nCustomer View");
//            Console.WriteLine("1. Show Customers");
//            Console.WriteLine("2. Add Customers");
//            Console.WriteLine("3. Show Cars");
//            Console.WriteLine("4. Add Cars");
//            Console.WriteLine("\nPress q to quit");

//            input = Console.ReadLine();
//            switch (input)
//            {
//                case "1":
//                    WriteAllToConsole(customerRepository);
//                    break;
//                case "2":
//                    AddCustomers(customerRepository);
//                    break;
//                case "3":
//                    WriteAllToConsole(carsRepository);
//                    break;
//                case "4":
//                    AddCars(carsRepository);
//                    break;
//                default:
//                    if (input != "q")
//                        Console.WriteLine("Wrong input, Try again");
//                    break;
//            }
//        } while (input != "q");
//    }
//    static void DefaultCars(IRepository<Cars> carsRepository)
//    {
//        var defaultCars = new[]
//        {
//            new Cars { Model = "Audi", Year = 2018, Country = "Germany"},
//            new Cars { Model = "Ford Focus", Year = 2009, Country = "Sweden"},
//            new Cars { Model = "Golf", Year = 2011, Country = "Italy"},
//            new Cars { Model = "Fiat", Year = 2012, Country = "Poland"}
//        };
//        foreach (var car in defaultCars)
//        {
//            carsRepository.Add(car);
//        }
//        carsRepository.Save();


//    }
//    static void AddCars(IRepository<Cars> carsRepository)
//    {

//        Console.Write("Enter Car Model: ");
//        string model = Console.ReadLine();
//        Console.Write("Enter Car Country: ");
//        string country = Console.ReadLine();
//        Console.Write("Enter Car Year: ");
//        if (!int.TryParse(Console.ReadLine(), out int year) || year < 0)
//        {
//            Console.WriteLine("Invalid Year, Please enter a valid year");
//            return;
//        }

//        var newCar = new Cars
//        {
//            Model = model,
//            Year = year,
//            Country = country
//        };
//        carsRepository.Add(newCar);
//        carsRepository.Save();
//        Console.WriteLine("Car Added");
//    }

//    static void AddCustomers(IRepository<Customer> customerRepository)
//    {
//        Console.Write("Customer Name: ");
//        string name = Console.ReadLine();
//        Console.Write("Customer Surname: ");
//        string surname = Console.ReadLine();
//        Console.Write("Customer Age: ");
//        if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
//        {
//            Console.WriteLine("Invalid Age, Please enter a valid age");
//            return;
//        }

//        var newCustomer = new Customer { Name = name, Surname = surname, Age = age, };
//        customerRepository.Add(newCustomer);
//        customerRepository.Save();
//        Console.WriteLine("Customer Added");
//    }

//    static void WriteAllToConsole(IReadRepository<IEntity> repository)
//    {
//        var items = repository.GetAll();
//        if (items == null || !items.Any())
//        {
//            Console.WriteLine("No items found.");
//        }
//        else
//        {
//            foreach (var item in items)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }
//}



































































































//var employeeR = new GenericRepository<Employee>();
//employeeR.Add(new Employee { FirstName = "Przemek" });
//employeeR.Add(new Employee { FirstName = "Patryk" });
//employeeR.Add(new Employee { FirstName = "Paweł" });
//employeeR.Save();

//var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
//AddEmployees(employeeRepository);
//AddManagers(employeeRepository);
//WriteAllToConsole(employeeRepository);
//static void AddEmployees(IRepository<Employee> employeeRepository)
//{
//    employeeRepository.Add(new Employee { FirstName = "Przemek" });
//    employeeRepository.Add(new Employee { FirstName = "Patryk" });
//    employeeRepository.Add(new Employee { FirstName = "Paweł" });
//    employeeRepository.Save();
//}



//static void AddManagers(IWriteRepository<Manager> managerRepository)
//{ 
//    managerRepository.Add(new Manager { FirstName = "Przemek" });
//    managerRepository.Add(new Manager { FirstName = "Patryk" });
//    managerRepository.Add(new Manager { FirstName = "Paweł" });
//    managerRepository.Save();
//}



//static void WriteAllToConsole(IReadRepository<Employee> repository)
//{
//    var items = repository.GetAll();
//    foreach (var item in items)
//    {
//        Console.WriteLine(item);

//    }

//}
//employeeRepository.Add(new Employee { FirstName = "Przemek" });
//employeeRepository.Add(new Employee { FirstName = "Patryk" });
//employeeRepository.Add(new Employee { FirstName = "Paweł" });

//employeeRepository.Save();
//GetEmployeeById(employeeRepository);

//static void GetEmployeeById(IRepository<Employee> employeeRepository)
//{
//    var emp = employeeRepository.GetById(2);
//    Console.WriteLine(emp.ToString());
//}























































//var stack = new BasicStack<double>();
//var stackstring = new BasicStack<string>();

//try
//{
//    // Dodawanie elementów na stos
//    stack.Push(4);
//    stack.Push(5);
//    stack.Push(6);

//    // Próba dodania kolejnego elementu do stosu (dla celów demonstracyjnych)
//    // stack.Push(7); // Jeśli przekroczysz limit stosu, zostanie zgłoszony wyjątek InvalidOperationException

//    // Sprawdzanie, co znajduje się na szczycie stosu bez zdejmowania
//    Console.WriteLine($"Peek (top element): {stack.Peek()}");

//    double sum = 0;

//    stackstring.Push("Pies");

//    // Ściąganie elementów ze stosu
//    while (stack.Count > 0)
//    {
//        double item = stack.Pop();
//        Console.WriteLine($"Item: {item}");
//        sum += item;
//    }

//    Console.WriteLine($"Sum: {sum}");

//    // Próba zdjęcia elementu z pustego stosu (dla celów demonstracyjnych)
//    // double shouldThrowException = stack.Pop(); // Zostanie zgłoszony wyjątek InvalidOperationException

//    // Próba sprawdzenia szczytu pustego stosu (dla celów demonstracyjnych)
//    // Console.WriteLine($"Peek on empty stack: {stack.Peek()}"); // Zostanie zgłoszony wyjątek InvalidOperationException
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine($"Exception: {ex.Message}");
//}
