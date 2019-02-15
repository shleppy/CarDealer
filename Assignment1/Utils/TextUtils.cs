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
}
