using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    interface ICommand
    {
         string Name { get; }

         string Execute(string parameters, State state);
    }
}
