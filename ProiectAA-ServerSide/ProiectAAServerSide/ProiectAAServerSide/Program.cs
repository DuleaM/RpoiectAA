using System;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace ProiectAAServerSide
{
    class MainClass
    {
        public static void Run(IPAddress IP, int PORT)
        {
            TcpListener listener = null;

            try
            {
                listener = new TcpListener(IP, PORT);
                listener.Start();

                while (true)
                {
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("[+] Request confirmed. ");

                    Thread handleClient = new Thread(new ParameterizedThreadStart(handleClientRequest));
                    handleClient.Start(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Eroare: " + e.Message);
            }
            finally
            {
                listener.Stop();
            }
        }

        public static void handleClientRequest(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();

            StreamReader streamReader = new StreamReader(stream);
            StreamWriter streamWriter = new StreamWriter(stream);

            string command = streamReader.ReadLine();
            Console.WriteLine("Received command: " + command);

            try
            {
                ProcessStartInfo simulate = new ProcessStartInfo();
                simulate.FileName = "/bin/bash";
                simulate.Arguments = "-c \"ls\"";
                simulate.UseShellExecute = false;
                simulate.RedirectStandardOutput = true;

                using (Process process = Process.Start(simulate))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    // Console.WriteLine("Output of ls: " + output);

                    streamWriter.WriteLine(output);
                    streamWriter.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Eroare: " + e.Message);
            }
            finally
            {
                streamWriter.Close();
                streamReader.Close();
                stream.Close();
                client.Close();
            }
        }

        public static void Main(string[] args)
        {
            IPAddress IP = IPAddress.Parse("127.0.0.1");
            int PORT = 8000;

            Thread serverThread = new Thread(() => Run(IP, PORT));
            serverThread.Start();
            Console.WriteLine($"Server started. Listening for requests at {IP}:{PORT}");
        }
    }
}
