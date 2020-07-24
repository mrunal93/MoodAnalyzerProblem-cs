using NUnit.Framework;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        

        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyzer.MoodAnalysis moodAnalysis = new MoodAnalyzer.MoodAnalysis();
            string mood = moodAnalysis.AnalysisOfMood("This is Sad message");
            Assert.AreEqual("Sad", mood);

        }
        [Test]
        public void GivenSadMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyzer.MoodAnalysis moodAnalysis = new MoodAnalyzer.MoodAnalysis();
            string mood = moodAnalysis.AnalysisOfMood("This is Happy message");
            Assert.AreEqual("Happy", mood);

        }
    }
}