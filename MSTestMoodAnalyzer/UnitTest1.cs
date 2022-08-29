namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            void Given_Happymood_Expecting_Happy_Results()
            {
                //Arrange;
                MoodAnalyser mood = new MoodAnalyser(null);
                string expected = "happy";

                //Act
                string actual = mood.Analyser();

                //Asert
                Assert.AreEqual(expected, actual);


            }
        }
    }
}