using ControlePonto.Data;
using ControlePonto.Modelos;

namespace ControlePonto.Formularios.Cargos
{
    public partial class FormularioCargoForm : Form
    {
        public FormularioCargoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Criando o objeto de cargo que vai ser salvo
            var cargo = new Cargo
            {
                Nome = txtNome.Text,
                Descricao = txtDescricao.Text,
                CargaHoraria = numCargaHoraria.Value
            };

            // Diretiva para liberar recursos após o uso
            using(var contexto = new ControlePontoDbContext())
            {
                contexto.Cargos.Add(cargo);
                contexto.SaveChanges();
            }

            MessageBox.Show("Cargo inserido com sucesso!");
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar o cadastro?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
