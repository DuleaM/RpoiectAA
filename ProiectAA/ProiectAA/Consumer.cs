using System;

using Gtk;
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

        public static string server_output { get; set; }
        public static Thread threadReceiveMessage = new Thread(new ThreadStart(get_output_from_server));

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

        public static void get_output_from_server()
        {
            server_output = "";
            
            while (true)
            {
                server_output = streamReader.ReadLine();

            }

        }
    }
}
