using ControlePonto.Data;
using ControlePonto.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePonto.Formularios.Apontamentos
{
    public partial class FormularioApontamentosForm : Form
    {
        Funcionario FuncionarioSelecionado;

        public FormularioApontamentosForm()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void AdicionaDigito(string digito)
        {
            txtMatricula.Text += digito;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AdicionaDigito("0");
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            AdicionaDigito("1");
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            AdicionaDigito("2");
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            AdicionaDigito("3");
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            AdicionaDigito("4");
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            AdicionaDigito("5");
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            AdicionaDigito("6");
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            AdicionaDigito("7");
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            AdicionaDigito("8");
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            AdicionaDigito("9");
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtMatricula.Clear();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            // Busca o funcionário pela matricula
            string matricula = txtMatricula.Text;

            // Abre a conexão com o contexto
            using (var contexto = new ControlePontoDbContext())
            {
                var funcionario = contexto.Funcionarios
                        .FirstOrDefault(func => func.Matricula == matricula);

                if (funcionario == null)
                {
                    MessageBox.Show("Funcionario não encontrado!");
                    txtMatricula.Clear();
                    return;
                }

                // Adiciona Nome
                lblNomeFuncionario.Text = funcionario.Nome;
                FuncionarioSelecionado = funcionario;
            }
        }

        private void btnAprova_Click(object sender, EventArgs e)
        {
            if (FuncionarioSelecionado == null)
            {
                return;
            }

            using (var contexto = new ControlePontoDbContext())
            {
                // Pesquisa os apontamentos do funcionário no dia de hoje
                int quantidadeApontamentos = contexto.Apontamentos
                    .Count( 
                        apontamento => 
                            apontamento.FuncionarioId == FuncionarioSelecionado.Id &&
                            apontamento.Data.Date == DateTime.Today
                    );

                // Define se é entrada ou saida pelo quantidade
                string tipo = quantidadeApontamentos % 2 == 0 ? "Entrada" : "Saida";

                // Cria o apontamento
                var apontamento = new Apontamento
                {
                    Data = DateTime.Today,
                    Hora = DateTime.Now,
                    Tipo = tipo,
                    Motivo = "",
                    FuncionarioId = FuncionarioSelecionado.Id
                };

                // Salva no contexto
                contexto.Apontamentos.Add(apontamento);
                int resultado = contexto.SaveChanges();

                // Deu certo o registro
                if (resultado > 0)
                {
                    MessageBox.Show("Ponto registrado com sucesso!");
                    txtMatricula.Clear();
                    FuncionarioSelecionado = null;
                    lblNomeFuncionario.Text = "";
                }
            }
        }
    }
}
