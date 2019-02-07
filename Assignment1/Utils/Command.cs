using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Util.Command
{
    interface ICommand
    {
        void Execute();
    }

    interface ISelectable
    {
        void Command();
    }
}
