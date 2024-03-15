using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlePonto.Componentes;
using ControlePonto.Modelos;

namespace ControlePonto.Formularios.Funcionarios
{
    public partial class FormularioFuncionarioForm : Form
    {
        public FormularioFuncionarioForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var funcionario = new Funcionario
            {

            };
        }
    }
}
