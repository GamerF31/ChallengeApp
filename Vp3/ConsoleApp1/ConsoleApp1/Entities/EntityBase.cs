using ConsoleApp1.Entities;

namespace ConsoleApp1.Entities
{
    public abstract class EntityBase : IEntity
    {
        public int Id { get; set; }
    }
}