

using NUnit.Framework;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]

        public void ShowsMinValue()
        {
            Employee employee1 = new Employee("Jan", "Kowalski", "Mê¿czyzna");

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
            Employee employee1 = new Employee("Jan", "Kowalski", "Mê¿czyzna");

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
            Employee employee1 = new Employee("Jan", "Kowalski", "Mê¿czyzna");

            employee1.AddGrades(5);
            employee1.AddGrades(10);
            employee1.AddGrades(3);
            employee1.AddGrades(8);
            employee1.AddGrades(4);
            var statistic = employee1.GetStatistics();

            Assert.AreEqual(6, statistic.Average);
        }
        [Test]
        public void ICheckIfItCorrectlyAddsThePointsAssignedToTheLettersAndDisplaysTheLargestValue()
        {
            Employee employee = new Employee("Karol", "Radzikowski", "Mê¿czyzna");
            employee.AddGrades('A');
            employee.AddGrades('a');
            employee.AddGrades('b');
            employee.AddGrades('c');
            employee.AddGrades('d');
            employee.AddGrades('e');

            var statistic = employee.GetStatistics();

            Assert.AreEqual(100, statistic.Max);
        }
        [Test]
        public void ICheckIfItGivesTheAverageResultsCorrectly()
        {
            Employee employee = new Employee("Jan", "Bek", "Mê¿czyzna");
            employee.AddGrades('B');
            employee.AddGrades(80);
            employee.AddGrades(20);
            employee.AddGrades('E');

            var statistic = employee.GetStatistics();

            Assert.AreEqual(50, statistic.Average);
            Assert.AreEqual('C', statistic.AverangeLetter);
        }
    }

}