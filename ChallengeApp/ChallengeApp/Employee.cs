

using System.ComponentModel.Design;
using System.Diagnostics;

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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
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
        public Statistics GetStatisticsWitchForEach()
        {
         var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            foreach (var grade in this.grades)
            {
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhitchFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            
            for(var index = 0;  index < this.grades.Count; index++)
            {
                statistics.Min = Math.Min(statistics.Min, index);
                statistics.Max = Math.Max(statistics.Max, index);
                statistics.Average += index;
            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhitchWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            var index = 0;
            while (index < this.grades.Count)
            {
                if (this.grades[index] > statistics.Max)
                {
                    statistics.Max = this.grades[index];
                }
                if (this.grades[ index]< statistics.Min)
                {
                    statistics.Min = this.grades[index];
                }
                statistics.Average += index;
                index++;

            }
            statistics.Average /= grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhitchDoWhile() 
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;
            var index = 0;
            do
            {
                if (this.grades[index] > statistics.Max)
                {
                    statistics.Max = this.grades[index];
                }
                if (this.grades[index] < statistics.Min)
                {
                    statistics.Min = this.grades[index];
                }
                this.grades[index] += statistics.Average
                    ; index++;
            } while (index < this.grades.Count);
            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}
