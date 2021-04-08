using Atendimento.Desktop.BLL;
using Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento.Desktop.Views.Financeiro
{
    public partial class frmFormasPagamento : Form
    {
        FormaPagamentoBLL formaPagamentoBLL;

        public frmFormasPagamento(IFormaPagamentoService service)
        {
            InitializeComponent();
            formaPagamentoBLL = new FormaPagamentoBLL(service);

            popularGrid();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void popularGrid()
        {
            try
            {
                dgvFormasPagamento.DataSource = await formaPagamentoBLL.getAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
