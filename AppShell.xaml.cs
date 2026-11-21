using CatalogoMAUI_SCI.Views;
namespace CatalogoMAUI_SCI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("producto-detalle", typeof(ProductoDetallePage));
        }
    }
}
