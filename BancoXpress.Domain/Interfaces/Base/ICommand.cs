using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Domain.Interfaces.Base
{
    public interface ICommand
    {
        void ExecutarCommand(ScriptSql script);
    }
}
