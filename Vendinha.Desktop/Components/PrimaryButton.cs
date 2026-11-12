using System.ComponentModel;

namespace Vendinha.Desktop.Components
{
    public partial class PrimaryButton : Button
    {
        public PrimaryButton()
        {
            InitializeComponent();
        }

        public PrimaryButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
