using BancoXpress.Application.Models;
using BancoXpress.Application.Models.Transaction;
using BancoXpress.Application.Services.Client;
using BancoXpress.Application.Services.Transaction;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BancoXpress.Controllers
{
    [ApiController]
    [Route("api/v1/clients")]
    [Produces("application/json")]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly ITransactionService _transactionService;

        public ClientController(IClientService clientService, ITransactionService transactionService)
        {
            _clientService = clientService;
            _transactionService = transactionService; 
        }

        [HttpGet]
        public IEnumerable<ClientModel> ObterClientes()
        {
            return _clientService.ObterClient();
        }

        [HttpGet("/{clientId}")]
        public ClientModel ObterClientePorId(int clientId)
        {
            return _clientService.ObterPorId(clientId);
        }

        [HttpPost]
        public ClientModel SalvarCliente(SaveClientModel model)
        {
            return _clientService.SaveClient(model);
        }

        [HttpPut("/{id}")]
        public ClientModel EditarCliente(int id, SaveClientModel model)
        {
            return _clientService.EditClient(id, model);
        }

        [HttpDelete("/{id}")]
        public void DeletarCliente(int id)
        {
            _clientService.DeleteClient(id);
        }

        [HttpPost("/transaction")]
        public TransactionModel ExecutarTransacaoPix(ExecutionTransactionModel model)
        {
            return _transactionService.ExcTransaction(model);
        }
    }
}
