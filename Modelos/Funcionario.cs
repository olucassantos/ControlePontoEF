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

            MemoryStream mStream = new MemoryStream();
            byte[] pData = this.Foto;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}
