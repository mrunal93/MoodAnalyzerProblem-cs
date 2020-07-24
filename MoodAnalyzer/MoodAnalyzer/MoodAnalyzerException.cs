using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyzerException : Exception
    {
        public enum ExceptionType
        {
            EnterNull,EnterEmpty
        }
        public ExceptionType Type { get; set; }

        public MoodAnalyzerException(ExceptionType Type,string message) : base(message)
        {
            this.Type = Type;
        }
    }
}
