using System;

namespace Cahmann.Interpreter.Token {

    using System.IO;

    /// <summary>
    /// represents any from of operator e.g. +,-,*,/ and so on
    /// </summary>
    public class OperatorToken: IToken {

        #region Variables
        OperatorType _tokenType;
        string _operatorString;
        FileInfo _file;
        int _line;
        int _posInLine;
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public OperatorToken() { }

        /// <summary>
        /// Preferred constructor.
        /// </summary>
        /// <param name="type">The operator type</param>
        /// <param name="tokenString">The string representation of the operator</param>
        /// <param name="sourceFile">The source file in which this token is located</param>
        /// <param name="line">The line in the file this token is located</param>
        /// <param name="posInLine">The position in the line where this token is located.</param>
        public OperatorToken(OperatorType type, string tokenString, FileInfo sourceFile, int line, int posInLine) {
            _tokenType = type;
            _operatorString = tokenString;
            _file = sourceFile;
            _line = line;
            _posInLine = posInLine;
        }

        #region IToken
        /// <inheritdoc/>
        public Enum TokenType {
            get => _tokenType;
            set {
                if (value is OperatorType type) {
                    _tokenType = type;
                } else throw new ArgumentException($"Cannot convert { value?.GetType().Name } to { nameof(OperatorType) }");
            }
        }

        /// <inheritdoc>/>
        public string StringRepresentation { get => _operatorString; set => _operatorString = value; }

        /// <inheritdoc/>
        public FileInfo SourceFile { get => _file; set => _file = value; }

        /// <inheritdoc/>
        public int Line { get => _line; set => _line = value; }

        /// <inheritdoc>/>
        public int PositionInLine { get => _posInLine; set => _posInLine = value; }
        #endregion
    }
}
