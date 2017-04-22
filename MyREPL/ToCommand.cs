using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    class ToCommand : ICommand
    {
        private const string errorMessgae = "Wrong number of parameters: Command 'to' requires at least 1 parameter";

        public string Name
        {
            get
            {
                return "to";
            }
        }

        public string Execute(string parameters, State state)
        {
            if (parameters == null)
                return errorMessgae;
            state.RecipientList = new string[1];
            state.RecipientList[0] = parameters;
            return $"To updated to '{parameters}'";
        }

        public string Execute(string[] parameters, State state)
        {
            if (!AreValidParameters(parameters))
                return errorMessgae;
            state.RecipientList = parameters;
            if (parameters.Length == 1)
                return $"To updated to {parameters[0]}";
            else
                return $"To updated with {parameters.Length} emails";
        }

        private bool AreValidParameters(string[] parameters)
        {
            if (parameters == null)
            {
                return false;
            }
            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] != null) return true;
            }
            return false;
        }
    }
}
