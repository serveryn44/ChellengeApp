

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            // arrage
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Adam");
            // act


            // assert
           Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

        public void TestTwoNumbersAreEqual()
        {
            // arrage
            int number1 = 1;
            int number2 = 1;
            // act


            // assert
            Assert.AreEqual(number1, number2);
        }

        public void TestTwoStringAreNotEual()
        {
            // arrage
            string number1 = "Adam";
            string number2 = "Adam";
            // act


            // assert
            Assert.AreNotEqual(number1, number2);
        }


    }
}
