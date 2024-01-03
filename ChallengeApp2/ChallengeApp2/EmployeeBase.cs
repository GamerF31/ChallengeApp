namespace ChallengeApp2
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname)
        {
            this.Surname = surname;
            this.Name = name;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);


        public abstract void AddGrade(long grade);


        public abstract void AddGrade(char grade);


        public abstract void AddGrade(string grade);


        public abstract Statistics GetStatistics();
        
    }
}
