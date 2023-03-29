namespace ChallengeApp.Tests
{
    public class Tests
    {
        

        [Test]
        public void WhenEmployeSumUpScorsShooldReturnCorrectResul()
        {
            

            var employee = new Employee("Adam", "Kowalski", 55);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddDockScore(5);
            
            
            var result = employee.Result;

            Assert.AreEqual(6, result);
        }
    }
}