using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyREPL
{
    class State
    {
        private string subject;
        private string body;
        private string[] recipientList;

        public State()
        {
            subject = null;
            body = null;
            recipientList = null;
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
            }
        }

        public string[] RecipientList
        {
            get
            {
                return recipientList;
            }
            set
            {
                recipientList = value;
            }
        }

    }

}
