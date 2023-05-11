

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
            Assert.AreEqual(result, 3, 6);

        }
        [Test]
        public void EmployeeWhenAddCharAverageTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('A');
            employee.AddGrade('A');
            employee.AddGrade('e');

            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.AverageLetter;
            //assert
            Assert.AreEqual(result, 'B');

        }
        [Test]
        public void EmployeeWhenAddCharAGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('A');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 100);

        }
        [Test]
        public void EmployeeWhenAddCharBGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('B');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 80);

        }
        [Test]
        public void EmployeeWhenAddCharCGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('C');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 60);
        }
        [Test]
        public void EmployeeWhenAddCharCeGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('C');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 60);
        }
        [Test]
        public void EmployeeWhenAddCharDGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('D');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 40);

        }
        [Test]
        public void EmployeeWhenAddCharEGradeIsCorectTest()
        {
            //arrange
            Employee employee = new Employee();
            employee.AddGrade('E');
            //assert
            var statistics = employee.GetStatistics();
            var result = statistics.Max;
            //assert
            Assert.AreEqual(result, 20);

        }
    }
}
