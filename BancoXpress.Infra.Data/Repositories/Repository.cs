using BancoXpress.Domain.Interfaces.Base;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace BancoXpress.Infra.Data.Repositories
{
    public class Repository<T> 
    {
        public string ConnectionString { get; set; }

        public Repository()
        {
            //FIX colocar variavel pra conexão com o BD 
            ConnectionString = "connction";
        }

        public void ExecutarCommand(ScriptSql script)
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Execute(script.Query, script.Parametros);
        }

        public IEnumerable<T> ExecutarQuery(ScriptSql script)
        {
            using var connection = new MySqlConnection(ConnectionString);
            var retorno = connection.Query<T>(script.Query, script.Parametros);

            return retorno;

        }
    }
}
