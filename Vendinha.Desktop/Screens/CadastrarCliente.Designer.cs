namespace Vendinha.Desktop.Screens
{
    partial class CadastrarCliente
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
            label1 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            pickerData = new DateTimePicker();
            label4 = new Label();
            txtEmail = new TextBox();
            btnSalvar = new Vendinha.Desktop.Components.PrimaryButton(components);
            lblErros = new Label();
            SuspendLayout();
            //
            // lblTitulo
            //
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 28F);
            lblTitulo.Location = new Point(114, 30);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 51);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastrar Cliente";
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(114, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome completo *";
            //
            // txtNome
            //
            txtNome.Location = new Point(114, 127);
            txtNome.Margin = new Padding(2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(541, 23);
            txtNome.TabIndex = 2;
            //
            // label2
            //
            label2.AutoSize = true;
            label2.Location = new Point(114, 165);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF *";
            //
            // txtCpf
            //
            txtCpf.Location = new Point(114, 182);
            txtCpf.Margin = new Padding(2);
            txtCpf.MaxLength = 14;
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "000.000.000-00";
            txtCpf.Size = new Size(250, 23);
            txtCpf.TabIndex = 4;
            //
            // label3
            //
            label3.AutoSize = true;
            label3.Location = new Point(405, 165);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "Data de nascimento *";
            //
            // pickerData
            //
            pickerData.CustomFormat = "dd/MM/yyyy";
            pickerData.Format = DateTimePickerFormat.Custom;
            pickerData.Location = new Point(405, 182);
            pickerData.Margin = new Padding(2);
            pickerData.Name = "pickerData";
            pickerData.Size = new Size(250, 23);
            pickerData.TabIndex = 6;
            //
            // label4
            //
            label4.AutoSize = true;
            label4.Location = new Point(114, 220);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "E-mail";
            //
            // txtEmail
            //
            txtEmail.Location = new Point(114, 237);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 8;
            //
            // btnSalvar
            //
            btnSalvar.BackColor = Color.DarkGreen;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(282, 285);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(190, 50);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            //
            // lblErros
            //
            lblErros.AutoSize = true;
            lblErros.Font = new Font("Segoe UI", 10F);
            lblErros.ForeColor = Color.Red;
            lblErros.Location = new Point(114, 350);
            lblErros.Margin = new Padding(2, 0, 2, 0);
            lblErros.MaximumSize = new Size(541, 0);
            lblErros.Name = "lblErros";
            lblErros.Size = new Size(0, 19);
            lblErros.TabIndex = 10;
            //
            // CadastrarCliente
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 460);
            Controls.Add(lblErros);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(pickerData);
            Controls.Add(label3);
            Controls.Add(txtCpf);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "CadastrarCliente";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private DateTimePicker pickerData;
        private Label label4;
        private TextBox txtEmail;
        private Components.PrimaryButton btnSalvar;
        private Label lblErros;
    }
}
