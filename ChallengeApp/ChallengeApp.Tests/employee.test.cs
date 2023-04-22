namespace ChallengeApp.Tests
{
    public class Tests
    {
      

        [Test]
        public void WhenEmployeeCollectTwoScores_ShouldCorectResault()
        {
          Employee employee4 = new Employee ("Antek", "Radzikowski",8);
            employee4.AddScore(5);
            employee4.AddScore(6);



            var result = employee4.Score;
            
            Assert.AreEqual(11, result);
        }

    }
}