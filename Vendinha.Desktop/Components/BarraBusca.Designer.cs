namespace Vendinha.Desktop.Components
{
    partial class BarraBusca
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

            Font = new Font("Calisto MT", 12, FontStyle.Regular, GraphicsUnit.Point);
            BorderStyle = BorderStyle.FixedSingle;
            PlaceholderText = "Buscar por nome...";
            Width = 250;
        }

        #endregion
    }
}
