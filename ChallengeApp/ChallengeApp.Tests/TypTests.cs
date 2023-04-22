

namespace ChallengeApp.Tests
{
    public class TypTests
    {
        [Test]
        public void GetEmployeeShouldReturnDifrentObject()
        {
            var employee1 = GetEmployee("Maciek","Lewicki", 23);
            var employee2 = GetEmployee("Maciek", "Lewicki", 23);

            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void GetEmployeeShouldReturnDifrentInt()
        {
            int number1 = 5;
            int number2 = 7;

            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void GetEmployeeShouldReturnDifrentFloat()
        {
            float number1 = 7.21F;
            float number2 = 6.21F;

            Assert.AreNotEqual(number2, number1);
        }
        [Test]
        public void GetEmployeeShouldReturnDifrentString()
        {
            string number1 = "35";
            string number2 = "25";

            Assert.AreNotEqual(number2,number1);
        }
        [Test]
        public void GetEmployeeShouldReturnDifrentVar()
        {
            var employee1 = GetEmployee("Katarzyna", "Lewicka", 25);
            var employee2 = GetEmployee("Maciek", "Lewicki", 23);

            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string Name, string Surename, int Age)
        {
            return new Employee(Name, Surename, Age);
        }
        
    }

    
}
