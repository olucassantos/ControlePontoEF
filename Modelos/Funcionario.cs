using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ControlePonto.Modelos
{
    internal class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Matricula { get; set; }
        public byte[] Foto { get; set; } 

        public Cargo Cargo { get; set; }

        public Bitmap? FotoBitmap()
        {
            if (this.Foto == null)
                return null;

            // Abre um fluxo de dados na memória
            MemoryStream fluxoDeMemoria = new MemoryStream();

            // Pega a foto do funcionário
            byte[] dadosBlob = this.Foto;

            // Manda a foto para a memória do computador
            fluxoDeMemoria.Write(dadosBlob, 0, Convert.ToInt32(dadosBlob.Length));

            // Converte os dados para bitmap
            Bitmap bm = new Bitmap(fluxoDeMemoria, false);

            // Limpa o fluxo de memoria
            fluxoDeMemoria.Dispose();

            // Retorna a imagem
            return bm;
        }
    }
}
