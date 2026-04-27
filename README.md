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
1. Open a terminal in the project directory (the folder that contains the .csproj file).
2. Run: dotnet build
3. To run and scan the local machine: dotnet run --project "Nmap simulation by C#" 
4. To run and scan a specific target IP: dotnet run --project "Nmap simulation by C#" -- 192.0.2.1

Project layout recommendations before publishing to GitHub
--------------------------------------------------------
- Rename the folder to remove spaces (for example: `NmapSimulator`).
- Add a proper `.gitignore` for Visual Studio/.NET projects (GitHub has templates).
- Add a `LICENSE` file (MIT or similar) if you want others to reuse the code.
- Replace or remove any generated files before committing (e.g., build artifacts, bin/, obj/).
- Consider renaming the namespace to match the project name (already set to `NmapSimulator`).

What to improve (suggestions)
-----------------------------
- Implement a real asynchronous TCP port scanner and a safe list of ports to check.
- Add unit tests for helper methods.
- Provide a configuration file for ports and timeouts.
- Add logging and more user-friendly output (JSON, CSV) for results.

Contact / Attribution
----------------------
Created as a small educational example. If you publish to GitHub, add your name and license in the repository README and LICENSE files.
