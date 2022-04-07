using BancoXpress.Application.Models.Transaction;
using BancoXpress.Application.Services.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Services
{
    public class TransactionService : ITransactionService
    {
        public TransactionModel ExcTransaction(string pixOrigin, string pixDestiny, double valor)
        {
            throw new NotImplementedException();
        }
    }
}
