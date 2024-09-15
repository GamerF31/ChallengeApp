﻿

using Project.Entities;

namespace Project.Repositories;

public interface IReadRepository<out T> where T : class, IEntity
{
    IEnumerable<T> GetAll();
    T GetById(int id);
    IEnumerable<T> ItemsToList();

}