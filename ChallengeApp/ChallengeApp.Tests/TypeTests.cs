

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        public void TEST()
        {
            // arrage
            var employee4 = GetEmployee("Franek", "Kowalski", 55);
            var employee5 = GetEmployee("Grzegorz", "Nowak", 22);

            // act


            // assert
            Assert.AreEqual(employee4, employee5);
        }
        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }


    }
}
