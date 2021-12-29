using System;
using RobloxFiles;

namespace SUS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Carti Converter by SyntaxEvasion";

            Console.WriteLine("   _____           _   _    _____                          _   \n  / ____|         | | (_)  / ____|                        | |  \n | |     __ _ _ __| |_ _  | |     ___  _ ____   _____ _ __| |_ \n | |    / _` | '__| __| | | |    / _ \\| '_ \\ \\ / / _ \\ '__| __|\n | |___| (_| | |  | |_| | | |___| (_) | | | \\ V /  __/ |  | |_ \n  \\_____\\__,_|_|   \\__|_|  \\_____\\___/|_| |_|\\_/ \\___|_|   \\__|    \n\n");

            Console.WriteLine("Starting carti conversion...");

                RobloxFile file = RobloxFile.Open(args[0]);

                if (file is BinaryRobloxFile)
                {
                    RobloxFile newfile = new XmlRobloxFile();
                    
                    foreach (Instance des in file.GetChildren())
                    {
                        des.Parent = newfile;
                    }

                    newfile.Save("output.rbxmx");
                }
                else
                {
                    RobloxFile newfile = new BinaryRobloxFile();

                    foreach (Instance des in file.GetChildren())
                    {
                        des.Parent = newfile;
                    }

                    newfile.Save("output.rbxm");
                }
                Console.WriteLine("carti conversion finished");
        }
    }
}
