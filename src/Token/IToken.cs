using System;

namespace Cahmann.Interpreter.Token {

    using System.IO;

    /// <summary>
    /// Base Token type.
    /// </summary>
    public interface IToken {

        /// <summary>
        /// Gets or sets the token type.
        /// </summary>
        Enum TokenType { get; set; }

        /// <summary>
        /// A string representing the token.
        /// </summary>
        string StringRepresentation { get; set; }

        /// <summary>
        /// Gets or sets the file in which the code is located.
        /// </summary>
        FileInfo SourceFile { get; set; }

        /// <summary>
        /// Gets the line number in the file 
        /// </summary>
        int Line { get; set; }

        /// <summary>
        /// Gets the position in <see cref="Line"/> in <see cref="SourceFile"/>
        /// </summary>
        int PositionInLine { get; set; }

    }
}
