using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <summary>
    /// Strongly-types a string as a %%%.
    /// </summary>
    [StrongTypeMarker]
    public interface IXmlFilePath : IStrongTypeMarker,
        ITyped<string>
    {
    }
}