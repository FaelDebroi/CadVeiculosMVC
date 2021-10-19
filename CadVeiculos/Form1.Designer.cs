namespace CadVeiculos
{
    partial class frmPrincipal
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
            this.grpDados = new System.Windows.Forms.GroupBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.mskPlaca = new System.Windows.Forms.MaskedTextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.listVeiculos = new System.Windows.Forms.ListView();
            this.colPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDados
            // 
            this.grpDados.Controls.Add(this.txtModelo);
            this.grpDados.Controls.Add(this.mskPlaca);
            this.grpDados.Controls.Add(this.lblModelo);
            this.grpDados.Controls.Add(this.lblPlaca);
            this.grpDados.Location = new System.Drawing.Point(34, 24);
            this.grpDados.Name = "grpDados";
            this.grpDados.Size = new System.Drawing.Size(671, 132);
            this.grpDados.TabIndex = 0;
            this.grpDados.TabStop = false;
            this.grpDados.Text = "Dados Veiculo";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(36, 44);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(43, 17);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(31, 79);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 1;
            this.lblModelo.Text = "Modelo";
            // 
            // mskPlaca
            // 
            this.mskPlaca.Enabled = false;
            this.mskPlaca.Location = new System.Drawing.Point(107, 42);
            this.mskPlaca.Mask = "LLL-0000";
            this.mskPlaca.Name = "mskPlaca";
            this.mskPlaca.Size = new System.Drawing.Size(202, 22);
            this.mskPlaca.TabIndex = 2;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(107, 79);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(202, 22);
            this.txtModelo.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(34, 181);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 23);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(34, 220);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(34, 260);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(101, 23);
            this.btnLista.TabIndex = 6;
            this.btnLista.Text = "LISTAR";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(34, 301);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 23);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // listVeiculos
            // 
            this.listVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPlaca,
            this.colModelo});
            this.listVeiculos.FullRowSelect = true;
            this.listVeiculos.HideSelection = false;
            this.listVeiculos.Location = new System.Drawing.Point(141, 181);
            this.listVeiculos.Name = "listVeiculos";
            this.listVeiculos.Size = new System.Drawing.Size(564, 143);
            this.listVeiculos.TabIndex = 8;
            this.listVeiculos.UseCompatibleStateImageBehavior = false;
            this.listVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // colPlaca
            // 
            this.colPlaca.Text = "Placa";
            this.colPlaca.Width = 144;
            // 
            // colModelo
            // 
            this.colModelo.Text = "Modelo";
            this.colModelo.Width = 216;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 349);
            this.Controls.Add(this.listVeiculos);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.grpDados);
            this.Name = "frmPrincipal";
            this.Text = "Cadastro de Veiculos";
            this.grpDados.ResumeLayout(false);
            this.grpDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDados;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.MaskedTextBox mskPlaca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView listVeiculos;
        private System.Windows.Forms.ColumnHeader colPlaca;
        private System.Windows.Forms.ColumnHeader colModelo;
    }
}

