using BancoXpress.Application.Models;
using BancoXpress.Application.Services.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Services
{
    public class ClientService : IClientService
    {
        public void DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        public ClientModel EditClient(SaveClientModel edit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientModel> ObterClient()
        {
            throw new NotImplementedException();
        }

        public ClientModel ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public ClientModel SaveClient(SaveClientModel save)
        {
            throw new NotImplementedException();
        }
    }
}
