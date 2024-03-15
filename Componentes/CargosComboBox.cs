using ControlePonto.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePonto.Componentes
{
    public partial class CargosComboBox : ComboBox
    {
        public CargosComboBox()
        {
            InitializeComponent();
            CarregaCargos();
        }

        public CargosComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            CarregaCargos();
        }

        private void CarregaCargos()
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                // Faz a conexão com o contexto
                using (var contexto = new ControlePontoDbContext())
                {
                    // Pega os cargos do banco
                    var cargos = contexto.Cargos.ToList();

                    // Adiciona os cargos como fonte de dados do combobox
                    this.DataSource = cargos;

                    // Adiciona o ID como valor combobox
                    this.ValueMember = "Id";
                    // Adiciona o nome para ser exibido no combobox
                    this.DisplayMember = "Nome";
                };
            }
        }
    }
}
