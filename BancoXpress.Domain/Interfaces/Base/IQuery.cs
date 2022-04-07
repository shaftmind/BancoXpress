using System.Collections.Generic;

namespace BancoXpress.Domain.Interfaces.Base
{
    public interface IQuery<T>
    {
        IEnumerable<T> ExecutarQuery(ScriptSql script);
    }
}
