namespace ChallengeApp3
{
    public class Employee
    {
        public Employee(int Age, string Name, string Surname)
        {
            this.Age = Age;
            this.Name = Name;
            this.Surname = Surname;
        }

        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private List<int> Score = new List<int>();

        public int Result
        { get 
            {
                return this.Score.Sum();
            } 
        }
        public void Addpunkty(int Number)
        {
            this.Score.Add(Number);
        }


    }
}
