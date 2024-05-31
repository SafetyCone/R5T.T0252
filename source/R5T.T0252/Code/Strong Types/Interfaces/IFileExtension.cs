using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <summary>
    /// Strongly-types a string as a file-extension.
    /// </summary>
    /// <remarks>
    /// No assumption is made about whether the file-extension value contains the file-extension separator (the initial period).
    /// </remarks>
    [StrongTypeMarker]
    public interface IFileExtension : IStrongTypeMarker,
        ITyped<string>
    {
    }
}