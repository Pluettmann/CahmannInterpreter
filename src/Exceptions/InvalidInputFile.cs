using System;

namespace Cahmann.Interpreter.Exceptions {

    using System.IO;

    /// <summary>
    /// An exception that may be thrown when an invalid input file is passed to the interpreter.
    /// </summary>
    public class InvalidInputFile: IOException {
        public InvalidInputFile(string message) : base(message) { }

        public InvalidInputFile(string message, Exception innerException) : base(message, innerException) { }

        public InvalidInputFile() { }
    }
}
