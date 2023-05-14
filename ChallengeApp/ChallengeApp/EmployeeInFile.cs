

using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        public event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surename, string gender)
            : base(name, surename, gender)
        {
        }
        private const string FileName = "grades.txt";

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.Write(grade);
                    if(GradeAdded != null)
                    { 
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
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
                    AddGrades(100);
                    break;
                case 'B':
                case 'b':
                    AddGrades(80);
                    break;
                case 'C':
                case 'c':
                    AddGrades(60);
                    break;
                case 'D':
                case 'd':
                    AddGrades(40);
                    break;
                case 'E':
                case 'e':
                    AddGrades(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");

            }
        }
        public override Statistics GetStatistics()
        {
            var GradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(GradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText($"{FileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
           
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }



    }
}
