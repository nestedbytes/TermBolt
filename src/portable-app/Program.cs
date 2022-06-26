using System;
using System.Net;



namespace TermBolt{
	class Program {
		static void Main(string[] args)
		{
				System.Net.WebClient wc = new System.Net.WebClient();
				WebClient DownClient = new WebClient ();
Console.Title = "TermBolt";
while (true) 
{
string latver = wc.DownloadString("https://raw.githubusercontent.com/shourgamer2/TermBolt/main/version.txt");
if (latver.Trim().Contains("1.1.0") == true) {
	Console.Write("    ");

}
else 
{
	Console.WriteLine("Version outdated go to https://github.com/shourgamer2/TermBolt to download");
}

string userName = Environment.UserName;
Console.Write(userName + "@" + "TermBolt:");

string inputpr = Console.ReadLine();
if (inputpr.Contains("help") == true) {
   Console.WriteLine("Commands. exit = closes the window | help = Get help and list of commands | about = about this terminal ! | wfd = download file from web ");
}
if (inputpr.Contains("exit") == true) {
   Environment.Exit(0);
}

if (inputpr.Contains("about") == true) {
Console.WriteLine("Termbolt is a fast and usefull terminal | GitHub: https://github.com/shourgamer2/TermBolt");

}
if (inputpr.Contains("wfd") == true) {
Console.Write("Enter The Url:");
string durl = Console.ReadLine();
Console.Write("Enter The Folder and the filename you want to download:");
string dir = Console.ReadLine();
DownClient.DownloadFile(durl,dir);
Console.Write("File is downloaded" + dir);


  


}
}
		}
	}
}