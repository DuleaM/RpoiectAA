using System;
using System.IO;
using System.Net.Sockets;

namespace ProiectAA
{
    public static class Consumer
    {
        private static TcpClient client = null;
        private static NetworkStream stream = null;
        private static StreamReader streamReader = null;
        private static StreamWriter streamWriter = null;

        public static void start_connection()
        {
            client = new TcpClient("localhost", 8000);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
        }

        public static void close_connection()
        {
            client.Close();
            stream.Close();
        }
    }
}
