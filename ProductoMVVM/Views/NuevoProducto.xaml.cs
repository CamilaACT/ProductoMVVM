using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class NuevoProducto : ContentPage
{
	public NuevoProducto()
	{
		InitializeComponent();
        BindingContext = new NuevoProductoViewModel();
    }
}