using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IFileExtension"/>
    [StrongTypeImplementationMarker]
    public class FileExtension : TypedBase<string>, IStrongTypeMarker,
        IFileExtension
    {
        public FileExtension(string value)
            : base(value)
        {
        }
    }
}