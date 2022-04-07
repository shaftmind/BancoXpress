using BancoXpress.Domain.Interfaces.Base;

namespace BancoXpress.Domain.Interfaces.Client
{
    public interface IClientQuery
    {
        ScriptSql GetAll();
        ScriptSql GetById(int id);


    }
}
