using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="ILogFilePath"/>
    [StrongTypeImplementationMarker]
    public class LogFilePath : TypedBase<string>, IStrongTypeMarker,
        ILogFilePath
    {
        public LogFilePath(string value)
            : base(value)
        {
        }
    }
}