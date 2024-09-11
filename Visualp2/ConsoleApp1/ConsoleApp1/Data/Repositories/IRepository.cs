using ConsoleApp1.Data.Entities;

namespace ConsoleApp1.Data.Repositories;
public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
{

}

