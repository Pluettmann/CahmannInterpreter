using System;
using System.Collections.Generic;
using System.Text;

namespace Cahmann.Interpreter.Models {

    using Token;

    using System.IO;
    using System.Text.RegularExpressions;

    /// <summary>
    /// 
    /// </summary>
    public class Lexer {

        #region Static Methods
        /// <summary>
        /// Runs a single line of Cahmann Script. Preferrably from the prompt.
        /// </summary>
        /// <param name="line">The line of code to execute.</param>
        /// <returns>The return value of the line of code.</returns>
        public static object RunSingleLine(string line) {
            throw new NotImplementedException();
        }
        #endregion

        #region Static Variables and Initialisation
        static Lexer() {
            SingleLineCommentRegex = new Regex(
                @"([#]+[^\n]+)|(([/]{2,}|[-]{2,})[^\n]+)",
                RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Singleline
            );

            MultiLineCommentRegex = new Regex(
                @"((?s)/\*.*?\*/)|((?s)--\[\[.*?\]\])",
                RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase | RegexOptions.Multiline
            );

            // Function head regex: (((local|module)\s+)?func\s+([A-z_][A-z0-9_]+)[\(][\s]*([A-z_][A-z_0-9]*(,([\s]*[A-z_][A-z_0-9]*)*)*)*[\s]*[\)])(\s*(noret|ret\s*(int|string)))?[\s]*[\n]

            VariableNameRegex = new Regex(
                @"([A-z_][A-z0-9_]*)",
                RegexOptions.Compiled | RegexOptions.CultureInvariant
            );

            FunctionNameRegex = new Regex(
                @"([A-z_][A-z0-9_]*)",
                RegexOptions.Compiled | RegexOptions.CultureInvariant
            );
        }

        private static Regex SingleLineCommentRegex { get; }

        private static Regex MultiLineCommentRegex { get; }

        private static Regex VariableNameRegex { get; }

        private static Regex FunctionNameRegex { get; }
        #endregion

        #region Properties
        /// <summary>
        /// A list containing all tokens parsed by the Lexer.
        /// </summary>
        public List<IToken> Tokens { get; private set; }

        /// <summary>
        /// Gets the current (character) token.
        /// </summary>
        public int TokenIndex { get; private set; }

        /// <summary>
        /// Gets the current line in the source file being parsed.
        /// </summary>
        public int CurrentLine { get; private set; }

        /// <summary>
        /// Indicates whether or not the end of the code file has been reached.
        /// </summary>
        public bool EndOfCode => TokenIndex >= _input.Length;

        /// <summary>
        /// Gets the character currently being parsed.
        /// </summary>
        public char CurrentChar { get; private set; }
        #endregion

        #region Construction
        /// <summary>
        /// Lexer's constructor.
        /// </summary>
        /// <param name="inputFile"></param>
        public Lexer(FileInfo inputFile) {
            _inputFile = inputFile;
            _input = inputFile.ReadAllText();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Strips all the comments from a given Cahmann source file.
        /// </summary>
        public void StripComments() {
            _input = SingleLineCommentRegex.Replace(_input, string.Empty);
            _input = MultiLineCommentRegex.Replace(_input, string.Empty);
        }

        /// <summary>
        /// Begins parsing the provided source code file
        /// </summary>
        public void BeginParsing() {
            using (var sReader = new SourceReader(_input)) {
                while (sReader.Peek() != -1) {
                    ScanToken(sReader);
                }
            }

            // Note end of file
            Tokens.Add(new SpecialToken(SpecialTokenType.EndOfFile, null, _inputFile, -1, -1));
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// Gets the next character from the input string
        /// </summary>
        /// <returns>The next character</returns>
        protected char GetNext() => _input[TokenIndex++];
        #endregion

        #region Overrides
        protected void ScanToken(SourceReader tokenReader) {
            char currentChar = (char)tokenReader?.Read();
            // Scan for operators first
            switch (currentChar) {
                case '(':
                    if (tokenReader.Peek() == ')') {
                        Tokens.Add(new OperatorToken(OperatorType.FunctionCallOperator, "()", _inputFile, CurrentLine, TokenIndex));
                    } else Tokens.Add(new OperatorToken(OperatorType.FunctionOperatorBegin, currentChar.ToString(), _inputFile, tokenReader.Line, tokenReader.Index)); // This is a bug
                    break;
            }
        }
        #endregion

        #region Private Variables
        private FileInfo _inputFile;
        private string _input;
        #endregion

    }
}
