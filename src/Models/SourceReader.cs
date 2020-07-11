using System;

namespace Cahmann.Interpreter.Models {

    using System.Linq;
    using System.IO;
    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// A new class specifically for the needs of this interpreter.
    /// </summary>
    public class SourceReader : StringReader {

        /// <summary>
        /// Gets the current index of the string.
        /// </summary>
        public int Index { get; private set; } = 0;

        /// <summary>
        /// Gets the current line
        /// </summary>
        public int Line { get; private set; } = 0;

        /// <inheritdoc/>
        public SourceReader(string s): base(s) { }

        /// <inheritdoc/>
        public override int Read() {
            Index++;
            int curChar = base.Read();

            if (curChar == '\n') Line++;

            return curChar;
        }


        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0059:Unnecessary assignment of a value", Justification = "Is handled by base class")]
        public override int Read(char[] buffer, int index, int count) {
            var readChars = base.Read(buffer, index, count);

            Index += Index;
            Line += buffer?.Count(x => x == '\n') ?? 0;

            return readChars;
        }

        /// <inheritdoc/>
        public override int Read(Span<char> buffer) {
            var readChars = base.Read(buffer);

            Index += readChars;
            Line += buffer.ToArray().Count(x => x == '\n');

            return readChars;
        }

        /// <inheritdoc/>
        public async override Task<int> ReadAsync(char[] buffer, int index, int count) {
            var returnVal = await base.ReadAsync(buffer, index, count).ConfigureAwait(false);

            Index += returnVal;
            Line += buffer.ToArray().Count(x => x == '\n');

            return returnVal;
        }

        /// <inheritdoc/>
        public async override ValueTask<int> ReadAsync(Memory<char> buffer, CancellationToken cancellationToken = default) {
            var returnVal = await base.ReadAsync(buffer, cancellationToken);

            Index += returnVal;
            Line += buffer.ToArray().Count(x => x == '\n');

            return returnVal;
        }

        /// <inheritdoc/>
        public override int ReadBlock(char[] buffer, int index, int count) {
            var charCount = base.ReadBlock(buffer, index, count);

            Index += charCount;
            Line += buffer.ToArray().Count(x => x == '\n');

            return charCount;
        }

        /// <inheritdoc/>
        public override int ReadBlock(Span<char> buffer) {
            var charCount = base.ReadBlock(buffer);

            Index += charCount;
            Line += buffer.ToArray().Count(x => x == '\n');

            return charCount;
        }

        /// <inheritdoc/>
        public override async Task<int> ReadBlockAsync(char[] buffer, int index, int count) {
            var charCount = await base.ReadBlockAsync(buffer, index, count).ConfigureAwait(false);

            Index += charCount;
            Line += buffer.ToArray().Count(x => x == '\n');

            return charCount;
        }

        /// <inheritdoc/>
        public override async ValueTask<int> ReadBlockAsync(Memory<char> buffer, CancellationToken cancellationToken = default) {
            var charCount = await base.ReadBlockAsync(buffer, cancellationToken).ConfigureAwait(false);

            Index += charCount;
            Line += buffer.ToArray().Count(x => x == '\n');

            return charCount;
        }

        /// <inheritdoc/>
        public override string ReadLine() {
            var line = base.ReadLine();

            Index += line.Length;
            Line++;

            return line;
        }

        /// <inheritdoc/>
        public async override Task<string> ReadLineAsync() {
            var line = await base.ReadLineAsync().ConfigureAwait(false);

            Index += line.Length;
            Line++;

            return line;
        }

        /// <inheritdoc/>
        public override string ReadToEnd() {
            return base.ReadToEnd();
        }

        /// <inheritdoc/>
        public override Task<string> ReadToEndAsync() {
            return base.ReadToEndAsync();
        }

    }
}
