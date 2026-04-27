## Nmap simulation using C#

Overview
--------
This is a small C# console project that demonstrates a simple simulation of an Nmap-like scan. It can obtain the local machine's IPv4 address and prints a short scan report. The project is educational and intended to show basic async programming and TCP port probing techniques.

Important Notice / Legal
------------------------
Do NOT use this tool to scan devices you do not own or do not have explicit permission to test. Unauthorized port scanning may be illegal and/or violate acceptable use policies.

Building and running
---------------------
Requirements:
- .NET SDK 10 (or compatible) or Visual Studio 2026

To build and run from the command line:
1. Open a terminal in the project directory (the folder that contains the .cs file).
2. Run: dotnet build
3. To run and scan the local machine: dotnet run --project "Nmap simulation by C#" 
4. To run and scan a specific target IP: dotnet run --project "Nmap simulation by C#" -- 192.0.2.1



Contact / Attribution
----------------------
Developer name: Abd Alrhman Hourani
Developer email: AbdAYaser24@gmail.com
