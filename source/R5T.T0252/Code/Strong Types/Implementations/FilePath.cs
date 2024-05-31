using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IFilePath"/>
    [StrongTypeImplementationMarker]
    public class FilePath : TypedBase<string>, IStrongTypeMarker,
        IFilePath
    {
        public FilePath(string value)
            : base(value)
        {
        }
    }
}