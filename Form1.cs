using ControlePonto.Data;

namespace ControlePonto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ControlePontoDbContext contexto = new ControlePontoDbContext();
        }
    }
}
