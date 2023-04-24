

namespace ChallengeApp
{
    public class Employee
    {
        List<float> grades = new List<float>();

        public Employee(string name, string surename)
        {
            this.Name = name;
            this.Surename = surename;
        }
        public string Name { get; private set; }
        public string Surename { get; private set; }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public void AddGrades(float grade)
        {
            this.grades.Add(grade);
        }
    }
}
