using System;
using System.Threading.Tasks;
using System.Net;
using System.Linq;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Threading;


namespace NmapSimulator
{
    class Program
    {
        // Pre-defined example ports (kept for demo output). The project will be extended
        // to detect real open ports before exporting results.
        enum enOpenPorts { DNS = 53, Telnet = 21, IMAP = 110, HTTP = 80, FTP = 23 }

       
        /// Prints a short simulated nmap-like report for the provided IP.
      
        public static async Task Scan_Target(string target_ip)
        {
            int delay_time = 2000; // simulate a short scan duration
            Console.WriteLine("Scanning the target...");
            await Task.Delay(delay_time);
            Console.WriteLine($"Nmap scan report for the target ip {target_ip} at port 80");
            Console.WriteLine($"Scanned for {delay_time} ms");
            Console.WriteLine("Open ports:");
            Console.WriteLine($"{enOpenPorts.DNS} open at port {(int)enOpenPorts.DNS} \n{enOpenPorts.Telnet} open at port {(int)enOpenPorts.Telnet} \n{enOpenPorts.IMAP} open at port {(int)enOpenPorts.IMAP} \n{enOpenPorts.FTP} open at port {(int)enOpenPorts.FTP}");
        }

        
        /// Returns the first IPv4 address of the current machine.
        /// Throws an exception if no IPv4 address is available.
        
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            var ip = host.AddressList.FirstOrDefault(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            if (ip == null)
                throw new Exception("No network adapters with an IPv4 address in the system.");
            return ip.ToString();
        }

       
        /// Program entry point.
        /// Usage: dotnet run -- [target-ip]
        /// If no ip is provided the program will use the local machine IP.
        /// WARNING: Only scan devices you own or are authorized to test.

        public static async Task Main(string[] args)
        {
            try
            {
                string targetIp;
                if (args.Length > 0 && !string.IsNullOrWhiteSpace(args[0]))
                {
                    targetIp = args[0];
                }
                else
                {
                    targetIp = GetLocalIPAddress();
                }

                await Scan_Target(targetIp);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error: {ex.Message}");
                Environment.ExitCode = 1;
            }
        }
    }
}
