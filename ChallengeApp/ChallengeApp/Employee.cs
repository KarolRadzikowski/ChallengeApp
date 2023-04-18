
namespace ChallengeApp
{
    public class Employee
    {
        public List<int> score = new List<int>();

        
        
        
        

    public Employee(string Name, string Surename, int Age)
        {
            this.Name = Name;
            this.Surname = Surename;
            this.Age = Age;
            this.Score = 0;
            
        }


        public string Name{ get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Score { get; private set; }
        public int Resault
        {
            get
            {
                return score.Sum();
            }
        }

        private List<int> scoreList = new List<int>();

        public void AddScore(int rating)
        {
            this.Score += rating;
        }

    }
}
