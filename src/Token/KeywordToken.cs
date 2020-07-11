using System;
using System.IO;

namespace Cahmann.Interpreter.Token {
    /// <summary>
    /// represents a collection of keywords that are interpreted into C# code
    /// </summary>
    public class KeywordToken: IToken {

        #region Variables
        KeywordType _tokenType;
        string _keywordString;
        FileInfo _file;
        int _line;
        int _posInLine;
        #endregion

        /// <summary>
        /// Default constructor
        /// </summary>
        public KeywordToken() { }

        /// <summary>
        /// Preferred constructor.
        /// </summary>
        /// <param name="type">The keyword type</param>
        /// <param name="keyword">The keyword as a string</param>
        /// <param name="sourceFile">The source file being parsed</param>
        /// <param name="line">The line in the file currently being parsed</param>
        /// <param name="positionInLine">The position in the line where the keyword is located at.</param>
        public KeywordToken(KeywordType type, string keyword, FileInfo sourceFile, int line, int positionInLine) {
            _tokenType = type;
            _keywordString = keyword;
            _file = sourceFile;
            _line = line;
            _posInLine = positionInLine;
        }

        #region IToken
        /// <inheritdoc/>
        public Enum TokenType { 
            get => _tokenType;
            set {
                if (value is KeywordType type) {
                    _tokenType = type;
                } else throw new ArgumentException($"Cannot convert { value?.GetType().Name } to { nameof(KeywordType) }");
            }
        }

        /// <inheritdoc>/>
        public string StringRepresentation { get => _keywordString; set => _keywordString = value; }

        /// <inheritdoc/>
        public FileInfo SourceFile { get => _file; set => _file = value; }

        /// <inheritdoc/>
        public int Line { get => _line; set => _line = value; }

        /// <inheritdoc>/>
        public int PositionInLine { get => _posInLine; set => _posInLine = value; }
        #endregion
    }
}
