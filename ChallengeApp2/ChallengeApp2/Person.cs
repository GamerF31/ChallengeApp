namespace ChallengeApp2
{   
    public abstract class Person
    {
        public Person(string Name, string Surname, int Age, string Sex)
        {

            this.Name = Name;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }
    }
}
