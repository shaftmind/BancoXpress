using BancoXpress.Application.Models.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Services.Transaction
{
    public interface ITransactionService
    {
        TransactionModel ExcTransaction(ExecutionTransactionModel model);
    }
}
