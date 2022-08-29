﻿using System.Runtime.Serialization;

namespace MSTestMoodAnalyzer
{
    [Serializable]
    internal class MoodAnalyserException : Exception
    {
        public MoodAnalyserException()
        {
        }

        public MoodAnalyserException(string? message) : base(message)
        {
        }

        public MoodAnalyserException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MoodAnalyserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}