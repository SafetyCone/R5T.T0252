using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.T0252.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IDataFilePath"/>
        public IDataFilePath ToDataFilePath(string value)
        {
            var output = new DataFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IFileExtension"/>
        public IFileExtension ToFileExtension(string value)
        {
            var output = new FileExtension(value);
            return output;
        }

        /// <inheritdoc cref="IFileExtension"/>
        public IEnumerable<IFileExtension> ToFileExtensions(IEnumerable<string> values)
            => values
            .Select(this.ToFileExtension)
            ;

        /// <inheritdoc cref="IFilePath"/>
        public IFilePath ToFilePath(string value)
        {
            var output = new FilePath(value);
            return output;
        }

        /// <inheritdoc cref="IFilePath"/>
        public IEnumerable<IFilePath> ToFilePaths(IEnumerable<string> values)
            => values
            .Select(this.ToFilePath)
            ;

        /// <inheritdoc cref="IFilePath"/>
        public async Task<IFilePath[]> ToFilePaths(Task<string[]> gettingValues)
            => (await gettingValues)
            .Select(this.ToFilePath)
            .ToArray()
            ;

        /// <inheritdoc cref="IHtmlFilePath"/>
        public IHtmlFilePath ToHtmlFilePath(string value)
        {
            var output = new HtmlFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IJsonFilePath"/>
        public IJsonFilePath ToJsonFilePath(string value)
        {
            var output = new JsonFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ILogFilePath"/>
        public ILogFilePath ToLogFilePath(string value)
        {
            var output = new LogFilePath(value);
            return output;
        }

        /// <inheritdoc cref="ITextFilePath"/>
        public ITextFilePath ToTextFilePath(string value)
        {
            var output = new TextFilePath(value);
            return output;
        }

        /// <inheritdoc cref="IXmlFilePath"/>
        public IXmlFilePath ToXmlFilePath(string value)
        {
            var output = new XmlFilePath(value);
            return output;
        }
    }
}
