using System;

namespace Cahmann.Interpreter {

    using Exceptions;
    using Models;
    using static Resources.Translations_EN;

    using static System.Console;
    using System.IO;
    using System.Diagnostics.CodeAnalysis;

    class Program {

        public const string CahmannFileExt1 = ".cms";
        public const string CahmannFileExt2 = ".cmi";
        public const string CahmannFileExt3 = ".cmc";

        public const string CahmannPrompt = "cmi >";
        public const string CahmannPromptExit = "exit";

        static int Main(string[] args) {
            if (args.Length == 0) {
                return RunPrompt();
            }

            // TODO: Handle args
            // For now assume that all args are .cms files
            foreach (var file in args) {
                if (!File.Exists(Path.GetFullPath(file))) {
                    throw new InvalidInputFile(string.Format(ErrorMsg_FileNotFound, Path.GetFullPath(file)));
                }

                var inputCode = ReadFileIntoMemory(file);
                var lexer = new Lexer(inputCode);
                WriteLine(lexer.ToString());
                WriteLine(); WriteLine(); WriteLine();
                lexer.StripComments();
                WriteLine(lexer.ToString());
            }

            return 0;
        }

        [SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "It's a prompt...")]
        [SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Can't catch 'em all!")]
        static int RunPrompt() {
            bool keepAlive = true;
            var line = default(string);

            while (keepAlive && !(line = ReadLine()).Equals(CahmannPromptExit, StringComparison.InvariantCultureIgnoreCase)) {
                try {
                    Lexer.RunSingleLine(line);
                } catch (Exception ex) {
                    Error.WriteLine($"Failed to execute! Reason: { ex.Message }");
                }

                Write(CahmannPrompt);
            }

            return 0;
        }

        static string ReadFileIntoMemory(string file) => File.ReadAllText(file);

    }
}
