using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Infra.Data.Scripts
{
    public class ClientCommand : IClientCommand
    {
        public ScriptSql Add(ClientEntity client)
        {
            throw new NotImplementedException();
        }

        public ScriptSql Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ScriptSql Edit(int id, ClientEntity client)
        {
            throw new NotImplementedException();
        }
    }
}
