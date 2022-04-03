using System.Threading.Channels;

namespace ConsoleApplication1
{
    internal class Channel<T>
    {
        public ChannelWriter<string> Writer { get; internal set; }
    }
}