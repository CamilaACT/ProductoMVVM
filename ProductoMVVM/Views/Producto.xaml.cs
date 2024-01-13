using ProductoMVVM.ViewModels;

namespace ProductoMVVM.Views;

public partial class Producto : ContentPage
{
	public Producto()
	{
		InitializeComponent();
        BindingContext = new ProductoViewModel();
    }
}