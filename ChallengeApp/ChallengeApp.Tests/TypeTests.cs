

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        public void TEST()
        {
            // arrage
            var employee1 = GetEmployee("Adam", "Kowalski", 22);
            var employee2 = GetEmployee("Franek", "Nowak", 45);
            // act


            // assert
           Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


    }
}
