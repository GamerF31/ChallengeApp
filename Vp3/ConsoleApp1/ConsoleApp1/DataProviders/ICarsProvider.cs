using ConsoleApp1.Entities;
namespace ConsoleApp1.DataProviders
{
    public interface ICarsProvider
    {

        //select

        decimal GetMinPrizeOfCar();


        //order by
        List<Cars> OrderByName();
        List<Cars> OrderByNameDesc();

        //where
        List<Cars> WhereStartsWith(string prefix);

        //first, last, single
        Cars SingleById(int id);
        Cars SingleOrDefaultById(int id);

        //take

        List<Cars> TakeCars(Range range);

        //Skip
        List<Cars> SkipCars(int howaMany);





    }
}
