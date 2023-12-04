namespace ChallengeApp2.Test
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectPoints()
        {
            // arrange
            var user = new User("Przemek", "nike65");
            user.AddScore(5);
            user.AddScore(6);
            user.DelScore(5);
            // act
            var result = user.Result;
            

            //asset
            Assert.AreEqual(6, result); 
            
        }
        [Test]
        public void WhenUserCollectPoints2()
        {
            // arrange
            var user = new User("Marina", "nike365");
            user.AddScore(2);
            user.AddScore(3);
            user.DelScore(10);
            // act
            var result = user.Result;


            //asset
            Assert.AreEqual(-5, result);

        }
        [Test]
        public void WhenUserCollectPoints3()
        {
            // arrange
            var user = new User("Kondzio", "adike65");
            user.AddScore(5);
            user.AddScore(3);
            user.DelScore(8);
            // act
            var result = user.Result;


            //asset
            Assert.AreEqual(0, result);

        }

    }
}