using MoodAnalyzer;
using NUnit.Framework;
using System.Reflection.Metadata;

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
        [Test]
        public void GivenSadMessageNull_WhenAnalyse_ShouldThrowException()
        {
            try
            {
                MoodAnalyzer.MoodAnalysis moodAnalysis = new MoodAnalyzer.MoodAnalysis();
                string mood = moodAnalysis.AnalysisOfMood(null);
            }
            catch(MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.EnterNull, e.Type);
            }
        }
        [Test]
        public void GivenSadMessageEmpty_WhenAnalyse_ShouldThrowException()
        {
            try
            {
                MoodAnalyzer.MoodAnalysis moodAnalysis = new MoodAnalyzer.MoodAnalysis();
                string mood = moodAnalysis.AnalysisOfMood(" ");
            }
            catch (MoodAnalyzerException e)
            {
                Assert.AreEqual(MoodAnalyzerException.ExceptionType.EnterEmpty, e.Type);
            }
        }
    }
}