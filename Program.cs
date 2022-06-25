	System.Net.WebClient wc = new System.Net.WebClient();
string webData = wc.DownloadString("");
while (true) 
{

  // code block to be executed
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