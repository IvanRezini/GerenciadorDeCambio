namespace GerenciadorDeCambio
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroMoeda = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarMoeda = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTransacao = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.moedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCliente});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroCliente
            // 
            this.cadastroCliente.Name = "cadastroCliente";
            this.cadastroCliente.Size = new System.Drawing.Size(121, 22);
            this.cadastroCliente.Text = "Cadastro";
            this.cadastroCliente.Click += new System.EventHandler(this.cadastroCliente_Click);
            // 
            // moedaToolStripMenuItem
            // 
            this.moedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroMoeda,
            this.atualizarMoeda});
            this.moedaToolStripMenuItem.Name = "moedaToolStripMenuItem";
            this.moedaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.moedaToolStripMenuItem.Text = "Moeda";
            // 
            // cadastroMoeda
            // 
            this.cadastroMoeda.Name = "cadastroMoeda";
            this.cadastroMoeda.Size = new System.Drawing.Size(121, 22);
            this.cadastroMoeda.Text = "Cadastro";
            this.cadastroMoeda.Click += new System.EventHandler(this.cadastroMoeda_Click);
            // 
            // atualizarMoeda
            // 
            this.atualizarMoeda.Name = "atualizarMoeda";
            this.atualizarMoeda.Size = new System.Drawing.Size(121, 22);
            this.atualizarMoeda.Text = "Atualizar";
            this.atualizarMoeda.Click += new System.EventHandler(this.atualizarMoeda_Click);
            // 
            // buttonTransacao
            // 
            this.buttonTransacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransacao.Location = new System.Drawing.Point(45, 84);
            this.buttonTransacao.Name = "buttonTransacao";
            this.buttonTransacao.Size = new System.Drawing.Size(161, 39);
            this.buttonTransacao.TabIndex = 1;
            this.buttonTransacao.Text = "Transação";
            this.buttonTransacao.UseVisualStyleBackColor = true;
            this.buttonTransacao.Click += new System.EventHandler(this.buttonTransacao_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTransacao);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formPrincipal";
            this.Text = "Gestão";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem moedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroMoeda;
        private System.Windows.Forms.ToolStripMenuItem atualizarMoeda;
        private System.Windows.Forms.Button buttonTransacao;
    }
}

