using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IJsonFilePath"/>
    [StrongTypeImplementationMarker]
    public class JsonFilePath : TypedBase<string>, IStrongTypeMarker,
        IJsonFilePath
    {
        public JsonFilePath(string value)
            : base(value)
        {
        }
    }
}