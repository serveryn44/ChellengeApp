

namespace ChallengeApp.Test
{
    public class TypeTests
    {
        [Test]
        public void TestTwoStringAreEqual()
        {
            //arrange
            string employee1 = "Adam";
            string employee2 = "Adam";

            //assert
            Assert.AreEqual(employee1, employee2);

        }
        [Test]
        public void TestTwoFloatsAreNotEqual()
        {
            //arrange
            float number1 = 01224f;
            float number2 = 01222f;

            //assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void TestTwoIntsAreNotEqual()
        {
            //arrange
            int number1 = 1;
            int number2 = 1; ;

            //assert
            Assert.AreEqual(number1, number2);

        }

    }
}
