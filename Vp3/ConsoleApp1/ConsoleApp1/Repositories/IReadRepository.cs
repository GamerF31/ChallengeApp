

using ConsoleApp1.Entities;

namespace ConsoleApp1.Repositories;

public interface IReadRepository<out T> where T : class, IEntity
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    IEnumerable<T> ItemsToList();

}
