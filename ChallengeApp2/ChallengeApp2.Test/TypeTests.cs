using ChallengeApp3;
using ChallengeApp2;

namespace ChallengeApp2.Test
{
    public class TypeTests
    {
        [Test]
        public void TESTint()
        {
            // arrange
            int number1 = 20;
            int number2 = 20;
            // act


            //assert
            Assert.AreEqual(number1, number2);  
            
        }
        [Test]
        public void TEST2float()
        {
            // arrange
            float number1 = 2321312132;
            float number2 = 2321312132;
            // act


            //assert
            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void TEST3string()
        {
            // arrange
            string Name = "Przemek";
            string Name2 = "Przemek";
            // act


            //assert
            Assert.AreEqual(Name, Name2);

        }
        [Test]
        public void TEST4Employee()
        {
            // arrange
            var Employee = GetEmployee(21, "Przemek","Hubacz");
            var Employee2 = GetEmployee(21, "Przemek","Hubacz");
            // act


            //assert
            Assert.AreNotEqual(Employee, Employee2);

        }
        private Employee2 GetEmployee(int Age, string Name, string Surname)
        {
            return new Employee2(Age, Name, Surname);
        }
    }
}
