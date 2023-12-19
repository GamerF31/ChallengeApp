namespace ChallengeApp2
{   
    public abstract class Person
    {
        public Person(string name, string surname, int age, string male)
        {

            this.Name = name;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string male { get; private set; }
        public int age { get; private set; }
    }
}
