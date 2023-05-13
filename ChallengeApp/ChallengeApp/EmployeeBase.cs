
namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surename, string gender)
        {
            this.Name = name;
            this.Surename = surename;
            this.Gender = gender;

        }

        public string Name { get; private set; }
        public string Surename { get; private set; }
        public string Gender { get; private set; }

        public abstract void AddGrade(float grade);


        public abstract void AddGrades(string grade);


        public abstract void AddGrades(double grade);


        public abstract void AddGrades(int grade);


        public abstract void AddGrades(long grade);

        public abstract void AddGrades(char grade);


        public abstract Statistics GetStatistics();
       
    }
}
