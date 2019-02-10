using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Utils
{
    static class TextProvider
    {
        public static string WELCOME_TEXT = "\n  /$$$$$$$$ /$$                        /$$$$$$                            /$$$$$$$                      /$$\n"
                                            + " |__  $$__/| $$                       /$$__  $$                          | $$__  $$                    | $$\n"
                                            + "    | $$   | $$$$$$$   /$$$$$$       | $$  \\__/  /$$$$$$   /$$$$$$       | $$  \\ $$  /$$$$$$   /$$$$$$ | $$  /$$$$$$   /$$$$$$\n"
                                            + "    | $$   | $$__  $$ /$$__  $$      | $$       |____  $$ /$$__  $$      | $$  | $$ /$$__  $$ |____  $$| $$ /$$__  $$ /$$__  $$\n"
                                            + "    | $$   | $$  \\ $$| $$$$$$$$      | $$        /$$$$$$$| $$  \\__/      | $$  | $$| $$$$$$$$  /$$$$$$$| $$| $$$$$$$$| $$  \\__/\n"
                                            + "    | $$   | $$  | $$| $$_____/      | $$    $$ /$$__  $$| $$            | $$  | $$| $$_____/ /$$__  $$| $$| $$_____/| $$\n"
                                            + "    | $$   | $$  | $$|  $$$$$$$      |  $$$$$$/|  $$$$$$$| $$            | $$$$$$$/|  $$$$$$$|  $$$$$$$| $$|  $$$$$$$| $$\n"
                                            + "    |__/   |__/  |__/ \\_______/       \\______/  \\_______/|__/            |_______/  \\_______/ \\_______/|__/ \\_______/|__/\n";

        public static string MAIN_MENU = "\n ===================================================================\n"
                                       + " ===                         MAIN MENU                           ===\n"
                                       + " ===================================================================\n"
                                       + "               Welcome to the administration page\n\n" 
                                       + " We trust you have received the usual lecture from the local System\n"
                                       + " Administrator. It usually boils down to these three things:\n"
                                       + "\t #1) Respect the privacy of others.\n"
                                       + "\t #2) Think before you type.\n"
                                       + "\t #3) With great power comes great responsibility.\n\n"
                                       + " Press h for help. ";

        public static string COMMANDS = "Select one of the following:\n" +
            "\t1) List All Vehicles\n" +
            "\t2) Search For Vehicles Submenu\n" +
            "\t3) Add Vehicle\n" +
            "\t4) Remove Vehicle\n" +
            "\t5) Increase All Prices \n" +
            "\t6) Decrease All Prices \n" +
            "\t7) Display Overview \n" +
            "\th) This Help Menu" + "\tq) Quit";
    }

    static class InputHelper
    {
        /// <summary>
        /// Requests input until standard input is a valid Integer.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static int GetValidIntegerInput(string request)
        {
            Console.Write(request);
            string inputPrice = Console.ReadLine();
            while (!Int32.TryParse(inputPrice, out int price))
            {
                Console.WriteLine($"{inputPrice} is not an Integer.");
                inputPrice = Console.ReadLine();
            }
            return Convert.ToInt32(inputPrice);
        }

        /// <summary>
        /// Requests input until standard input is a valid string.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string GetValidStringInput(string request)
        {
            Console.Write(request);
            return Console.ReadLine();
        }

        /// <summary>
        /// Requests input until standard input is a valid string.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The entered space seperated string as an array of strings</returns>
        public static string[] GetValidSpaceSeparatedSequenceInput(string request)
        {
            Console.Write(request);
            return Console.ReadLine().Split(' ');
        }

        /// <summary>
        /// Requests input until the standard input is a valid y or n.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static bool GetValidConfirmationInput(string request)
        {
            Console.Write(request);
            string input = Console.ReadLine();
            while(!IsValidYesOrNo(input))
            {
                Console.Write("Please only enter 'y' or 'n': ");
                input = Console.ReadLine();
            }
            return input.ToLower().Equals("y") ? true : false;
        }

        private static bool IsValidYesOrNo(string text)
        {
            switch(text.ToLower())
            {
                case "y": return true;
                case "n": return true;
                default: return false;
            }
        }
    }
}
