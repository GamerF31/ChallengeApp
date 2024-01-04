namespace ChallengeApp2
{
    public class EmployeeInMemory : EmployeeBase
    {
        
        private List<float> grades = new List<float>();
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
            
        }
        private void WriteMessageInConsole(string message)
        {
            Console.WriteLine(message);
        }


        private void WriteMessageInConsole2(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid number");
            }
        }

        public override void AddGrade(long grade)
        {
            float gradeslong = (float)grade;
            this.AddGrade(gradeslong);
        }

        public override void AddGrade(char grade)
        {
            string result = grade.ToString();
            this.AddGrade(result);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "A":
                    case "a":
                        this.AddGrade(100);
                        break;
                    case "B":
                    case "b":
                        this.AddGrade(80);
                        break;
                    case "C":
                    case "c":
                        this.AddGrade(60);
                        break;
                    case "D":
                    case "d":
                        this.AddGrade(40);
                        break;
                    case "E":
                    case "e":
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception("Wrong Letter");
                }
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach(var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }
            

            return statistics;
        }
    }
}
