using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPagamento.Models
{
    public abstract class Pagamento
    {
        public decimal Valor { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;

        public abstract string ProcessarPagamento();
    }
}