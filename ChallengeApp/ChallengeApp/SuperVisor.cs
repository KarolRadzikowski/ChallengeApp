

namespace ChallengeApp
{
    public class SuperVisor : IEmployee
    {

        List<float> grades = new List<float>();

        public SuperVisor(string name, string surename, string gender)
        {
            this.Name = name;
            this.Surename = surename;
            this.Gender = gender;
        }
        public string Name { get; private set; }
        public string Surename { get; private set; }
        public string Gender { get; private set; }
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
            switch (statistics.Average)
            {
                case var Average when Average >= 80:
                    statistics.AverangeLetter = 'A';

                    break;
                case var Average when Average >= 60:
                    statistics.AverangeLetter = 'B';
                    break;
                case var Average when Average >= 40:
                    statistics.AverangeLetter = 'C';
                    break;
                case var Average when Average >= 20:
                    statistics.AverangeLetter = 'D';
                    break;

            }
            return statistics;
        }
        public void AddGrades(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float resault))
            {
                this.AddGrades(resault);
            }
        }
        public void AddGrades(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);

        }
        public void AddGrades(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrades(gradeAsFloat);
        }

        public void AddGrades(long grade)
        {
            float gadeAsFloat = (float)grade;
            this.AddGrades(gadeAsFloat);
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    this.grades.Add(100);
                    break;
                case "6-":
                    this.grades.Add(95);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "5-":
                    this.grades.Add(75);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "4-":
                    this.grades.Add(55);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "3-":
                    this.grades.Add(35);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "2-":
                    this.grades.Add(15);
                    break;
            }
        }

        public void AddGrades(char grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }
    }
}
