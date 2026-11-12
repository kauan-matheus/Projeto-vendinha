namespace Vendinha.Desktop.Components
{
    partial class PrimaryButton
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            BackColor = Color.DarkGreen;
            Font = new Font("Calisto MT", 12, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            UseVisualStyleBackColor = false;
            Width = 190;
            Height = 50;
        }

        #endregion
    }
}
