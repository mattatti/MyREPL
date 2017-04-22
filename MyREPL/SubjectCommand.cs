using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    class SubjectCommand : ICommand
    {
        public string Name
        {
            get
            {
                return "subject";
            }
        }

        public string Execute(string parameters, State state)
        {
            if (parameters == null)
                return "Wrong number of parameters: Command 'subject' requires 1 parameter";
            state.Subject = parameters;
            return $"Subject updated to '{parameters}'";
        }
    }
}
