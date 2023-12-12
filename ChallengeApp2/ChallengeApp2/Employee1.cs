namespace ChallengeApp2
{
    public class Employee1

    {
        private List<float> grades = new List<float>(); 
        public Employee1 (string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }
        
        public string Surname { get; private set; } 
        public void AddGrade(float grade) 
        {
            this.grades.Add(grade);
        }
        public Statistics GetStatistics() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach(var grade in this.grades) 
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            
            return statistics;
        }
    }

}
