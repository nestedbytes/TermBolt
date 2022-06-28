using System;
using System.Net;
using System.Net.NetworkInformation;



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
if (latver.Trim().Contains("2.0.0") == true) {
	Console.WriteLine("    ");

}
else 
{
	Console.WriteLine("Version outdated go to https://github.com/shourgamer2/TermBolt to download");
}

string userName = Environment.UserName;
Console.Write(userName + "@" + "TermBolt:");

string inputpr = Console.ReadLine();
if (inputpr.Contains("help") == true) {
   Console.WriteLine("Commands. exit = closes the window | help = Get help and list of commands | about = about this terminal ! | wfd = download file from web | wping = ping a url or a site ");
}
if (inputpr.Contains("exit") == true) {
   Environment.Exit(0);
}

if (inputpr.Contains("about") == true) {
Console.WriteLine("Termbolt is a fast and usefull terminal | GitHub: https://github.com/shourgamer2/TermBolt");

}
if (inputpr.Contains("wfd") == true) {
Console.WriteLine("Enter The Url:");
string durl = Console.ReadLine();
Console.WriteLine("Enter The Folder and the filename you want to download:");
string dir = Console.ReadLine();
DownClient.DownloadFile(durl,dir);
Console.WriteLine("File is downloaded" + dir);



  


}
if (inputpr.Contains("wping") == true) {
Console.WriteLine("Enter ip or url you want to ping.");
string ip = Console.ReadLine();
Ping wpingob = new Ping();
PingReply reply = wpingob.Send(ip);
Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);



}
		}
	}
	}
}