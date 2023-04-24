using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void ShowsMinValue()
        {
            Employee employee1 = new Employee("Jan", "Kowalski");

            employee1.AddGrades(5);
            employee1.AddGrades(10);
            employee1.AddGrades(3);
            employee1.AddGrades(8);
            employee1.AddGrades(4);
            var statistic = employee1.GetStatistics();

            Assert.AreEqual(3, statistic.Min);

        
        
        }

        [Test]

        public void ShowsMaxValue()
        {
            Employee employee1 = new Employee("Jan", "Kowalski");

            employee1.AddGrades(5);
            employee1.AddGrades(10);
            employee1.AddGrades(3);
            employee1.AddGrades(8);
            employee1.AddGrades(4);
            var statistic = employee1.GetStatistics();

            Assert.AreEqual(10, statistic.Max);

        }

        [Test]

        public void ShowAverageValue()
        {
            Employee employee1 = new Employee("Jan", "Kowalski");

            employee1.AddGrades(5);
            employee1.AddGrades(10);
            employee1.AddGrades(3);
            employee1.AddGrades(8);
            employee1.AddGrades(4);
            var statistic = employee1.GetStatistics();

            Assert.AreEqual(6, statistic.Average);
        }
    }
}