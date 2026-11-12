using Vendinha.Desktop.Components;

namespace Vendinha.Desktop
{
    partial class Form1
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
            btnListar = new PrimaryButton(components);
            btnCadastrar = new PrimaryButton(components);
            lblStatus = new Label();
            SuspendLayout();
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(175, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 59);
            label1.TabIndex = 0;
            label1.Text = "Vendinha";
            //
            // btnListar
            //
            btnListar.BackColor = Color.DarkGreen;
            btnListar.FlatStyle = FlatStyle.Flat;
            btnListar.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnListar.ForeColor = Color.White;
            btnListar.Location = new Point(80, 173);
            btnListar.Margin = new Padding(2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(190, 50);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar Clientes";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            //
            // btnCadastrar
            //
            btnCadastrar.BackColor = Color.DarkGreen;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Calisto MT", 12F, FontStyle.Bold);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(290, 173);
            btnCadastrar.Margin = new Padding(2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(190, 50);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar Cliente";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            //
            // lblStatus
            //
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.ForeColor = Color.Green;
            lblStatus.Location = new Point(80, 240);
            lblStatus.Margin = new Padding(2, 0, 2, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 3;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 289);
            Controls.Add(lblStatus);
            Controls.Add(btnCadastrar);
            Controls.Add(btnListar);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vendinha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PrimaryButton btnListar;
        private PrimaryButton btnCadastrar;
        private Label lblStatus;
    }
}
