using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ProiectAA
{
    public static class Consumer
    {
        private static TcpClient client = null;
        private static NetworkStream stream = null;
        private static StreamReader streamReader = null;
        private static StreamWriter streamWriter = null;
        private static Thread wait_response_thread = null;

        public static void start_connection(string hostname, int port)
        {
            client = new TcpClient(hostname, port);
            stream = client.GetStream();
            streamReader = new StreamReader(stream);
            streamWriter = new StreamWriter(stream);
        }

        public static void close_connection()
        {
            client.Close();
            stream.Close();
        }

        public static void send_command_to_server(string command)
        {
            streamWriter.WriteLine(command);
            streamWriter.Flush();

        }

        public static string get_output_from_server()
        {
            string output = streamReader.ReadLine();
            return output;
        }
    }
}
