using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperApp.UI
{
    public static class CommandManager
    {
        public static string ValidateCommand(string command)
        {
            return "i dont know what to do yet";
        }
    }


    public class Command
    {
        public static string isValid()
        {
            return "i dont know what to do yet";
        }
    }

    public static class stringListOfCommand
    {
        public static readonly string cDefault = "-default";
        public static readonly string cName = "-name";
    }

    public static class ListOfCommand
    {
        public static List<string> ListofCommands = new List<string>();

    }
}
