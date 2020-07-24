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
                if (message.Contains("Sad"))

                    return "Sad";
                return "Happy";
            }
            catch(NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
