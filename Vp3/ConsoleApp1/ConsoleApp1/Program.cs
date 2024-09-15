using ConsoleApp1.Repositories;
using ConsoleApp1.Entities;
using ConsoleApp1.Repositories.Extensions;
using ConsoleApp1.DataProviders;
#region Global Variables
var activeApp = true;
string modelname = null;
string carCountry = null;
int carYear = 0;
decimal carprice = 0;
string customerName = null;
string customerSurName = null;
int customerAge = 0;

var carsRepository = new ListRepository<Cars>();
var customersRepository = new ListRepository<Customers>();
const string auditFile = "AuditFile.json";
carsRepository.ItemAdded += CarsAdded;
customersRepository.ItemAdded += CustomersAdded;

static void CarsAdded(object? sender, Cars item)
{
    Console.WriteLine($"{item.Model} {item.Country} {item.Year} added");
    string json = $"[{DateTime.Now}]-CarsAdded-[{item.Model} {item.Country} {item.Year}]";
    File.WriteAllText(auditFile, json);
}
static void CustomersAdded(object? sender, Customers item)
{
    Console.WriteLine($"{item.Name} {item.Surname} {item.Age} added");
    string json = $"[{DateTime.Now}]-CustomersAdded-[{item.Name} {item.Surname} {item.Age}]";
    File.WriteAllText(auditFile, json);
}
carsRepository.ItemRemoved += CarsRemoved;
customersRepository.ItemRemoved += CustomersRemoved;
static void CarsRemoved(object? sender, Cars item)
{
    Console.WriteLine($"{item.Model} {item.Country} {item.Year} removed");
    string json = $"[{DateTime.Now}]-CarsRemoved-[{item.Model} {item.Country} {item.Year}]";
    File.WriteAllText(auditFile, json);
}
static void CustomersRemoved(object? sender, Customers item)
{
    Console.WriteLine($"{item.Name} {item.Surname} {item.Age} removed");
    string json = $"[{DateTime.Now}]-CustomersRemoved-[{item.Name} {item.Surname} {item.Age}]";
    File.WriteAllText(auditFile, json);
}

void AddCars(IRepository<Cars> repository)
{
    repository.ItemsToList();
    var car = new[]
    {
                new Cars {Model = modelname, Country = carCountry, Year = carYear, Price = carprice},
            };

    repository.AddBatch(car);
}

void AddCustomers(IRepository<Customers> repository)
{
    repository.ItemsToList();
    var customer = new[]
    {
                new Customers {Name = customerName, Surname = customerSurName, Age = customerAge},
            };

    repository.AddBatch(customer);
}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    repository.ItemsToList();
    var items = repository.GetAll();
    if (items != null)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
    else
    {
        Console.WriteLine("W tej liście nie znajduje się jeszcze żaden element");
    }
}

void RemoveById<T>(ListRepository<T> repository, int id) where T : class, IEntity
{
    repository.ItemsToList();
    var items = repository.GetAll();
    foreach (var item in items)
    {
        if (id == item.Id)
        {
            repository.Remove(item);
        }
    }
    repository.Save();
}

Console.WriteLine("Witamy w programie do dodawania Samochodów i Klientów");
Console.WriteLine("=====================================================");
ICarsProvider carsProvider = new CarsProvider(carsRepository);

while (activeApp)
{
    Console.WriteLine("Wybierz co chcesz zrobić");
    Console.WriteLine("1. Wyświetlić wszystkie dostępne samochody\n 2. Dodać samochód\n 3. Usunąć samochód\n 4. Wyświetlić wszystkich klientów\n 5. Dodać klienta\n 6. Usunąc klienta\n 7. Zakończyć program\n 8. Wyświetlić najtańsze samochody\n 9. Wyświetliśc samochody posortowane według modelu (rosnąco)\n 10. Wyświetlić samochody posortowane według modelu (malejąco)");
    float.TryParse(Console.ReadLine(), out float userChoice);
    if (userChoice == 1)
    {
        WriteAllToConsole(carsRepository);
    }
    else if (userChoice == 2)
    {
        Console.WriteLine("Podaj model samochodu: ");
        modelname = Console.ReadLine();
        Console.WriteLine("Podaj kraj pochodzenia samochodu: ");
        carCountry = Console.ReadLine();
        Console.WriteLine("Podaj rok rejestracji samochodu: ");
        carYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj cene samochodu: ");
        carprice = int.Parse(Console.ReadLine());

        AddCars(carsRepository);

    }
    else if (userChoice == 3)
    {
        Console.WriteLine("Podaj id samochodu, który chcesz usunąć ");
        WriteAllToConsole(carsRepository);
        Console.WriteLine("\nWpisz jego ID:\n");
        int id = int.Parse(Console.ReadLine());
        RemoveById(carsRepository, id);

    }
    else if (userChoice == 4)
    {
        WriteAllToConsole(customersRepository);

    }
    else if (userChoice == 5)
    {
        Console.WriteLine("Podaj imie klienta: ");
        customerName = Console.ReadLine();
        Console.WriteLine("Podaj nazwisko klienta: ");
        customerSurName = Console.ReadLine();
        Console.WriteLine("Podaj wiek klienta: ");
        customerAge = int.Parse(Console.ReadLine());

        AddCustomers(customersRepository);

    }
    else if (userChoice == 6)
    {
        Console.WriteLine("Podaj id samochodu, który chcesz usunąć ");
        WriteAllToConsole(customersRepository);
        Console.WriteLine("\nWpisz jego ID:\n");
        int id = int.Parse(Console.ReadLine());
        RemoveById(customersRepository, id);

    }
    else if (userChoice == 7)
    {
        activeApp = false;
    }
    else if (userChoice == 8)
    {
        Console.WriteLine($"Minimalna cena samochodu: {carsProvider.GetMinPrizeOfCar()}");
    }
    else if (userChoice == 9)
    {
        var carsOrderedAsc = carsProvider.OrderByName();
        Console.WriteLine("Samochody posortowane według modelu (rosnąco):");
        foreach (var car in carsOrderedAsc)
        {
            Console.WriteLine(car);
        }
    }
    else if (userChoice == 10)
    {
        var carsOrderedDesc = carsProvider.OrderByNameDesc();
        Console.WriteLine("Samochody posortowane według modelu (malejąco):");
        foreach (var car in carsOrderedDesc)
        {
            Console.WriteLine(car);
        }
    }
    }
#endregion