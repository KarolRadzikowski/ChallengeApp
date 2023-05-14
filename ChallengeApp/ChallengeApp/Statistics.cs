
namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average {
            get
            {
                return this.Sum / this.Count;
            }
                }
        public char AverangeLetter
        {
            get
            {

                switch (this.Average)
                {
                    case var Average when Average >= 80:
                        return 'A';
                    case var Average when Average >= 60:
                        return 'B';
                    case var Average when Average >= 40:
                        return 'C';
                    case var Average when Average >= 20:
                        return 'D';
                    default:
                        return 'E';


                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Min =float.MaxValue;
            this.Max =float.MinValue;
        }

        public void AddGrade(float grade) 
        { 
        this.Count++;
        this.Sum += grade;
        this.Min = Math.Min(this.Min, grade);
        this.Max = Math.Max(this.Max, grade);
        }

    }
}
