namespace Vendinha.Desktop.Screens
{
    partial class DividasCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            dataGridView1 = new DataGridView();
            Valor = new DataGridViewTextBoxColumn();
            Situacao = new DataGridViewTextBoxColumn();
            DataCriacao = new DataGridViewTextBoxColumn();
            DataPagamento = new DataGridViewTextBoxColumn();
            btnMarcarPaga = new Vendinha.Desktop.Components.PrimaryButton(components);
            label1 = new Label();
            numValor = new NumericUpDown();
            btnCadastrar = new Vendinha.Desktop.Components.PrimaryButton(components);
            lblMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(31, 30);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(110, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Dívidas";
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Valor, Situacao, DataCriacao, DataPagamento });
            dataGridView1.Location = new Point(31, 85);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(638, 250);
            dataGridView1.TabIndex = 1;
            //
            // Valor
            //
            Valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Valor.HeaderText = "Valor";
            Valor.MinimumWidth = 8;
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            //
            // Situacao
            //
            Situacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Situacao.HeaderText = "Situação";
            Situacao.MinimumWidth = 8;
            Situacao.Name = "Situacao";
            Situacao.ReadOnly = true;
            //
            // DataCriacao
            //
            DataCriacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataCriacao.HeaderText = "Criada em";
            DataCriacao.MinimumWidth = 8;
            DataCriacao.Name = "DataCriacao";
            DataCriacao.ReadOnly = true;
            //
            // DataPagamento
            //
            DataPagamento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataPagamento.HeaderText = "Paga em";
            DataPagamento.MinimumWidth = 8;
            DataPagamento.Name = "DataPagamento";
            DataPagamento.ReadOnly = true;
            //
            // btnMarcarPaga
            //
            btnMarcarPaga.BackColor = Color.DarkGreen;
            btnMarcarPaga.FlatStyle = FlatStyle.Flat;
            btnMarcarPaga.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnMarcarPaga.ForeColor = Color.White;
            btnMarcarPaga.Location = new Point(31, 345);
            btnMarcarPaga.Margin = new Padding(2);
            btnMarcarPaga.Name = "btnMarcarPaga";
            btnMarcarPaga.Size = new Size(190, 50);
            btnMarcarPaga.TabIndex = 2;
            btnMarcarPaga.Text = "Marcar como paga";
            btnMarcarPaga.UseVisualStyleBackColor = false;
            btnMarcarPaga.Click += btnMarcarPaga_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(31, 415);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor da nova dívida *";
            //
            // numValor
            //
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(31, 437);
            numValor.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(150, 23);
            numValor.TabIndex = 4;
            numValor.ThousandsSeparator = true;
            //
            // btnCadastrar
            //
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(200, 423);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(190, 50);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar dívida";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            //
            // lblMensagem
            //
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 10F);
            lblMensagem.Location = new Point(31, 485);
            lblMensagem.Margin = new Padding(2, 0, 2, 0);
            lblMensagem.MaximumSize = new Size(638, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 19);
            lblMensagem.TabIndex = 6;
            //
            // DividasCliente
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 540);
            Controls.Add(lblMensagem);
            Controls.Add(btnCadastrar);
            Controls.Add(numValor);
            Controls.Add(label1);
            Controls.Add(btnMarcarPaga);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "DividasCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dívidas do Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Situacao;
        private DataGridViewTextBoxColumn DataCriacao;
        private DataGridViewTextBoxColumn DataPagamento;
        private Components.PrimaryButton btnMarcarPaga;
        private Label label1;
        private NumericUpDown numValor;
        private Components.PrimaryButton btnCadastrar;
        private Label lblMensagem;
    }
}
