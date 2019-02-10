﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.DBAccess;
using Assignment1.Vehicles;

namespace Assignment1.Commands
{
    class QuitCommand : IMenuCommand
    {
        public void Execute(IDBAccess<Vehicle> database)
        {
            System.Environment.Exit(0);
        }
    }
}
