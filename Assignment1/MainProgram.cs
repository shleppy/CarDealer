﻿using Assignment1.Utils;
using Assignment1.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment1
{
    class MainProgram
    {
        public static void Main(string[] args)
        {
            CarDealerApplication app = new CarDealerApplication();
            app.Run();
        }
    }
}