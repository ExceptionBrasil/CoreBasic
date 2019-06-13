using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Teste.Sessions
{
    public class Session : ISessionT
    {
        public Session()
        {
            this.SessionController = OpenSession();
        }

        public string SessionController { get; set; }

        public string OpenSession()
        {
            return "Session is Open";
        }
    }
}
