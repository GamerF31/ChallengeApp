namespace ChallengeApp2.Test
{
    public class EmployeeTest
    {
        [Test]
        public void ReturnMaxStat()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(10);
            employee.AddGrade(1);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(10, statistics.Max);
        }
        [Test]
        public void ReturnMinStat() 
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(10);
            employee.AddGrade(1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(1, statistics.Min);


        }
        [Test]
        public void ReturnifAverage()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(2);
            employee.AddGrade(10);
            employee.AddGrade(3);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(5, statistics.Average);

        }
        [Test]
        public void EmployeeTestreturn()
        {
            //arrange
            var employee = new Employee();
            employee.AddGrade(10);
            employee.AddGrade(1);
            employee.AddGrade(5);
            employee.AddGrade('A');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual('D', statistics.AverageLetter);
        }

    }
}
