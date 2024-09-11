using ConsoleApp1.Data.Entities;

namespace ConsoleApp1.Components.DataProviders
{
    public interface ICarsProvider
    {

        //select
        List<Car> FilterCars(decimal minPrize);
        List<string> GetUniqueCarColors();
        decimal GetMinPrizeOfCar();
        List<Car> GetSpecificColumns();
        string AnonymousClass();

        //order by
        List<Car> OrderByName();
        List<Car> OrderByColorAndName();
        List<Car> OrderByColorAndNameDesc();
        List<Car> OrderByNameDesc();

        //where
        List<Car> WhereStartsWith(string prefix);
        List<Car> WhereStartsWithAndCostIsGreaterThan(string prefix, decimal cost);
        List<Car> WhereColorIs(string color);

        //first, last, single

        Car FirstByColor(string color);
        Car LastByColor(string color);
        Car FirstOrDefaultByColor(string color);
        Car FirstOrDefaultByColorWithDefault(string color);
        Car SingleById(int id);
        Car SingleOrDefaultById(int id);

        //take
        List<Car> TakeCars(int howaMany);
        List<Car> TakeCars(Range range);
        List<Car> TakeCarsWhileNameStartsWith(string prefix);

        //Skip
        List<Car> SkipCars(int howaMany);
        List<Car> SkipCarsWhileNameStartsWith(string prefix);

        //Distinct
        List<string> DistinctAllColors();
        List<string> DistinctByColors();

        // Chunk

        List<Car[]> ChunkCars(int size);




    }
}
