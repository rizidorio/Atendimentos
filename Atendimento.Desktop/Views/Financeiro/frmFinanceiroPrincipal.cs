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
    public partial class frmFinanceiroPrincipal : Form
    {
        public frmFinanceiroPrincipal()
        {
            InitializeComponent();
        }

        private void btnNovaFormaPagamento_Click(object sender, EventArgs e)
        {
            frmNovaFormaPagamento frm = new frmNovaFormaPagamento();
            frm.ShowDialog();
        }

        private void btnFinanceiroFormaPagamentoTodos_Click(object sender, EventArgs e)
        {
            frmFormasPagamento frm = new frmFormasPagamento();
            frm.Show();
        }
    }
}
