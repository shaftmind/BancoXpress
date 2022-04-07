namespace BancoXpress.Domain.Entities.Client
{
    public class ClientEntity 
    {
        public ClientEntity()
        {
        }

        public ClientEntity(int id, string name, string cpf, string account, string agency, double saldo, string pixKey, string type, bool ativo)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Account = account;
            Agency = agency;
            Saldo = saldo;
            PixKey = pixKey;
            Type = type;
            Ativo = ativo;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Account { get; set; }
        public string Agency { get; set; }
        public double Saldo { get; set; }
        public string PixKey { get; set; }
        public string Type { get; set; }
        public bool Ativo { get; set; }
    }
}
