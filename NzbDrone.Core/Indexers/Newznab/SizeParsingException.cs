﻿using NzbDrone.Common.Exceptions;

namespace NzbDrone.Core.Indexers.Newznab
{
    public class SizeParsingException : NzbDroneException
    {
        public SizeParsingException(string message, params object[] args) : base(message, args)
        {
        }
    }
}
