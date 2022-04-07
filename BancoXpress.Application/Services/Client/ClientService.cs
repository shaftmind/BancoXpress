using AutoMapper;
using BancoXpress.Application.Models;
using BancoXpress.Application.Services.Client;
using BancoXpress.Domain.Entities.Client;
using BancoXpress.Domain.Interfaces.Base;
using BancoXpress.Domain.Interfaces.Client;
using System.Collections.Generic;
using System.Linq;

namespace BancoXpress.Application.Services
{
    public class ClientService : IClientService
    {

        private readonly IRepository<ClientEntity> _repository;
        private readonly IClientQuery _clientQuery;
        private readonly IClientCommand _clientCommand;
        private readonly IMapper _mapper;

        public ClientService(IRepository<ClientEntity> repository, IClientQuery clientQuery, IClientCommand clientCommand, IMapper mapper)
        {
            _repository = repository;
            _clientQuery = clientQuery;
            _clientCommand = clientCommand;
            _mapper = mapper;
        }

        public void DeleteClient(int id)
        {
            var command = _clientCommand.Delete(id);
            _repository.ExecutarCommand(command);
        }

        public ClientModel EditClient(int id, SaveClientModel edit)
        {
            var client = _mapper.Map<ClientEntity>(edit);
            var command = _clientCommand.Edit(id, client);
            _repository.ExecutarCommand(command);

            return new ClientModel()
            {
                Nome = client.Name,
                Account = client.Account,
                Agency = client.Agency,
                Saldo = client.Saldo,
                PixKey = client.PixKey,
                Type = client.Type
            };
        }

        public IEnumerable<ClientModel> ObterClient()
        {
            var query = _clientQuery.GetAll();
            var clients = _repository.ExecutarQuery(query);

            return clients.Select(c => new ClientModel
            {
                Nome= c.Name,
                Account = c.Account,
                Agency= c.Agency,
                Saldo= c.Saldo,
                PixKey= c.PixKey,
                Type= c.Type
            });
        }

        public ClientModel ObterPorId(int id)
        {
            var query = _clientQuery.GetById(id);
            var clients = _repository.ExecutarQuery(query)?.FirstOrDefault();

            return new ClientModel
            {
                Nome = clients.Name,
                Account = clients.Account,
                Agency = clients.Agency,
                Saldo = clients.Saldo,
                PixKey = clients.PixKey,
                Type = clients.Type
            };
        }

        public ClientModel SaveClient(SaveClientModel save)
        {
            var client = _mapper.Map<ClientEntity>(save);
            var command = _clientCommand.Add(client);

            _repository.ExecutarCommand(command);

            return new ClientModel()
            {
                Nome = client.Name,
                Account = client.Account,
                Agency = client.Agency,
                PixKey = client.PixKey,
                Type = client.Type
            };

        }
    }
}
