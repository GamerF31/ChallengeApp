
using ConsoleApp1.Entities;

namespace ConsoleApp1.Repositories;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
{

}

