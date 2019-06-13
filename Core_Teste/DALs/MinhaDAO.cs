using Core_Teste.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Teste.DALs
{
    public class MinhaDAO
    {
        private ISessionT session;

        public MinhaDAO(ISessionT s)
        {
            this.session = s;
        }

        public string GetSession()
        {
            return this.session.SessionController;
        }
    }
}
