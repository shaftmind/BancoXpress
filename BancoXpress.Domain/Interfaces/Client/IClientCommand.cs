using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;

namespace BancoXpress.Domain.Interfaces.Client
{
    public interface IClientCommand
    {
        ScriptSql Add(ClientEntity client);
        ScriptSql Edit(int id, ClientEntity client);
        ScriptSql Delete(int id);
    }
}
