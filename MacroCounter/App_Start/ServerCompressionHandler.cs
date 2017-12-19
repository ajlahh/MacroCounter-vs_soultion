using System.Net.Http;

namespace MacroCounter
{
    internal class ServerCompressionHandler : DelegatingHandler
    {
        private DeflateCompressor deflateCompressor;
        private GZipCompressor gZipCompressor;

        public ServerCompressionHandler(GZipCompressor gZipCompressor, DeflateCompressor deflateCompressor)
        {
            this.gZipCompressor = gZipCompressor;
            this.deflateCompressor = deflateCompressor;
        }
    }
}