using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Models.Transaction
{
    public class TransactionModel
    {
        //TODO: implementar um controle de transações

        public bool Success { get; set; }
        public string PixKeyOrigin { get; set; }
        public string PixKeyDestiny { get; set; }


    }
}
