﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Utils;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class HelpCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            Console.WriteLine(TextProvider.COMMANDS);
        }
    }
}
