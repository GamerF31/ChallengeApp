﻿
using Project.Entities;

namespace Project.Repositories;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T> where T : class, IEntity
{

}

