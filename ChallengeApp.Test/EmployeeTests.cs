

namespace ChallengeApp.Test
{
    public class EmployeeTests
    {
        [Test]
        public void EmployeeMaxGradeTest()
        {
            //arrange
            Employee employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(3);

            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 5);

        }
        [Test]
        public void EmployeeMinGradeTest()
        {
            //arrange
            Employee employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(3);



            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Min;
            //assert
            Assert.AreEqual(result, 1);

        }
        [Test]
        public void EmployeeAverrageGradeTest()
        {
            //arrange
            Employee employee = new Employee("Adam", "Kowalski");
            employee.AddGrade(5);
            employee.AddGrade(3);
            employee.AddGrade(3);

            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Average;
            //assert
            Assert.AreEqual(result, 3,6);

        }
       
    }
}
