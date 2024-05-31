using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <summary>
    /// Strongly-types a string as the path of a file.
    /// </summary>
    /// <remarks>
    /// No assumption is made about the path or the contents of the file; it could be rooted or relative, a text file or a binary file.
    /// </remarks>
    [StrongTypeMarker]
    public interface IFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}