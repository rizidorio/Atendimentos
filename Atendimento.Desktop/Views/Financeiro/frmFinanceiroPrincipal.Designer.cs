
namespace Atendimento.Desktop.Views.Financeiro
{
    partial class frmFinanceiroPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPrincipalCabecalho = new System.Windows.Forms.Panel();
            this.lblFinanceiroTitulo = new System.Windows.Forms.Label();
            this.pnlFinanceiroFormaPagamento = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinanceiroFormaPagamentoTodos = new System.Windows.Forms.Button();
            this.btnNovaFormaPagamento = new System.Windows.Forms.Button();
            this.lblFinanceiroFormaPagamentoTitulo = new System.Windows.Forms.Label();
            this.pnlPrincipalCabecalho.SuspendLayout();
            this.pnlFinanceiroFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipalCabecalho
            // 
            this.pnlPrincipalCabecalho.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPrincipalCabecalho.Controls.Add(this.lblFinanceiroTitulo);
            this.pnlPrincipalCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipalCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipalCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipalCabecalho.Name = "pnlPrincipalCabecalho";
            this.pnlPrincipalCabecalho.Size = new System.Drawing.Size(800, 35);
            this.pnlPrincipalCabecalho.TabIndex = 1;
            // 
            // lblFinanceiroTitulo
            // 
            this.lblFinanceiroTitulo.AutoSize = true;
            this.lblFinanceiroTitulo.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinanceiroTitulo.ForeColor = System.Drawing.Color.White;
            this.lblFinanceiroTitulo.Location = new System.Drawing.Point(14, 6);
            this.lblFinanceiroTitulo.Name = "lblFinanceiroTitulo";
            this.lblFinanceiroTitulo.Size = new System.Drawing.Size(117, 22);
            this.lblFinanceiroTitulo.TabIndex = 1;
            this.lblFinanceiroTitulo.Text = "Financeiro";
            // 
            // pnlFinanceiroFormaPagamento
            // 
            this.pnlFinanceiroFormaPagamento.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlFinanceiroFormaPagamento.Controls.Add(this.panel1);
            this.pnlFinanceiroFormaPagamento.Controls.Add(this.btnFinanceiroFormaPagamentoTodos);
            this.pnlFinanceiroFormaPagamento.Controls.Add(this.btnNovaFormaPagamento);
            this.pnlFinanceiroFormaPagamento.Controls.Add(this.lblFinanceiroFormaPagamentoTitulo);
            this.pnlFinanceiroFormaPagamento.Location = new System.Drawing.Point(12, 50);
            this.pnlFinanceiroFormaPagamento.Name = "pnlFinanceiroFormaPagamento";
            this.pnlFinanceiroFormaPagamento.Size = new System.Drawing.Size(300, 136);
            this.pnlFinanceiroFormaPagamento.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Atendimento.Desktop.Properties.Resources.pgto96;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(204, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(81, 82);
            this.panel1.TabIndex = 3;
            // 
            // btnFinanceiroFormaPagamentoTodos
            // 
            this.btnFinanceiroFormaPagamentoTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(68)))), ((int)(((byte)(40)))));
            this.btnFinanceiroFormaPagamentoTodos.FlatAppearance.BorderSize = 0;
            this.btnFinanceiroFormaPagamentoTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnFinanceiroFormaPagamentoTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnFinanceiroFormaPagamentoTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiroFormaPagamentoTodos.ForeColor = System.Drawing.Color.White;
            this.btnFinanceiroFormaPagamentoTodos.Location = new System.Drawing.Point(11, 90);
            this.btnFinanceiroFormaPagamentoTodos.Name = "btnFinanceiroFormaPagamentoTodos";
            this.btnFinanceiroFormaPagamentoTodos.Size = new System.Drawing.Size(168, 27);
            this.btnFinanceiroFormaPagamentoTodos.TabIndex = 2;
            this.btnFinanceiroFormaPagamentoTodos.Text = "Mostrar todos";
            this.btnFinanceiroFormaPagamentoTodos.UseVisualStyleBackColor = false;
            this.btnFinanceiroFormaPagamentoTodos.Click += new System.EventHandler(this.btnFinanceiroFormaPagamentoTodos_Click);
            // 
            // btnNovaFormaPagamento
            // 
            this.btnNovaFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(68)))), ((int)(((byte)(40)))));
            this.btnNovaFormaPagamento.FlatAppearance.BorderSize = 0;
            this.btnNovaFormaPagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab;
            this.btnNovaFormaPagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnNovaFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.btnNovaFormaPagamento.Location = new System.Drawing.Point(11, 49);
            this.btnNovaFormaPagamento.Name = "btnNovaFormaPagamento";
            this.btnNovaFormaPagamento.Size = new System.Drawing.Size(168, 27);
            this.btnNovaFormaPagamento.TabIndex = 2;
            this.btnNovaFormaPagamento.Text = "Nova forma pagamento";
            this.btnNovaFormaPagamento.UseVisualStyleBackColor = false;
            this.btnNovaFormaPagamento.Click += new System.EventHandler(this.btnNovaFormaPagamento_Click);
            // 
            // lblFinanceiroFormaPagamentoTitulo
            // 
            this.lblFinanceiroFormaPagamentoTitulo.AutoSize = true;
            this.lblFinanceiroFormaPagamentoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblFinanceiroFormaPagamentoTitulo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinanceiroFormaPagamentoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblFinanceiroFormaPagamentoTitulo.Location = new System.Drawing.Point(11, 11);
            this.lblFinanceiroFormaPagamentoTitulo.Name = "lblFinanceiroFormaPagamentoTitulo";
            this.lblFinanceiroFormaPagamentoTitulo.Size = new System.Drawing.Size(180, 18);
            this.lblFinanceiroFormaPagamentoTitulo.TabIndex = 1;
            this.lblFinanceiroFormaPagamentoTitulo.Text = "Forma de pagamento";
            // 
            // frmFinanceiroPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlFinanceiroFormaPagamento);
            this.Controls.Add(this.pnlPrincipalCabecalho);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFinanceiroPrincipal";
            this.pnlPrincipalCabecalho.ResumeLayout(false);
            this.pnlPrincipalCabecalho.PerformLayout();
            this.pnlFinanceiroFormaPagamento.ResumeLayout(false);
            this.pnlFinanceiroFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipalCabecalho;
        private System.Windows.Forms.Label lblFinanceiroTitulo;
        private System.Windows.Forms.Panel pnlFinanceiroFormaPagamento;
        private System.Windows.Forms.Button btnFinanceiroFormaPagamentoTodos;
        private System.Windows.Forms.Button btnNovaFormaPagamento;
        private System.Windows.Forms.Label lblFinanceiroFormaPagamentoTitulo;
        private System.Windows.Forms.Panel panel1;
    }
}