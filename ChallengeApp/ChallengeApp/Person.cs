


namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surename, string gender)
        {
            this.Name = name;
            this.Surename = surename;
            this.Gender = gender;
            
        }

        public  string Name { get; private set; }
        public  string Surename { get;private set; }
        public  string Gender { get; private set; }
    }
}
