using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    class SendCommand : ICommand
    {
        private EmailClient emailClient;

        public SendCommand(string gmailAccount, string password)
        {
            emailClient = new EmailClient(gmailAccount, password);
        }

        public string Name
        {
            get
            {
                return "send";
            }
        }

        public string Execute(string parameters, State state)
        {
            if (state.Subject == null || state.Body == null)
                return "Error: missing subject or body";
            foreach (string address in state.RecipientList)
                if (address != null)
                    emailClient.Send(address, state.Subject, state.Body);
            return $"Sent {state.Body} to {state.RecipientList.Length} recipients";
        }
    }
}
