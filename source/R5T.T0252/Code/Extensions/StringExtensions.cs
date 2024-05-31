using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R5T.T0252.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDataFilePath(string)"/>
        public static IDataFilePath ToDataFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDataFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToFileExtension(string)"/>
        public static IFileExtension ToFileExtension(this string value)
            => Instances.StringOperator_Extensions.ToFileExtension(value);

        /// <inheritdoc cref="IStringOperator.ToFileExtensions(IEnumerable{string})"/>
        public static IEnumerable<IFileExtension> ToFileExtensions(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToFileExtensions(values);

        /// <inheritdoc cref="IStringOperator.ToFilePath(string)"/>
        public static IFilePath ToFilePath(this string value)
            => Instances.StringOperator_Extensions.ToFilePath(value);

        /// <inheritdoc cref="IStringOperator.ToFilePaths(IEnumerable{string})"/>
        public static IEnumerable<IFilePath> ToFilePaths(this IEnumerable<string> values)
            => Instances.StringOperator_Extensions.ToFilePaths(values);

        /// <inheritdoc cref="IStringOperator.ToFilePaths(IEnumerable{string})"/>
        public static Task<IFilePath[]> ToFilePaths(this Task<string[]> gettingValues)
            => Instances.StringOperator_Extensions.ToFilePaths(gettingValues);

        /// <inheritdoc cref="IStringOperator.ToHtmlFilePath(string)"/>
        public static IHtmlFilePath ToHtmlFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToHtmlFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToJsonFilePath(string)"/>
        public static IJsonFilePath ToJsonFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToJsonFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToLogFilePath(string)"/>
        public static ILogFilePath ToLogFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToLogFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToTextFilePath(string)"/>
        public static ITextFilePath ToTextFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToTextFilePath(value);
        }

        /// <inheritdoc cref="IStringOperator.ToXmlFilePath(string)"/>
        public static IXmlFilePath ToXmlFilePath(this string value)
        {
            return Instances.StringOperator_Extensions.ToXmlFilePath(value);
        }
    }
}
