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
                // Adicionar o cargo dentro do contexto
                contexto.Cargos.Add(cargo);

                // Salvar as alterações
                int resultado = contexto.SaveChanges();

                if (resultado > 0)
                {
                    MessageBox.Show("Cargo inserido com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Houve um problema ao salvar o cargo!");
                }
            }
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
