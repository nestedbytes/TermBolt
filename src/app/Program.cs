// Using Tag
using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Diagnostics;

// namespace
namespace TermBolt{
	// Class
	class Program {
	// Main
		static void Main(string[] args)
		{     // Make the webclient and download
				System.Net.WebClient wc = new System.Net.WebClient();
				WebClient DownClient = new WebClient ();
				// Set title
Console.Title = "TermBolt";

// Loop
while (true) 
{
	// Check For updates
	// If on old version 
string latver = wc.DownloadString("https://raw.githubusercontent.com/shourgamer2/TermBolt/main/version.txt");
if (!latver.Trim().Contains("3.1.0") == true) {
	Console.WriteLine("Version outdated go to https://github.com/shourgamer2/TermBolt to download");

}

// Make the console text
string userName = Environment.UserName;
Console.Write(userName + "@" + "TermBolt:");
// Help
string inputpr = Console.ReadLine();
if (inputpr.Contains("help") == true) {
   Console.WriteLine("Commands. exit = closes the window | help = Get help and list of commands | about = about this terminal ! | wfd = download file from web | wping = ping a url or a site | calc = Do maths inside termbolt ! | cclear = Clears the terminal | pcu = Print the current user account's name | strt = start a process");
}
// Exit
if (inputpr.Contains("exit") == true) {
   Environment.Exit(0);
}
// About
if (inputpr.Contains("about") == true) {
Console.WriteLine("Termbolt is a fast and usefull terminal | GitHub: https://github.com/shourgamer2/TermBolt");

}

// wfd
if (inputpr.Contains("wfd") == true) {
Console.WriteLine("Enter The Url:");
string durl = Console.ReadLine();
Console.WriteLine("Enter The Folder and the filename you want to download:");
string dir = Console.ReadLine();
DownClient.DownloadFile(durl,dir);
Console.WriteLine("File is downloaded" + dir);



  


}
// wping
if (inputpr.Contains("wping") == true) {
Console.WriteLine("Enter ip or url you want to ping.");
string ip = Console.ReadLine();
Ping wpingob = new Ping();
PingReply reply = wpingob.Send(ip);
Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);



}
// calc
if (inputpr.Contains("calc") == true) {
caclc();



}
// cclear
if (inputpr.Contains("cclear") == true) {
Console.Clear();



}
// pcu
if (inputpr.Contains("pcu") == true) {

Console.WriteLine(userName);


}

if (inputpr.Contains("strt") == true) {

Console.Write("Type the name and the path of the program you want to start:");
string ex = Console.ReadLine();
Process.Start(ex);


}
		}
	}
    // calc function
	static void caclc(){

            Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Press 1 for Addition");  
            Console.WriteLine("Press 2 for Subtraction");  
            Console.WriteLine("Press 3 for Multiplication");  
            Console.WriteLine("Press 4 for Division \n");  
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 1st input");  
            int input_1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 2nd input");  
            int input_2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            switch (action) {  
                case 1: {  
                    result = Addition(input_1, input_2);  
                    break;  
                }  
                case 2: {  
                    result = Subtraction(input_1, input_2);  
                    break;  
                }  
                case 3: {  
                    result = Multiplication(input_1, input_2);  
                    break;  
                }  
                case 4: {  
                    result = Division(input_1, input_2);  
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong action!! try again");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);  
            Console.ReadKey();  
        }  
        //Addition  
        public static int Addition(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Substraction  
        public static int Subtraction(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Multiplication  
        public static int Multiplication(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Division  
        public static int Division(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
	
        }  
        
	}
	}
