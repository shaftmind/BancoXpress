using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;

namespace BancoXpress.Infra.Data.Scripts
{
    public class ClientCommand : IClientCommand
    {
        public ScriptSql Add(ClientEntity client)
        {
            var query = @"INSERT INTO Client (Name, Cpf, Account, Agency, Saldo, PixKey, Type, Ativo)  VALUE 
                           (@Name, @Cpf, @Account, @Agency, 100.00, @PixKey, @Type, 1)";

            var parans = new
            {
                Name = client.Name,
                Cpf = client.Cpf,
                Account = client.Account,
                Agency = client.Agency,
                PixKey = client.PixKey,
                Type = client.Type,

            };

            return new ScriptSql(query, parans);
        }

        public ScriptSql Delete(int id)
        {
            var query = @"UPDATE Client SET Ativo = 0 WHERE Id = @Id";

            var param = new { id };

            return new ScriptSql(query, param);
        }

        public ScriptSql Edit(int id, ClientEntity client)
        {
            var query = @"UPDATE Client 
                          SET Name = @Name, 
                              Cpf = @Cpf, 
                              Account = @Account, 
                              Agency = @Agency,    
                              Saldo = @Saldo, 
                              PixKey = @PixKey, 
                              Type = @Type
                          WHERE Id = @Id
                          AND Ativo = 1";

            var parans = new

            {
                Id = id,
                Name = client.Name,
                Cpf = client.Cpf,
                Account = client.Account,
                Agency = client.Agency,
                PixKey = client.PixKey,
                Type = client.Type,
            };

            return new ScriptSql(query, parans);
        }

    }
}
