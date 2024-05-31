using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IHtmlFilePath"/>
    [StrongTypeImplementationMarker]
    public class HtmlFilePath : TypedBase<string>, IStrongTypeMarker,
        IHtmlFilePath
    {
        public HtmlFilePath(string value)
            : base(value)
        {
        }
    }
}