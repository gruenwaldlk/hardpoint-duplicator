﻿using System;
using System.Runtime.Serialization;

namespace eaw.hardpointduplicator.core.exception
{
    class MissingReplacementPatternException : Exception
    {
        public MissingReplacementPatternException()
        {
        }

        public MissingReplacementPatternException(string message) : base(message)
        {
        }

        public MissingReplacementPatternException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MissingReplacementPatternException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
