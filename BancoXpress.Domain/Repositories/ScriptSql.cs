namespace BancoXpress.Domain.Interfaces.Base
{
    public class ScriptSql
    {
        public ScriptSql(string script)
        {
            Query = script;
        }

        public ScriptSql(string script, object parametros) : this(script)
        {
            Parametros = parametros;
        }

        public string Query { get; set; }
        public object Parametros { get; set; }
    }
}