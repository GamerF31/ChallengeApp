/*using ChallengeApp2;

User user1 = new User("Adam", "2324fd");
User user2 = new User("Przemek", "343ffd");
User user3 = new User("Zuzia", "Porew33");
User user4 = new User("Kapi", "ewqre");


user1.AddScore(1);
user1.AddScore(4);
var result = user1.Result;
Console.WriteLine(result);
var name = User.GameName;
var pi = Math.PI;
Console.WriteLine(name);*/
/*

Employee employer1 = new Employee(21, "Przemek","Hubacz");
Employee employer2 = new Employee(13, "Paweł", "Hubacow");
Employee employer3 = new Employee(29, "Konrad", "Kapusta");
List<Employee> employers = new List<Employee>()
{
    employer1, employer2, employer3
};

int maxR = -1;
Employee usemaxR = null;
employer1.Addpunkty(3);
employer1.Addpunkty(10);
employer1.Addpunkty(5);
employer1.Addpunkty(3);
employer1.Addpunkty(7);

employer2.Addpunkty(3);
employer2.Addpunkty(8);
employer2.Addpunkty(3);
employer2.Addpunkty(2);
employer2.Addpunkty(1);

employer3.Addpunkty(3);
employer3.Addpunkty(1);
employer3.Addpunkty(1);
employer3.Addpunkty(5);
employer3.Addpunkty(8);
foreach (var Employee in employers)
{
    if (Employee.Result > maxR)

    { 
        maxR = Employee.Result;
        usemaxR = Employee; }
}
Console.WriteLine("Ziomek z największą ilością punktów to " + usemaxR.Name +" " + usemaxR.Surname + " ma " + usemaxR.Age+" lat");
*/
using ChallengeApp2;

var employe = new Employee("Przemek", "Hubacz");
employe.AddGrade("Pesemek");
employe.AddGrade(4000);
employe.AddGrade(6);
employe.AddGrade(2.2d);
employe.AddGrade(9.3f);
var statistics = employe.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Average: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Max}");

SetSth(out statistics);


void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}



