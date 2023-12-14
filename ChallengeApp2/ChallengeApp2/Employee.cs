using System.Diagnostics;

namespace ChallengeApp2
{
    public class Employee

    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
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

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
            {
               
                
                if (grade < 0)
                {
                    continue;
                }
                statistics.Max = Math.Max(statistics.Max, this.grades[index]);
                statistics.Min = Math.Min(statistics.Min, this.grades[index]);
                statistics.Average += this.grades[index];
                

            } 
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            
            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
        public Statistics GetStatisticsWithForEach()
        {
            var statisticsForEach = new Statistics();
            statisticsForEach.Average = 0;
            statisticsForEach.Max = float.MinValue;
            statisticsForEach.Min = float.MaxValue;
            var index = 0;
            foreach (var grade in this.grades)
            {
                statisticsForEach.Max = Math.Max(statisticsForEach.Max, grade);
                statisticsForEach.Min = Math.Min(statisticsForEach.Min, grade);
                statisticsForEach.Average += grade;
            }
            statisticsForEach.Average = statisticsForEach.Average / this.grades.Count;
            return statisticsForEach;

        }
        public Statistics GetStatisticsWithFor()
        {
            var statisticsFor = new Statistics();
            statisticsFor.Average = 0;
            statisticsFor.Max = float.MinValue;
            statisticsFor.Min = float.MaxValue;
            for(int item = 0; item<this.grades.Count; item++) 
            {
                statisticsFor.Max = Math.Max(statisticsFor.Max, this.grades[item]);
                statisticsFor.Min = Math.Min(statisticsFor.Min, this.grades[item]);
                statisticsFor.Average += item;
            }
            statisticsFor.Average = statisticsFor.Average / this.grades.Count;
            return statisticsFor;

        }
        public Statistics GetStatisticsWithDoWhile()
        {
            var statisticsdowhile = new Statistics();
            statisticsdowhile.Average = 0;
            statisticsdowhile.Max = float.MinValue;
            statisticsdowhile.Min = float.MaxValue;
            var item = 0;
            do
            {
                statisticsdowhile.Max = Math.Max(statisticsdowhile.Max, this.grades[item]);
                statisticsdowhile.Min = Math.Min(statisticsdowhile.Min, this.grades[item]);
                statisticsdowhile.Average += item;
                item++;

            } while (item < this.grades.Count);
            statisticsdowhile.Average = statisticsdowhile.Average / this.grades.Count;
            return statisticsdowhile;
        }
        public Statistics GetStatisticsWithWhile()
        {
            var statisticswhile = new Statistics();
            statisticswhile.Average = 0;
            statisticswhile.Max = float.MinValue;
            statisticswhile.Min = float.MaxValue;
            var item = 0;
            while (item < this.grades.Count)
            {
                statisticswhile.Max = Math.Max(statisticswhile.Max, this.grades[item]);
                statisticswhile.Min = Math.Min(statisticswhile.Min, this.grades[item]);
                statisticswhile.Average += item;
                item++;

            } 
            statisticswhile.Average = statisticswhile.Average / this.grades.Count;
            return statisticswhile;
        }

    }

}
