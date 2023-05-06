

namespace ChallengeApp
{
    internal interface IEmployee
    {
        public Statistics GetStatistics();

        public void AddGrades(string grade);
        public void AddGrades(double grade);
        public void AddGrades(int grade);
        public void AddGrades(long grade);
        public void AddGrades(char grade);
        public void AddGrade(float grade);

        public string Name { get; }
        public string Surename { get; }
        public string Gender { get; }
    }
}
