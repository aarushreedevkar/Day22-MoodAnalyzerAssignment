namespace MSTestMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            void Class_is_not_Proper_Throw_An_Exceptioon()
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
