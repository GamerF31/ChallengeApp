
using Project.Entities;

namespace Project.Entities
{
    public class Customers : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"Id: {Id},Customer Name: {Name}, Customer Surname {Surname}, Customer Age {Age}";
    }
}