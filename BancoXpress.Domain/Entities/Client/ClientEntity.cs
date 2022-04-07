namespace BancoXpress.Domain.Entities.Client
{
    public class ClientEntity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Account { get; set; }
        public string Agency { get; set; }
        public double Saldo { get; set; }
        public string PixKey { get; set; }
        public string Type { get; set; }
        public bool Ativo { get; set; }
    }
}
