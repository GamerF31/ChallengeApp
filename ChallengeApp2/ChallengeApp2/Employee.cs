using System.Diagnostics;

namespace ChallengeApp2
{
    public class Employee

    {
        private List<float> grades = new List<float>();
        public Employee()
        {
            
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }
        public void AddGrade(float grade)
        {   

            if (grade >= 0 && grade <= 100) 
            {
                this.grades.Add(grade);
            }
            else 
            {
                Console.WriteLine("invalid grade value");
            }    
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.grades.Add(result);
            }
            else 
            { 
                Console.WriteLine("String in not float"); 
            }
        }
        public void AddGrade(double grade) 
        {
            var gradesdouble = (float)grade;
            AddGrade(gradesdouble);
        }
        public void AddGrade(long grade)
        {
            var gradeslong = (float)grade;
            AddGrade(gradeslong);
        }
        public void AddGrade(char grade)
        {
            switch(grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                    this.grades.Add(80);
                    break;
                case 'C':
                    this.grades.Add(60);
                    break;
                case 'D':
                    this.grades.Add(40);
                    break;
                case 'E':
                    this.grades.Add(20);
                    break;
                default:
                    Console.WriteLine("Wrong letter");
                    break;
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            
            statistics.Average = statistics.Average / this.grades.Count;
            
            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
        
        

    }

}
