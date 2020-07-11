using System;
using System.IO;

namespace Cahmann.Interpreter.Token {

    /// <summary>
    /// Represents a special token.
    /// </summary>
    public class SpecialToken : IToken {

        #region Variables
        SpecialTokenType _tokenType;
        string _tokenString;
        FileInfo _file;
        int _line;
        int _posInLine;
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public SpecialToken() { }

        /// <summary>
        /// Preferred constructor.
        /// </summary>
        /// <param name="type">The operator type</param>
        /// <param name="tokenString">The string representation of the operator</param>
        /// <param name="sourceFile">The source file in which this token is located</param>
        /// <param name="line">The line in the file this token is located</param>
        /// <param name="posInLine">The position in the line where this token is located.</param>
        public SpecialToken(SpecialTokenType type, string tokenString, FileInfo sourceFile, int line, int posInLine) {
            _tokenType = type;
            _tokenString = tokenString;
            _file = sourceFile;
            _line = line;
            _posInLine = posInLine;
        }

        #region IToken
        /// <inheritdoc/>
        public Enum TokenType {
            get => _tokenType;
            set {
                if (value is SpecialTokenType type) {
                    _tokenType = type;
                } else throw new ArgumentException($"Cannot convert { value?.GetType().Name } to { nameof(SpecialTokenType) }");
            }
        }

        /// <inheritdoc>/>
        public string StringRepresentation { get => _tokenString; set => _tokenString = value; }

        /// <inheritdoc/>
        public FileInfo SourceFile { get => _file; set => _file = value; }

        /// <inheritdoc/>
        public int Line { get => _line; set => _line = value; }

        /// <inheritdoc>/>
        public int PositionInLine { get => _posInLine; set => _posInLine = value; }
        #endregion
    }
}
