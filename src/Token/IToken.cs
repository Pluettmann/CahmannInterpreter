using System;

namespace Cahmann.Interpreter.Token {

    /// <summary>
    /// Base Token type.
    /// </summary>
    public interface IToken {

        /// <summary>
        /// Gets or sets the token type.
        /// </summary>
        Enum TokenType { get; set; }

    }
}
