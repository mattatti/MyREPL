using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    class BodyCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "body";
            }
        }

        public string Execute(string parameters, State state)
        {
            if (parameters == null)
                return "Wrong number of parameters: Command 'body' requires 1 parameter";
            state.Body = parameters;
            return $"Body updated to '{parameters}'";
        }
    }
}
