
namespace Atendimento.Desktop.Views
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pnlPrincipalCabecalho = new System.Windows.Forms.Panel();
            this.lblPrincipalTitulo = new System.Windows.Forms.Label();
            this.btnPrincipalFechar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlPrincipalMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMenuFinanceiro = new System.Windows.Forms.Button();
            this.btnMenuFuncionarios = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.btnMenuAtendimentos = new System.Windows.Forms.Button();
            this.pnlPrincipalStatusBar = new System.Windows.Forms.Panel();
            this.pnlPrincipalConteudo = new System.Windows.Forms.Panel();
            this.pnlPrincipalCabecalho.SuspendLayout();
            this.pnlPrincipalMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipalCabecalho
            // 
            this.pnlPrincipalCabecalho.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPrincipalCabecalho.Controls.Add(this.lblPrincipalTitulo);
            this.pnlPrincipalCabecalho.Controls.Add(this.btnPrincipalFechar);
            this.pnlPrincipalCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPrincipalCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipalCabecalho.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPrincipalCabecalho.Name = "pnlPrincipalCabecalho";
            this.pnlPrincipalCabecalho.Size = new System.Drawing.Size(1200, 35);
            this.pnlPrincipalCabecalho.TabIndex = 0;
            // 
            // lblPrincipalTitulo
            // 
            this.lblPrincipalTitulo.AutoSize = true;
            this.lblPrincipalTitulo.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrincipalTitulo.ForeColor = System.Drawing.Color.White;
            this.lblPrincipalTitulo.Location = new System.Drawing.Point(48, 6);
            this.lblPrincipalTitulo.Name = "lblPrincipalTitulo";
            this.lblPrincipalTitulo.Size = new System.Drawing.Size(164, 23);
            this.lblPrincipalTitulo.TabIndex = 1;
            this.lblPrincipalTitulo.Text = "Atendimentos";
            // 
            // btnPrincipalFechar
            // 
            this.btnPrincipalFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrincipalFechar.FlatAppearance.BorderSize = 0;
            this.btnPrincipalFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnPrincipalFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnPrincipalFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipalFechar.Image = global::Atendimento.Desktop.Properties.Resources.fechar32;
            this.btnPrincipalFechar.Location = new System.Drawing.Point(1165, 0);
            this.btnPrincipalFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrincipalFechar.Name = "btnPrincipalFechar";
            this.btnPrincipalFechar.Size = new System.Drawing.Size(35, 35);
            this.btnPrincipalFechar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnPrincipalFechar, "Fechar");
            this.btnPrincipalFechar.UseVisualStyleBackColor = true;
            this.btnPrincipalFechar.Click += new System.EventHandler(this.btnPrincipalFechar_Click);
            // 
            // pnlPrincipalMenu
            // 
            this.pnlPrincipalMenu.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPrincipalMenu.Controls.Add(this.button1);
            this.pnlPrincipalMenu.Controls.Add(this.btnMenuFinanceiro);
            this.pnlPrincipalMenu.Controls.Add(this.btnMenuFuncionarios);
            this.pnlPrincipalMenu.Controls.Add(this.btnMenuClientes);
            this.pnlPrincipalMenu.Controls.Add(this.btnMenuAtendimentos);
            this.pnlPrincipalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPrincipalMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlPrincipalMenu.Name = "pnlPrincipalMenu";
            this.pnlPrincipalMenu.Size = new System.Drawing.Size(260, 765);
            this.pnlPrincipalMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apoio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMenuFinanceiro
            // 
            this.btnMenuFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnMenuFinanceiro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFinanceiro.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuFinanceiro.ForeColor = System.Drawing.Color.White;
            this.btnMenuFinanceiro.Location = new System.Drawing.Point(0, 249);
            this.btnMenuFinanceiro.Name = "btnMenuFinanceiro";
            this.btnMenuFinanceiro.Size = new System.Drawing.Size(260, 54);
            this.btnMenuFinanceiro.TabIndex = 3;
            this.btnMenuFinanceiro.Text = "Financeiro";
            this.btnMenuFinanceiro.UseVisualStyleBackColor = true;
            this.btnMenuFinanceiro.Click += new System.EventHandler(this.btnMenuFinanceiro_Click);
            // 
            // btnMenuFuncionarios
            // 
            this.btnMenuFuncionarios.FlatAppearance.BorderSize = 0;
            this.btnMenuFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuFuncionarios.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnMenuFuncionarios.Location = new System.Drawing.Point(0, 175);
            this.btnMenuFuncionarios.Name = "btnMenuFuncionarios";
            this.btnMenuFuncionarios.Size = new System.Drawing.Size(260, 54);
            this.btnMenuFuncionarios.TabIndex = 2;
            this.btnMenuFuncionarios.Text = "Funcionários";
            this.btnMenuFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuClientes.ForeColor = System.Drawing.Color.White;
            this.btnMenuClientes.Location = new System.Drawing.Point(0, 101);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Size = new System.Drawing.Size(260, 54);
            this.btnMenuClientes.TabIndex = 1;
            this.btnMenuClientes.Text = "Clientes";
            this.btnMenuClientes.UseVisualStyleBackColor = true;
            // 
            // btnMenuAtendimentos
            // 
            this.btnMenuAtendimentos.FlatAppearance.BorderSize = 0;
            this.btnMenuAtendimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuAtendimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnMenuAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAtendimentos.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenuAtendimentos.ForeColor = System.Drawing.Color.White;
            this.btnMenuAtendimentos.Location = new System.Drawing.Point(0, 27);
            this.btnMenuAtendimentos.Name = "btnMenuAtendimentos";
            this.btnMenuAtendimentos.Size = new System.Drawing.Size(260, 54);
            this.btnMenuAtendimentos.TabIndex = 0;
            this.btnMenuAtendimentos.Text = "Início";
            this.btnMenuAtendimentos.UseVisualStyleBackColor = true;
            // 
            // pnlPrincipalStatusBar
            // 
            this.pnlPrincipalStatusBar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlPrincipalStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPrincipalStatusBar.Location = new System.Drawing.Point(260, 765);
            this.pnlPrincipalStatusBar.Name = "pnlPrincipalStatusBar";
            this.pnlPrincipalStatusBar.Size = new System.Drawing.Size(940, 35);
            this.pnlPrincipalStatusBar.TabIndex = 2;
            // 
            // pnlPrincipalConteudo
            // 
            this.pnlPrincipalConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipalConteudo.Location = new System.Drawing.Point(260, 35);
            this.pnlPrincipalConteudo.Name = "pnlPrincipalConteudo";
            this.pnlPrincipalConteudo.Size = new System.Drawing.Size(940, 730);
            this.pnlPrincipalConteudo.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AccessibleDescription = "Formulário principal, contendo os menus";
            this.AccessibleName = "Formulário principal";
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlPrincipalConteudo);
            this.Controls.Add(this.pnlPrincipalStatusBar);
            this.Controls.Add(this.pnlPrincipalMenu);
            this.Controls.Add(this.pnlPrincipalCabecalho);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlPrincipalCabecalho.ResumeLayout(false);
            this.pnlPrincipalCabecalho.PerformLayout();
            this.pnlPrincipalMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipalCabecalho;
        private System.Windows.Forms.Button btnPrincipalFechar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlPrincipalMenu;
        private System.Windows.Forms.Label lblPrincipalTitulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMenuFinanceiro;
        private System.Windows.Forms.Button btnMenuFuncionarios;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Button btnMenuAtendimentos;
        private System.Windows.Forms.Panel pnlPrincipalStatusBar;
        private System.Windows.Forms.Panel pnlPrincipalConteudo;
    }
}