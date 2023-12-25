namespace ChallengeApp2
{   
    public abstract class Person
    {
        public Person(string name, string surname, int age, string sex)
        {

            this.Name = name;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
    }
}
