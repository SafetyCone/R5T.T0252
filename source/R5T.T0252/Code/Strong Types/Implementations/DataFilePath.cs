using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0252
{
    /// <inheritdoc cref="IDataFilePath"/>
    [StrongTypeImplementationMarker]
    public class DataFilePath : TypedBase<string>, IStrongTypeMarker,
        IDataFilePath
    {
        public DataFilePath(string value)
            : base(value)
        {
        }
    }
}