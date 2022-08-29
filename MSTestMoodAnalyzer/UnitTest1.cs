namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            [TestMethod]
            public void Given_Emptymood_Using_CustomException_Return_Empty()
            {
                //Arrange;
                MoodAnalyser mood = new MoodAnalyser("");
                string expected = "Mood should not be empty";
                try
                {
                    //Act
                    string actual = mood.Analyser();
                }
                catch (MoodAnalyserException exception)
                {
                    //Asert
                    Assert.AreEqual(expected, exception.Message);
                }
            }
        }
    }
}