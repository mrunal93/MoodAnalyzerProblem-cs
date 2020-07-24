using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalysis
    {
        private string message;

        public MoodAnalysis()
        {
        }

        public MoodAnalysis (string message)
        {
            this.message = message;
        }
        public string AnalysisOfMood(string message)
        {
            try
            {
                if (message.Length == 0)
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EnterEmpty, "Please Enter Proper Message");
                
                if (message.Contains("Sad"))

                    return "Sad";
                return "Happy";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.EnterNull, "Please Entered Proper Mood");
            }
        }
    }
}
