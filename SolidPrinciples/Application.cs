
namespace SolidPrinciples
{
    public class Application
    {
        private IMessageReader _messageReader;
        private IMessageWriter _messageWriter;

        public Application(IMessageReader messageReader, IMessageWriter messageWriter)
        {
            _messageReader = messageReader;
            _messageWriter = messageWriter;
        }

        public void Run()
        {
            _messageWriter.Write(_messageReader.ReadMessage());
        }
    }
}