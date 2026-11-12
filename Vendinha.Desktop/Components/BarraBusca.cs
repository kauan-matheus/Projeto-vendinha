using System.ComponentModel;

namespace Vendinha.Desktop.Components
{
    public partial class BarraBusca : TextBox
    {
        public BarraBusca()
        {
            InitializeComponent();
        }

        public BarraBusca(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
