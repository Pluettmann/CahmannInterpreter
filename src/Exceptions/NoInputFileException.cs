using System;

namespace Cahmann.Interpreter.Exceptions {

    using System.IO;

    /// <summary>
    /// An exception which may be thrown when no input file is given to the interpreter.
    /// </summary>
    public class NoInputFileException: IOException {
        public NoInputFileException(string message): base(message) { }

        public NoInputFileException(string message, Exception innerException): base(message, innerException) { }

        public NoInputFileException() { }
    }
}
