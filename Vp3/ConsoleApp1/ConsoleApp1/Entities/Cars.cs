using ConsoleApp1.Entities;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Entities
{
    public class Cars : EntityBase
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Country { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => $"Id: {Id}, Model: {Model}, Year: {Year}, Country: {Country}, Prize: {Price}";
    }
}