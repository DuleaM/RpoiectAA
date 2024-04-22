using System;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;
using System.Linq;

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

        static string generateOutputFilename(string outputDir)
        {
            string currentDateHour = DateTime.Now.ToString("ddMMyyyy_HH:mm:ss");
            return $"output_{currentDateHour}";
        }

        static string getLastCreatedFile(string path)
        {
            string[] files = Directory.GetFiles(path, "output_*.res").OrderByDescending(f => new FileInfo(f).CreationTime).ToArray();

            if (files.Length > 0)
            {
                return files[0];
            }
            return null;
        }


        public static void handleClientRequest(object obj)
        {
            //PATHS, FILENAMES
            string outputDir = "outputs";
            string ssDir = "benchs/ss";
            string inDir = "benchs/in";

            // string projectPath = Directory.GetCurrentDirectory();
            // string simPath = Path.Combine(projectPath, "sim/sim-outorder");

            string outputFilename = generateOutputFilename(outputDir);

            // NETWORK STUFF
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();

            StreamReader streamReader = new StreamReader(stream);
            StreamWriter streamWriter = new StreamWriter(stream);

            // ARGS RECEIVED FROM CLIENT
            string sim_args_raw = streamReader.ReadLine();

            int ssIndex = sim_args_raw.LastIndexOf("/");
            string benchmark = sim_args_raw.Substring(ssIndex + 1);

            string sim_args = sim_args_raw.Replace("{OutputFile}", Path.Combine(outputDir, outputFilename))
                                           .Replace("{benchmark_path}", ssDir)
                                           + $" < {inDir}/{benchmark}";

            Console.WriteLine("\n[+] Received args: " + sim_args_raw);
            Console.WriteLine("\n[+] Will execute: sim-outorder " + sim_args);

            try
            {
                ProcessStartInfo simulate = new ProcessStartInfo();
                simulate.FileName = "/home/licenta/AA/PROIECT/RpoiectAA/ProiectAA-ServerSide/ProiectAAServerSide/sim/sim-outorder";
                simulate.Arguments = $"{sim_args}";
                simulate.UseShellExecute = false;
                simulate.RedirectStandardOutput = true;
                simulate.RedirectStandardError = true;

                using (Process process = Process.Start(simulate))
                {
                    //streamWriter.WriteLine(output);
                    //streamWriter.Flush();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n[-] ERR: " + e.Message);
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
