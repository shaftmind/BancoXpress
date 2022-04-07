using BancoXpress.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Services.Client
{
    public interface IClientService
    {
        IEnumerable<ClientModel> ObterClient();
        ClientModel ObterPorId(int id);
        ClientModel SaveClient(SaveClientModel save);
        ClientModel EditClient(int id, SaveClientModel edit);
        void DeleteClient(int id);
    }
}
