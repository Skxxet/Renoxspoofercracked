using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSpoofer
{
    class Program
    {
            private static void Main(string[] args)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Title = "RenoX Spoofer source cracked by Skeet | RenoX#6687";
                    Console.WriteLine(" ██▀███  ▓█████  ███▄    █  ▒█████  ▒██   ██▒     ██████  ██▓███   ▒█████   ▒█████    █████▒▓█████  ██▀███  \n▓██ ▒ ██▒▓█   ▀  ██ ▀█   █ ▒██▒  ██▒▒▒ █ █ ▒░   ▒██    ▒ ▓██░  ██▒▒██▒  ██▒▒██▒  ██▒▓██   ▒ ▓█   ▀ ▓██ ▒ ██▒\n▓██ ░▄█ ▒▒███   ▓██  ▀█ ██▒▒██░  ██▒░░  █   ░   ░ ▓██▄   ▓██░ ██▓▒▒██░  ██▒▒██░  ██▒▒████ ░ ▒███   ▓██ ░▄█ ▒\n▒██▀▀█▄  ▒▓█  ▄ ▓██▒  ▐▌██▒▒██   ██░ ░ █ █ ▒      ▒   ██▒▒██▄█▓▒ ▒▒██   ██░▒██   ██░░▓█▒  ░ ▒▓█  ▄ ▒██▀▀█▄  \n░██▓ ▒██▒░▒████▒▒██░   ▓██░░ ████▓▒░▒██▒ ▒██▒   ▒██████▒▒▒██▒ ░  ░░ ████▓▒░░ ████▓▒░░▒█░    ░▒████▒░██▓ ▒██▒\n░ ▒▓ ░▒▓░░░ ▒░ ░░ ▒░   ▒ ▒ ░ ▒░▒░▒░ ▒▒ ░ ░▓ ░   ▒ ▒▓▒ ▒ ░▒▓▒░ ░  ░░ ▒░▒░▒░ ░ ▒░▒░▒░  ▒ ░    ░░ ▒░ ░░ ▒▓ ░▒▓░\n  ░▒ ░ ▒░ ░ ░  ░░ ░░   ░ ▒░  ░ ▒ ▒░ ░░   ░▒ ░   ░ ░▒  ░ ░░▒ ░       ░ ▒ ▒░   ░ ▒ ▒░  ░       ░ ░  ░  ░▒ ░ ▒░\n  ░░   ░    ░      ░   ░ ░ ░ ░ ░ ▒   ░    ░     ░  ░  ░  ░░       ░ ░ ░ ▒  ░ ░ ░ ▒   ░ ░       ░     ░░   ░ \n   ░        ░  ░         ░     ░ ░   ░    ░           ░               ░ ░      ░ ░             ░  ░   ░     ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[+] cracked by skeet ,Made by RenoX#6687");
                    Console.WriteLine();
                    Console.WriteLine("[+] [1] Spoof");
                    Console.WriteLine();
                    Console.WriteLine("[+] [2] Clean");
                    Console.WriteLine();
                    Console.WriteLine("[+] [3] Discord");
                    Console.WriteLine();
                    Console.Write(" > ");
                    string str = Console.ReadLine();
                    if (str == "1")
                    {
                        int num1 = (int)MessageBox.Show("Spoof");
                        Spoofer.Spoof();
                        int num2 = (int)MessageBox.Show("Spoofed");
                    }
                    else if (str == "2")
                    {
                        int num = (int)MessageBox.Show("to Clean Press: 8");
                        Spoofer.Clean();
                    }
                    else if (str == "3")
                    {
                        Console.Clear();
                        Process.Start("https://discord.gg/Qh38cEd");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong Button Retard");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
            }
        }
    }
