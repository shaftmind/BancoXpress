using BancoXpress.Application.Models.Transaction;
using BancoXpress.Application.Services.Transaction;
using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;
using System.Linq;

namespace BancoXpress.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IRepository<ClientEntity> _repository;
        private readonly IClientQuery _clientQuery;
        private readonly IClientCommand _clientCommand;

        public TransactionService(IRepository<ClientEntity> repository, IClientQuery clientQuery, IClientCommand clientCommand)
        {
            _repository = repository;
            _clientQuery = clientQuery;
            _clientCommand = clientCommand;
        }

        public TransactionModel ExcTransaction(ExecutionTransactionModel model)
        {
            var queryClientOrigin = _clientQuery.GetByPixKey(model.PixKeyOrigin);
            var clientOriginList = _repository.ExecutarQuery(queryClientOrigin);
            var clientOrigin = clientOriginList.FirstOrDefault();

            var queryClientDestiny = _clientQuery.GetByPixKey(model.PixKeyDestiny);
            var clientDestinyList = _repository.ExecutarQuery(queryClientDestiny);
            var clientDestiny = clientDestinyList.FirstOrDefault();

            return Transaction(clientOrigin, clientDestiny, model.Valor);


        }

        public TransactionModel Transaction(ClientEntity clientOrigin, ClientEntity clientDestiny, double valor)
        {
            if (clientOrigin == null || clientDestiny == null) {
                return new TransactionModel
                {
                    Success = false,
                    Message = "Uma das Chaves é Inválida",
                    PixKeyOrigin = clientOrigin.PixKey,
                    PixKeyDestiny = clientDestiny.PixKey,
                };
            }

            if (clientOrigin.Saldo < valor)
            {
                return new TransactionModel
                {
                    Success = false,
                    Message = "Saldo Insuficiente",
                    PixKeyOrigin = clientOrigin.PixKey,
                    PixKeyDestiny = clientDestiny.PixKey,
                };
            }

            clientOrigin.Saldo = clientOrigin.Saldo - valor;
            clientDestiny.Saldo = clientDestiny.Saldo + valor;


            _clientCommand.Edit(clientOrigin.Id, clientOrigin);
            _clientCommand.Edit(clientDestiny.Id, clientDestiny);

            return new TransactionModel
            {
                Success = true,
                Message = string.Format("Transferencia efetuada com sucesso para {0}", clientDestiny.Name),
                PixKeyOrigin = clientOrigin.PixKey,
                PixKeyDestiny = clientDestiny.PixKey,
            };
        }
    }
}
