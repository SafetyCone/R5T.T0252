using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IXmlFilePath"/>
    [StrongTypeImplementationMarker]
    public class XmlFilePath : TypedBase<string>, IStrongTypeMarker,
        IXmlFilePath
    {
        public XmlFilePath(string value)
            : base(value)
        {
        }
    }
}