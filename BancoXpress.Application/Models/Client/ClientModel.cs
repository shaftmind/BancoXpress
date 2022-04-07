using BancoXpress.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoXpress.Application.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Account { get; set; }
        public string Agency { get; set; }
        public double Saldo { get; set; }
        public string PixKey { get; set; }
        public string Type { get; set; }
    }
}
