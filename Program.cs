using System;



namespace TermBolt{
	class Program {
		static void Main(string[] args)
		{
				System.Net.WebClient wc = new System.Net.WebClient();
Console.Title = "TermBolt";
while (true) 
{
string latver = wc.DownloadString("https://raw.githubusercontent.com/shourgamer2/TermBolt/main/version.txt");
if (latver.Trim().Contains("1.0.0") == true) {
	Console.WriteLine("1.0.0");

}
else 
{
	Console.WriteLine("Version outdated go to https://github.com/shourgamer2/TermBolt to download");
}

string userName = Environment.UserName;
Console.Write(userName + "@" + "TermBolt:");

string inputpr = Console.ReadLine();
if (inputpr.Contains("help") == true) {
   Console.WriteLine("Commands. exit = closes the window | help = Get help and list of commands | about = about this terminal ! ");
}
if (inputpr.Contains("exit") == true) {
   Environment.Exit(0);
}

if (inputpr.Contains("about") == true) {
Console.WriteLine("Termbolt is a fast and usefull terminal | GitHub: https://github.com/shourgamer2/TermBolt");

}
}
		}
	}
}