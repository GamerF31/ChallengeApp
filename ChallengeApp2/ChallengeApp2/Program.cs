using ChallengeApp2;

/*var employe = new Employee("Przemek", "Hubacz");
employe.AddGrade("Pesemek");
employe.AddGrade(4);
employe.AddGrade(60);
employe.AddGrade(2.2d);
employe.AddGrade(9.3f);
employe.AddGrade('a');
var statistics = employe.GetStatistics();
Console.WriteLine(statistics.AverageLetter);
*/

Console.WriteLine("Witamy w Programie XYZ do oceny Pracowników");
Console.WriteLine("========================================");
Console.WriteLine();
var employee = new Employee();
while(true)
{
    Console.WriteLine("Podaj kolejną ocene pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

