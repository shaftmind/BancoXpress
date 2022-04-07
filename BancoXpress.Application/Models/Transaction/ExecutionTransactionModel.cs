using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Models.Transaction
{
    public class ExecutionTransactionModel
    {
        public string PixKeyOrigin { get; set; }
        public string PixKeyDestiny { get; set; }
        public double Valor { get; set; }
    }
}
