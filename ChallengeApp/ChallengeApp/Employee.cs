

namespace ChallengeApp
{
    public class Employee : Person
    {
        List<float> grades = new List<float>();

        public Employee(string name, string surename, string gender)
            :base (name, surename,gender)
        {
           
            
        }
        

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
        public void AddGrades(char grade) 
        {
        switch(grade) 
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
      
        
       

    }
}
