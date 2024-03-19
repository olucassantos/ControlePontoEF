using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePonto.Modelos
{
    internal class Apontamento
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Tipo { get; set; }
        public string Motivo { get; set; }

        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }
    }
}
