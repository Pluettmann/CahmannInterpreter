using System;

namespace Cahmann.Interpreter {

    using System.IO;

    /// <summary>
    /// Contains extension methods used throughout the interpreter.
    /// </summary>
    public static class Extensions {

        /// <summary>
        /// Reads all the text from a <see cref="FileInfo"/> object.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The entire contents of a file as a string</returns>
        public static string ReadAllText(this FileInfo file) => File.ReadAllText(file?.FullName);

    }
}
