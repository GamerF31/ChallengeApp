
using System.Diagnostics.Contracts;
using System.Text;

namespace ConsoleApp1.Data.Entities;
public class Car : EntityBase
{
    public string Name { get; set; }
    public string Color { get; set; }
    public decimal Standardcost { get; set; }
    public string Type { get; set; }
    public decimal ListPrice { get; set; }
    public int? NameLength { get; set; }
    public decimal? TotalSales { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new(1024);

        sb.AppendLine($"{Name} ID: {Id}");

        sb.AppendLine($" Color: {Color} Type: {Type}");

        sb.AppendLine($"Cost: {Standardcost:c} Price: {ListPrice:c}");
        if (NameLength.HasValue)
        {
            sb.AppendLine($"Name Length: {NameLength}");

        }
        if (TotalSales.HasValue)
        {
            sb.AppendLine($"Name Length: {TotalSales:c}");

        }
        return sb.ToString();
    }


}

