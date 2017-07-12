using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScoutingCSV4.teamDataBasePack;

namespace ScoutingCSV4
{
    class Class1
    {
        private static bool exit = false;
        private static String command = "";
        private static ConsoleKeyInfo key = new ConsoleKeyInfo();

        private static TeamDataBaseManager tdbm = new TeamDataBaseManager("C:\\Users\\Kirby\\Desktop", Restore.NEW);

        public static void Main(String[] args)
        {
            while (exit != true)
            {
                KeyLogger();
                if (command.IndexOf(' ') < 2) ThrowUnknown();
                else ExecuteCommand();
            }
        }

        private static void KeyLogger()
        {
            while (key.Key != ConsoleKey.Enter)
            {
                switch (key.Key)
                {
                    case ConsoleKey.Backspace:
                        {
                            command = command.Remove(command.Length-1);
                        }
                        break;
                    default:
                        {
                            command += key.KeyChar;
                        }
                        break;
                }
                key = Console.ReadKey();
            }
        }

        private static void ExecuteCommand()
        {
            switch (command.Substring(0,command.IndexOf(' ')))
            {
                default:
                    ThrowUnknown();
                    break;
                case "/addTeam":
                    
                    break;
                case "/exit":
                    exit = true;
                    break;
                case "":
                     break;
            }
        }

        private static void ThrowUnknown()
        {
            Console.WriteLine("Unknown Command");
        }
    }
}
