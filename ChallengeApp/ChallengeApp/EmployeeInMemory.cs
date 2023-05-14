
namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surename, string gender) 
            : base(name, surename, gender)
        {
        }
        private List<float> grades = new List<float>();

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                    
            }
            else
            {
                throw new Exception("invalid grade value");
            };
        }

        public override void AddGrades(string grade)
        {
            if (float.TryParse(grade, out float resault))
            {
                this.AddGrades(resault);
            }
        }

        public override void AddGrades(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrades(gradeAsFloat);
        }

        public override void AddGrades(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrades(gradeAsFloat);
        }

        public override void AddGrades(long grade)
        {
            float gadeAsFloat = (float)grade;
            this.AddGrades(gadeAsFloat);
        }

        public override void AddGrades(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            
            foreach (var grade in this.grades) 
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
