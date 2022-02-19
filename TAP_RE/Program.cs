using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.IO.IsolatedStorage;
using System.IO.MemoryMappedFiles;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;  
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Management;
using Microsoft.Win32;
using System.Windows;
using System.Globalization;
namespace BlaconzOS
{
    public class Program
    {
        

        public static void Main()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Figgle.FiggleFonts.IsometricSmall.Render("BlaconzOS"));
            Console.WriteLine("V3.6 [Beta]");
            Console.ResetColor();
            //Add a front face here
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {

                DateTime localDate = DateTime.Now;
                DateTime utcDate = DateTime.UtcNow;
                String USTime = ("en-US");
                var culture = new CultureInfo(USTime);
                
                Console.WriteLine("__________________________________________________________");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("{0}, {1:G}", localDate.ToString(culture), localDate.Kind);

                Console.ResetColor();

                Console.ResetColor();
                Console.Title = ("BlaconzOS");
                Console.Write("@#dr {0}", d.Name + " > dir Downloads > BlaconzOS.exe");
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                Console.Write("\nWelcome to BlaconzOS\nEnter \"help or Help\" for assistance for terminal commands\n" + "{0}", d.Name + "Downloads> " + "");
                
                Console.ResetColor();
                string Response = (Console.ReadLine());

                if (Response == ("help"))
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();
                }
                else if (Response == "Help")
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();
                }
                else if (Response == "?")
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();
                }
                else if (Response == "clear")
                {
                    Console.Clear();

                    SecondaryMain();
                }
                else if (Response == "Clear")
                {
                    Console.Clear();

                    SecondaryMain();
                }
                else if (Response == "Reset")
                {
                    Clear();
                }
                else if (Response == "reset")
                {
                    Clear();
                }
                else if (Response == "ip")
                {
                    Thread.Sleep(50);
                    GetLocalIPAddress();

                    SecondaryMain();


                }
                else if (Response == "calc")
                {
                    Calc();
                }
                else if (Response == "Calc")
                {
                    Calc();
                }
                else if (Response == "rlc")
                {
                    System_rlc();
                }
                else if (Response == "lda")
                {
                    Date_Get();
                }
                else if (Response == "vdir")
                {
                    Dir1_TUN();
                }
                else if (Response == "")
                {
                    SecondaryMain();
                }
                else
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\n\"" + Response + "\" is not a recognized internal command, please try again");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                   SecondaryMain();
                } 







            } Console.Read();
        }


        static void Clear()
        {
            Console.Clear();
            Main();
        }


        public static void SecondaryMain()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                Console.Write("\n{0}", d.Name + "Downloads> ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.DarkGreen;


                Console.ResetColor();
                string Response = (Console.ReadLine());

                if (Response == ("help"))
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();
                }
                else if (Response == "Help")
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();

                }
                else if (Response == "?")
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\nhelp: shows you the current text wall; displays information for terminal commands");
                    Thread.Sleep(50);
                    Console.WriteLine("clear: clears the terminal");
                    Thread.Sleep(50);
                    Console.WriteLine("reset: clears the terminal and brings you back to terminal origin");
                    Thread.Sleep(50);
                    Console.WriteLine("ip: retrieves the local ip of current machine");
                    Thread.Sleep(50);
                    Console.WriteLine("calc: opens a basic calculation space");
                    Thread.Sleep(50);
                    Console.WriteLine("rlc: displays parent OS information and displays CPU name");
                    Thread.Sleep(50);
                    Console.WriteLine("lda: displays local time");
                    Thread.Sleep(50);
                    Console.WriteLine("vdir: brings up the TBI (Test Based Interface) of the virtual allocated drive");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    SecondaryMain();
                }
                else if (Response == "clear")
                {
                    Console.Clear();

                    SecondaryMain();

                }
                else if (Response == "Clear")
                {
                    Console.Clear();

                    SecondaryMain();
                }
                else if (Response == "Reset")
                {
                    Clear();
                }
                else if (Response == "reset")
                {
                    Clear();
                }
                else if (Response == "ip")
                {
                    Thread.Sleep(50);
                    GetLocalIPAddress();

                    SecondaryMain();


                }
                else if (Response == "calc")
                {
                    Calc();
                }
                else if (Response == "Calc")
                {
                    Calc();
                }
                else if (Response == "rlc")
                {
                    System_rlc();
                }
                else if (Response == "lda")
                {
                    Date_Get();
                }
                else if (Response == "vdir")
                {
                    Dir1_TUN();
                }
                else if (Response == "")
                {
                    SecondaryMain();
                }
                else
                {
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Console.WriteLine("\n\"" + Response + "\" is not a recognized internal command, please try again");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                }
            } Console.Read();
        }
        static void Calc()
        {
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Thread.Sleep(50);
                Console.WriteLine("\nEnter \"1\" for addition\n\nEnter \"2\" for subtraction\n\nEnter \"3\" for multiplication\n\nEnter \"4\" for division\n\nEnter \"close\" to exit calculation space\n");

                string calcresponse = (Console.ReadLine());
                if (calcresponse == "1")
                {
                    Thread.Sleep(50);
                    Console.Write("\nAdd Number: [?] + ? = ?\n");
                    float Add1 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    Console.Write("\nAdd Number: " + Add1 + " + [?] = ?\n");
                    float Add2 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    float AddAnswer = Add1 + Add2;
                    Console.WriteLine("\n" + Add1 + " + " + Add2 + " = " + AddAnswer);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                }
                if (calcresponse == "2")
                {

                    Console.Write("\nAdd Number: [?] - ? = ?\n");
                    float Sub1 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    Console.Write("\nAdd Number: " + Sub1 + " - [?] = ?\n");
                    float Sub2 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    float SubAnswer = Sub1 - Sub2;
                    Console.WriteLine("\n" + Sub1 + " - " + Sub2 + " = " + SubAnswer);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                };
                if (calcresponse == "3")
                {

                    Console.Write("\nAdd Number: [?] x ? = ?\n");
                    float Mul1 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    Console.Write("\nAdd Number: " + Mul1 + " x [?] = ?\n");
                    float Mul2 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    float MulAnswer = Mul1 * Mul2;
                    Console.WriteLine("\n" + Mul1 + " x " + Mul2 + " = " + MulAnswer);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                };
                if (calcresponse == "4")
                {

                    Console.Write("\nAdd Number: [?] ÷ ? = ?\n");
                    float Div1 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    Console.Write("\nAdd Number: " + Div1 + " ÷ [?] = ?\n");
                    float Div2 = Convert.ToSingle(Console.ReadLine());

                    Thread.Sleep(250);
                    float DivAnswer = Div1 / Div2;
                    Console.WriteLine("\n" + Div1 + " - " + Div2 + " = " + DivAnswer);
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                }
                if (calcresponse == "close")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                }
                if (calcresponse == "Close")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    SecondaryMain();
                }
                else
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\n\"" + calcresponse + "\"" + " is not a recognized command, please try again.");
                    Calc();
                };
            }
        }
        public static string GetLocalIPAddress()
        {
            Console.ResetColor();
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Thread.Sleep(50);
                    Console.Write("\n" + ip + "\n");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    return ip.ToString();

                }

            }
            throw new Exception("No network adapters with an IPv4 address in the system!");

        }


        static void System_rlc()
        {
            Program si = new Program();
            si.getOperatingSystemInfo();
            si.getProcessorInfo();
            Console.ReadLine();
        }


        public void getOperatingSystemInfo()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(50);
            Console.WriteLine("\nDisplaying operating system info....\n");
            //Create an object of ManagementObjectSearcher class and pass query as parameter.
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                {
                    Console.WriteLine("Operating System Name  :  " + managementObject["Caption"].ToString());   //Display operating system caption
                }
                if (managementObject["OSArchitecture"] != null)
                {
                    Console.WriteLine("Operating System Architecture  :  " + managementObject["OSArchitecture"].ToString());   //Display operating system architecture.
                }
                if (managementObject["CSDVersion"] != null)
                {
                    Console.WriteLine("Operating System Service Pack   :  " + managementObject["CSDVersion"].ToString());     //Display operating system version.
                }
            }
        }

        public void getProcessorInfo()
        {
            Console.WriteLine("\n\nDisplaying Processor Name....");
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    Console.WriteLine(processor_name.GetValue("ProcessorNameString"));   //Display processor ingo.
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            SecondaryMain();
        }
        public static void Date_Get()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String USTime = ("en-US");
            var culture = new CultureInfo(USTime);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("{0}, {1:G}", localDate.ToString(culture), localDate.Kind);

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            SecondaryMain();
        }











        public static void Dir1_TUN()
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Enter \"Help\" for TPI Assistance");
                Console.WriteLine("\nVirtual TPI: 1");
            Thread.Sleep(250);
            Console.WriteLine("Allocated 20kb\n");
            Console.ResetColor();
            Console.Write("vTPI.1 >");
            String ResponseDir = (Console.ReadLine());
            if (ResponseDir == "Help")
            {
                Console.WriteLine("");
            }
            else if (ResponseDir == "help")
            {
                Console.WriteLine("");
            }
           
            else if (ResponseDir == "Exit")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SecondaryMain();
            }
            else if (ResponseDir == "exit")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                SecondaryMain();
            }
            else if (ResponseDir == "Notes" || ResponseDir == "notes")
            {
                NotesSpace();
            };
        }
        public static void NotesSpace()
        {
            
                Console.WriteLine("\nSelect notes: [1], [2], [3], [4], [5], [7], [8], [9], [10].");
                string Notesel = (Console.ReadLine());
                if (Notesel == "1")
                {
                    Console.WriteLine("\n'Read' saved or 'Write' new");
                Console.Write(".Notes >");
                string onereact = (Console.ReadLine());
                    if (onereact == "Write" || onereact == "write")
                    {
                        string fileNameOne = @"C:\Users\XboxZ\source\repos\TAP_RE\TAP_RE\bin\Debug\SaveNotes1.txt";
                    if (File.Exists(@"SaveNotes1.txt"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nSaved file already present; Do you want to re-write the current save? (Y) || (N)");
                        Console.ResetColor();
                        Console.Write(".Notes >");
                        string Fileexist = (Console.ReadLine());
                        if (Fileexist == "Y" || Fileexist == "y")
                        {
                            Console.WriteLine(Figgle.FiggleFonts.KeyboardSmall.Render("\nNote Pad:"));
                            string oneres = (Console.ReadLine());
                            TextWriter Nsave = new StreamWriter("SaveNotes1.txt");
                            Nsave.WriteLine(oneres);
                            Nsave.Close();
                        }
                        if (Fileexist == "N" || Fileexist == "n")
                        {
                            NotesSpace();
                        }
                    }
                    else
                    {
                        Console.WriteLine(Figgle.FiggleFonts.KeyboardSmall.Render("\nNote Pad:"));
                        string oneres = (Console.ReadLine());
                        TextWriter Nsave = new StreamWriter("SaveNotes1.txt");
                        Nsave.WriteLine(oneres);
                        Nsave.Close();
                    }
                    }
                    if (onereact == "Read" || onereact == "read")
                    {
                        TextReader Nread = new StreamReader("SaveNotes1.txt");
                        string ReadNoteOne = Nread.ReadLine();
                        Console.WriteLine(ReadNoteOne);
                        Nread.Close();
                    NotePort();
                    }
                }
                if (Notesel == "2")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes2.txt");
                }
                if (Notesel == "3")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes3.txt");
                }
                if (Notesel == "4")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes4.txt");
                }
                if (Notesel == "5")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes5.txt");
                }
                if (Notesel == "6")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes6.txt");
                }
                if (Notesel == "7")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes7.txt");
                }
                if (Notesel == "8")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes8.txt");
                }
                if (Notesel == "9")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes9.txt");
                }
                if (Notesel == "10")
                {
                    TextWriter Nsave = new StreamWriter("SaveNotes10.txt");
                };
        }
        public static void NotePort()
        {
            NotesSpace();
        }
    }
}
