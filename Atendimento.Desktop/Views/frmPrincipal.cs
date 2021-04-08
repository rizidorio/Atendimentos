using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento.Desktop.Views
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void abrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario = pnlPrincipalConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                pnlPrincipalConteudo.Controls.Add(formulario);
                formulario.Show();
                formulario.BringToFront();
            }
        }

        private void btnMenuFinanceiro_Click(object sender, EventArgs e)
        {
            abrirForm<Financeiro.frmFinanceiroPrincipal>();
        }

        private void btnPrincipalFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
