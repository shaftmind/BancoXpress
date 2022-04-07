using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;

namespace BancoXpress.Infra.Data.Scripts
{
    public class ClientQuery : IClientQuery
    {
        public ScriptSql GetAll()
        {
            var query = @"SELECT * FROM Client WHERE Ativos = 1";

            return new ScriptSql(query);
        }

        public ScriptSql GetById(int id)
        {
            var query = @"SELECT * FROM Client WHERE Id = @Id AND Ativo = 1";
            var param = new { id };
            return new ScriptSql(query, param);
        }

        public ScriptSql GetByPixKey(string key)
        {
            var query = @"SELECT * FROM Client WHERE PixKey = @PixKey AND Ativo = 1";
            var param = new { key };
            return new ScriptSql(query, param);
        }
    }
}
