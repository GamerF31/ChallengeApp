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

    }
}