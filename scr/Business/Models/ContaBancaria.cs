using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public class ContaBancaria : Entity
    {
        public string CPF { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get;set; }
        public int Senha8dig { get; set; }
        public string Senha6dig { get; set; }
    }
}
