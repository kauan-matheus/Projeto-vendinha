namespace Vendinha.Desktop.Screens
{
    partial class ListarClientes
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
            label1 = new Label();
            txtBusca = new Vendinha.Desktop.Components.BarraBusca(components);
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Cpf = new DataGridViewTextBoxColumn();
            Idade = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TotalDevido = new DataGridViewTextBoxColumn();
            btnAnterior = new Vendinha.Desktop.Components.PrimaryButton(components);
            lblPagina = new Label();
            btnProxima = new Vendinha.Desktop.Components.PrimaryButton(components);
            btnEditar = new Vendinha.Desktop.Components.PrimaryButton(components);
            btnExcluir = new Vendinha.Desktop.Components.PrimaryButton(components);
            btnDividas = new Vendinha.Desktop.Components.PrimaryButton(components);
            lblMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(31, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 51);
            label1.TabIndex = 0;
            label1.Text = "Clientes";
            //
            // txtBusca
            //
            txtBusca.BorderStyle = BorderStyle.FixedSingle;
            txtBusca.Font = new Font("Calisto MT", 12F);
            txtBusca.Location = new Point(539, 48);
            txtBusca.Name = "txtBusca";
            txtBusca.PlaceholderText = "Buscar por nome...";
            txtBusca.Size = new Size(250, 26);
            txtBusca.TabIndex = 1;
            txtBusca.TextChanged += txtBusca_TextChanged;
            //
            // dataGridView1
            //
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Cpf, Idade, Email, TotalDevido });
            dataGridView1.Location = new Point(31, 85);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(758, 300);
            dataGridView1.TabIndex = 2;
            //
            // Nome
            //
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.FillWeight = 200F;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            //
            // Cpf
            //
            Cpf.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Cpf.HeaderText = "CPF";
            Cpf.MinimumWidth = 8;
            Cpf.Name = "Cpf";
            Cpf.ReadOnly = true;
            //
            // Idade
            //
            Idade.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Idade.FillWeight = 50F;
            Idade.HeaderText = "Idade";
            Idade.MinimumWidth = 8;
            Idade.Name = "Idade";
            Idade.ReadOnly = true;
            //
            // Email
            //
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.FillWeight = 150F;
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.ReadOnly = true;
            //
            // TotalDevido
            //
            TotalDevido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TotalDevido.HeaderText = "Total devido";
            TotalDevido.MinimumWidth = 8;
            TotalDevido.Name = "TotalDevido";
            TotalDevido.ReadOnly = true;
            //
            // btnAnterior
            //
            btnAnterior.BackColor = Color.DarkGreen;
            btnAnterior.FlatStyle = FlatStyle.Flat;
            btnAnterior.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnAnterior.ForeColor = Color.White;
            btnAnterior.Location = new Point(31, 395);
            btnAnterior.Margin = new Padding(2);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(130, 40);
            btnAnterior.TabIndex = 3;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = false;
            btnAnterior.Click += btnAnterior_Click;
            //
            // lblPagina
            //
            lblPagina.Font = new Font("Segoe UI", 11F);
            lblPagina.Location = new Point(260, 404);
            lblPagina.Margin = new Padding(2, 0, 2, 0);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(300, 20);
            lblPagina.TabIndex = 4;
            lblPagina.Text = "Página 1 de 1";
            lblPagina.TextAlign = ContentAlignment.MiddleCenter;
            //
            // btnProxima
            //
            btnProxima.BackColor = Color.DarkGreen;
            btnProxima.FlatStyle = FlatStyle.Flat;
            btnProxima.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnProxima.ForeColor = Color.White;
            btnProxima.Location = new Point(659, 395);
            btnProxima.Margin = new Padding(2);
            btnProxima.Name = "btnProxima";
            btnProxima.Size = new Size(130, 40);
            btnProxima.TabIndex = 5;
            btnProxima.Text = "Próxima >";
            btnProxima.UseVisualStyleBackColor = false;
            btnProxima.Click += btnProxima_Click;
            //
            // btnEditar
            //
            btnEditar.BackColor = Color.DarkGreen;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(31, 445);
            btnEditar.Margin = new Padding(2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(190, 50);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            //
            // btnExcluir
            //
            btnExcluir.BackColor = Color.DarkGreen;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(231, 445);
            btnExcluir.Margin = new Padding(2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(190, 50);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            //
            // btnDividas
            //
            btnDividas.BackColor = Color.DarkGreen;
            btnDividas.FlatStyle = FlatStyle.Flat;
            btnDividas.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnDividas.ForeColor = Color.White;
            btnDividas.Location = new Point(431, 445);
            btnDividas.Margin = new Padding(2);
            btnDividas.Name = "btnDividas";
            btnDividas.Size = new Size(190, 50);
            btnDividas.TabIndex = 8;
            btnDividas.Text = "Dívidas";
            btnDividas.UseVisualStyleBackColor = false;
            btnDividas.Click += btnDividas_Click;
            //
            // lblMensagem
            //
            lblMensagem.AutoSize = true;
            lblMensagem.Font = new Font("Segoe UI", 11F);
            lblMensagem.Location = new Point(31, 505);
            lblMensagem.Margin = new Padding(2, 0, 2, 0);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 20);
            lblMensagem.TabIndex = 9;
            //
            // ListarClientes
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 540);
            Controls.Add(lblMensagem);
            Controls.Add(btnDividas);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnProxima);
            Controls.Add(lblPagina);
            Controls.Add(btnAnterior);
            Controls.Add(dataGridView1);
            Controls.Add(txtBusca);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ListarClientes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Components.BarraBusca txtBusca;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Cpf;
        private DataGridViewTextBoxColumn Idade;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn TotalDevido;
        private Components.PrimaryButton btnAnterior;
        private Label lblPagina;
        private Components.PrimaryButton btnProxima;
        private Components.PrimaryButton btnEditar;
        private Components.PrimaryButton btnExcluir;
        private Components.PrimaryButton btnDividas;
        private Label lblMensagem;
    }
}
